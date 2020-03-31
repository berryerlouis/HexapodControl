using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Management;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace HexapodControl
{
    public class Comm : IComm
    {
        //singleton
        private static Comm comm = null;
        //timer for timeout
        System.Timers.Timer timerTimeoutFrame = new System.Timers.Timer();
        //serial port
        SerialPort serialPortHexapod = new SerialPort();
        
        //list of messages to send
        private volatile List<string> fifoSend = new List<string>();
        //state of queue
        private volatile bool isSending = false;


        private List<ICommReceive> observersReceived = new List<ICommReceive>();
        private List<ICommSent> observersSent = new List<ICommSent>();
        private int sequenceId = 0;
        
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
            if (comm == null)
            {
                comm = new Comm();
            }
            return comm;
        }
        /// <summary>
        /// get portnames of connected port
        /// </summary>
        /// <returns>Array of string containing availables ports</returns>
        public string[] GetPortNames()
        {
            bool bluetooth = false;
            string bluetooth_port = "";
            ManagementClass processClass = new ManagementClass("Win32_PnPEntity");
            ManagementObjectCollection Ports = processClass.GetInstances();
            foreach (ManagementObject property in Ports)
            {
                var name = property.GetPropertyValue("Name");
                var description = property.GetPropertyValue("Description");
                if (name != null && description != null && name.ToString().Contains("COM") && description.ToString().Contains("Lien série sur Bluetooth standard"))
                {
                    //take the second COM
                    if(bluetooth)
                    {
                        bluetooth_port = property.GetPropertyValue("Caption").ToString().Replace("Lien série sur Bluetooth standard (","").Replace(")", "");
                        break;
                    }
                    bluetooth = true;
                    //Thats all information i got from port.
                    //Do whatever you want with this information
                }
            }

            return bluetooth_port != "" ? new string[] { bluetooth_port } : SerialPort.GetPortNames();
        }
        
        /// <summary>
        /// set the port to communicate
        /// </summary>
        /// <param name="data"></param>
        public void SetPortName(string data)
        {
            this.serialPortHexapod.PortName = data;
        }
        /// <summary>
        /// open the port
        /// </summary>
        public void Open()
        {
            this.serialPortHexapod.Open();
            Thread th = new Thread(threadFifoDataSent);
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

        #region Notify
        public void NotifyReceivedData(HexapodResponse response)
        {
            //try
            {
                foreach (var observer in observersReceived)
                {
                    observer.DataReceived(response);
                }
            }
            /*catch
            {
            }*/
        }
        public void NotifySentData(Protocol.Frame data)
        {
            foreach (var observer in observersSent)
            {
                observer.DataSent(data);
            }
        }
        #endregion

        #region Observers
        public void SetObserverReceive(ICommReceive observer)
        {
            this.observersReceived.Add(observer);
        }
        public void SetObserverSent(ICommSent observer)
        {
            this.observersSent.Add(observer);
        }
        public void RemoveObserverReceive(ICommReceive observer)
        {
            this.observersReceived.Remove(observer);
        }
        public void RemoveObserverSent(ICommSent observer)
        {
            this.observersSent.Remove(observer);
        }
        #endregion

        /// <summary>
        /// send data to port
        /// </summary>
        /// <param name="data">data to sent</param>
        public void SendData(string data)
        {
            this.fifoSend.Add(data);
        }
        /// <summary>
        /// send data to port
        /// </summary>
        /// <param name="data">string array data to sent</param>
        public void SendData(string[] data)
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

        private void threadFifoDataSent()
        {
            while (this.serialPortHexapod.IsOpen)
            {
                if (((this.fifoSend.Count != 0)) && (!this.isSending))
                {
                    this.isSending = true;
                    string data = this.fifoSend[0];
                    //send to port com
                    this.serialPortHexapod.Write(data);
                    //enable timeout
                    this.timerTimeoutFrame.Elapsed += TimerTimeoutFrame_Elapsed;
                    this.timerTimeoutFrame.Start();
                    Protocol.Frame parsedFrameTx = Protocol.Parse(data);
                    parsedFrameTx.sequenceId = this.sequenceId;
                    this.NotifySentData(parsedFrameTx);
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
            HexapodResponse hexapodResponse = new HexapodResponse(Protocol.Parse(this.fifoSend[0]), null, HexapodResponse.Status.ERROR, HexapodResponse.Error.TIMEOUT);
            this.NotifyReceivedData(hexapodResponse);

            this.timerTimeoutFrame.Elapsed -= TimerTimeoutFrame_Elapsed;
            //try to send same frame
            this.isSending = false;
        }

        List<Protocol.Frame> responsesfifo = new List<Protocol.Frame>();
        string data = null;
        private void serialPortHexapod_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //get input string
            data += this.serialPortHexapod.ReadExisting();

            //wait for a full frame
            if (data.Contains('<') && data.Contains('>'))
            {
                //get frames from string
                string[] frames = data.Substring(data.IndexOf('<')).Split('>');

                //for each frames
                foreach (string f in frames)
                {
                    //if frame seems to be correct
                    if ((f.Split('<').Length - 1) > 0 &&
                        (f.IndexOf('<') == 0) &&
                        (f.Split('>').Length - 1) == 0 )
                    {
                        string frame_sent = "";
                        //remove frame sent from fifo
                        if (this.fifoSend.Count > 0)
                        {
                            //before save it for callback
                            frame_sent = this.fifoSend[0];
                        }

                        Protocol.Frame parsedFrameTx = Protocol.Parse(frame_sent);
                        parsedFrameTx.sequenceId = this.sequenceId;

                        Protocol.Frame parsedFrameRx = Protocol.Parse(f + ">");
                        //if sequence complete
                        if ((f + ">" == "<OK>") || (f + ">" == "<KO>"))
                        {
                            //remove the frame from fifo
                            this.fifoSend.RemoveAt(0);
                            //add last ok
                            parsedFrameRx.sequenceId = this.sequenceId;
                            this.responsesfifo.Add(parsedFrameRx);
                            //send to observer with sequence 
                            HexapodResponse hexapodResponse = new HexapodResponse(
                                parsedFrameTx,
                                responsesfifo,
                                HexapodResponse.Status.NO_ERROR,
                                HexapodResponse.Error.NO_ERROR);
                            this.NotifyReceivedData(hexapodResponse);
                            //send next frame
                            this.isSending = false;
                            this.responsesfifo.Clear();
                            this.sequenceId++;
                        }
                        else
                        {
                            //check if response is comming from sequence
                            if ((parsedFrameRx.clusterId == parsedFrameTx.clusterId) && (parsedFrameRx.cmdId == parsedFrameTx.cmdId))
                            {
                                parsedFrameRx.sequenceId = this.sequenceId;
                                this.responsesfifo.Add(parsedFrameRx);
                            }
                            else
                            {
                                //send to observer without sequence
                                HexapodResponse hexapodResponse = new HexapodResponse(
                                    null,
                                    new List<Protocol.Frame> { parsedFrameRx },
                                    HexapodResponse.Status.NO_ERROR,
                                    HexapodResponse.Error.NO_ERROR);
                                this.NotifyReceivedData(hexapodResponse);
                            }
                        }
                    }
                }
                //remove frame
                data = data.Remove(0, data.LastIndexOf('>') + 1);

                //disable timeout
                this.timerTimeoutFrame.Elapsed -= TimerTimeoutFrame_Elapsed;
                this.timerTimeoutFrame.Stop();
            }
        }
    }

}
