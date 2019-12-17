using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace HexapodControl
{
    
    public class Comm
    {
        //singleton
        private static Comm comm = null;
        //timer for timeout
        System.Timers.Timer timerTimeoutFrame = new System.Timers.Timer();
        //serial port
        SerialPort serialPortHexapod = new SerialPort();
        //response class
        public class HexapodResponse
        {
            public enum Status
            {
                NO_ERROR,
                ERROR,
            };

            public enum Error
            {
                NO_ERROR,
                TIMEOUT,
            };

            String sentFrame = null;
            String response = null;
            Status status = Status.NO_ERROR;
            Error error = Error.NO_ERROR;

            public string GetSentFrame()
            {
                return this.sentFrame;
            }
            public string GetResponse()
            {
                return this.response;
            }
            public Status GetStatus()
            {
                return this.status;
            }
            public Error GetError()
            {
                return this.error;
            }
            public HexapodResponse(String sentFrame, String response, Status status)
            {
                this.sentFrame = sentFrame;
                this.response = response;
                this.status = status;
                this.error = Error.NO_ERROR;
            }
            public HexapodResponse(String sentFrame, String response, Status status, Error error)
            {
                this.sentFrame = sentFrame;
                this.response = response;
                this.status = status;
                this.error = error;
            }
        }

        //declaration of th callback when frame is received
        public delegate void CallbackReceiveFrame(HexapodResponse data);
        //declaration of th callback when frame is sending
        public delegate void CallbackSentFrame(String data);
        //callback variable
        private List<CallbackReceiveFrame> callbackReceiveFrame = new List<CallbackReceiveFrame>();
        private List<CallbackSentFrame> callbackSendingFrame = new List<CallbackSentFrame>();



        private volatile List<String> fifoSend = new List<String>();
        private volatile bool isSending = false;

        //constructor
        private Comm()
        {
            this.serialPortHexapod.BaudRate = 115200;
            this.serialPortHexapod.PortName = "COM6";
            this.serialPortHexapod.DataReceived += serialPortHexapod_DataReceived;

            this.timerTimeoutFrame.AutoReset = false;
            this.timerTimeoutFrame.Interval = 100000;
        }

        //singleton
        public static Comm GetInstance()
        {
            if(comm == null)
            {
                comm = new Comm();
            }
            return comm;
        }
        /// <summary>
        /// get portnames of connected port
        /// </summary>
        /// <returns>Array of string containing availables ports</returns>
        public String[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        /// <summary>
        /// set the port to communicate
        /// </summary>
        /// <param name="data"></param>
        public void SetPortName(String data)
        {
            this.serialPortHexapod.PortName = data;
        }
        /// <summary>
        /// open the port
        /// </summary>
        public void Open()
        {
            this.serialPortHexapod.Open();
            Thread th = new Thread(serialPortHexapod_DataSent);
            th.Start();
        }
        /// <summary>
        /// close the port
        /// </summary>
        public void Close()
        {
            this.timerTimeoutFrame.Elapsed -= TimerTimeoutFrame_Elapsed;
            this.timerTimeoutFrame.Stop();
            this.fifoSend.Clear();
            this.isSending = false;
            try
            {
                this.serialPortHexapod.Close();
            }
            catch
            {

            }
            
        }
        /// <summary>
        /// check if port is open
        /// </summary>
        /// <returns>true if open</returns>
        public bool IsOpen()
        {
            return this.serialPortHexapod.IsOpen;
        }
        /// <summary>
        /// set the callback, hits when data is received
        /// </summary>
        /// <param name="callbackReceiveFrame">callback to set when data has been received</param>
        public void SetCallBackReceive( CallbackReceiveFrame callbackReceiveFrame)
        {
            if(-1 == this.callbackReceiveFrame.IndexOf(callbackReceiveFrame))
            {
                this.callbackReceiveFrame.Add(callbackReceiveFrame);
            }
        }
        /// <summary>
        /// remove the callback, hits when data is received
        /// </summary>
        /// <param name="callbackReceiveFrame">callback to set when data has been received</param>
        public void RemoveCallBackReceive(CallbackReceiveFrame callbackReceiveFrame)
        {
            if (-1 != this.callbackReceiveFrame.IndexOf(callbackReceiveFrame))
            {
                this.callbackReceiveFrame.Remove(callbackReceiveFrame);
            }
        }
        /// <summary>
        /// set the callback, hits when data is sending
        /// </summary>
        /// <param name="callbackSendingFrame">callback to set when data has been received</param>
        public void SetCallBackSentFrame(CallbackSentFrame callbackSendingFrame)
        {
            if (-1 == this.callbackSendingFrame.IndexOf(callbackSendingFrame))
            {
                this.callbackSendingFrame.Add(callbackSendingFrame);
            }
        }
        /// <summary>
        /// Remove the callback, hits when data is sending
        /// </summary>
        /// <param name="callbackSendingFrame">callback to set when data has been received</param>
        public void RemoveCallBackSentFrame(CallbackSentFrame callbackSendingFrame)
        {
            if (-1 != this.callbackSendingFrame.IndexOf(callbackSendingFrame))
            {
                this.callbackSendingFrame.Remove(callbackSendingFrame);
            }
        }
        /// <summary>
        /// send data to port
        /// </summary>
        /// <param name="data">data to sent</param>
        public void SendData( String data )
        {
            this.fifoSend.Add(data);
        }
        /// <summary>
        /// send data to port
        /// </summary>
        /// <param name="data">string array data to sent</param>
        public void SendData(String[] data)
        {
            this.fifoSend.AddRange(data);
        }
        /// <summary>
        /// get fifo size
        /// </summary>
        /// <returns>the size of the transmission fifo</returns>
        public int GetFifoSize()
        {
            return this.fifoSend.Count;
        }

        private void serialPortHexapod_DataSent()
        {
            while (this.serialPortHexapod.IsOpen)
            {
                if(((this.fifoSend.Count != 0)) && (!this.isSending) )
                {
                    this.isSending = true;
                    String data = this.fifoSend[0];
                    //send to port com
                    this.serialPortHexapod.Write(data);
                    //enable timeout
                    this.timerTimeoutFrame.Elapsed += TimerTimeoutFrame_Elapsed;
                    this.timerTimeoutFrame.Start();

                    foreach(CallbackSentFrame cb in this.callbackSendingFrame)
                    {
                        cb(data);
                    }
                }
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// timer for timeout, hits when times up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTimeoutFrame_Elapsed(object sender, EventArgs e)
        {
            //call the callback whith error
            HexapodResponse hexapodResponse = new HexapodResponse(this.fifoSend[0], null, HexapodResponse.Status.ERROR, HexapodResponse.Error.TIMEOUT);
            foreach (CallbackReceiveFrame cb in this.callbackReceiveFrame)
            {
                cb(hexapodResponse);
            }

            this.timerTimeoutFrame.Elapsed -= TimerTimeoutFrame_Elapsed;
            //try to send same frame
            this.isSending = false;
        }

        String data = null;
        private void serialPortHexapod_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //get input string
            data += this.serialPortHexapod.ReadExisting();

            //wait for a full frame
            if (data.Contains('<') && data.Contains('>'))
            {
                //get frames from string
                String[] frames = data.Substring(data.IndexOf('<')).Split('>');

                String frame_sent = "";
                //remove frame sent from fifo
                if (this.fifoSend.Count > 0)
                {
                    //before save it for callback
                    frame_sent = this.fifoSend[0];
                    //remove the frame from fifo
                    this.fifoSend.RemoveAt(0);
                }
                
                //for each frames
                foreach (String f in frames)
                {
                    //if frame seems to be correct
                    if ((f.Split('<').Length - 1) > 0 &&
                        (f.IndexOf('<') == 0) &&
                        (f.Split('>').Length - 1) == 0 &&
                        this.callbackReceiveFrame != null)
                    {
                        if((f + ">" == "<OK>") || (f + ">" == "<KO>"))
                        {
                            //send next frame
                            this.isSending = false;
                        }
                        //send to callback
                        HexapodResponse hexapodResponse = new HexapodResponse(frame_sent, f + ">", HexapodResponse.Status.NO_ERROR, HexapodResponse.Error.NO_ERROR);
                        foreach (CallbackReceiveFrame cb in this.callbackReceiveFrame)
                        {
                            cb(hexapodResponse);
                        }
                    }
                }
                //remove frame
                data = data.Remove(0,data.LastIndexOf('>') + 1);

                //disable timeout
                this.timerTimeoutFrame.Elapsed -= TimerTimeoutFrame_Elapsed;
                this.timerTimeoutFrame.Stop();
            }
        }
    }
}
