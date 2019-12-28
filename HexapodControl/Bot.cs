using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    public class Bot
    {
        private static int NB_MOTORS = 18;
        public class Motor
        {
            public int id { get; set; }
            public int angle { get; set; }
            public int delay { get; set; }

            public Motor()
            { }
            public Motor(int id, int angle, int delay)
            {
                this.id = id;
                this.angle = angle;
                this.delay = delay;
            }
        }
        Motor[] motors = new Motor[NB_MOTORS];
        string version = "0.0";

        public string GetVersion()
        {
            return version;
        }

        private static Bot bot = new Bot();


        public enum EConnectionStatus
        {
            CONNECTED,
            DISCONNECTED,
            CONNECTION_ERROR
        };

        //declaration of the callback when bot is connected
        public delegate void CallbackConnectionStatus(EConnectionStatus connected);
        //callback variable
        private CallbackConnectionStatus callbackConnectionStatus = null;

        //declaration of the callback when version is updated
        public delegate void CallbackUpdateVersion(string version);
        //callback variable
        private CallbackUpdateVersion callbackUpdateVersion = null;


        //constructor singleton
        private Bot()
        {
            for(int i = 0; i < NB_MOTORS; i++)
            {
                motors[i] = new Motor(i,0,1000);
            }
        }

        //singleton
        public static Bot GetInstance()
        {
            if (bot == null)
            {
                bot = new Bot();
            }
            return bot;
        }

        /// <summary>
        /// try to connect the bot
        /// </summary>
        /// <returns>true if connected</returns>
        public bool Connect()
        {
            if (!Comm.GetInstance().IsOpen())
            {
                try
                {
                    Comm.GetInstance().SetPortName(Comm.GetInstance().GetPortNames()[0]);
                    //Comm.GetInstance().SetCallBackReceive(data => Invoke((Comm.CallbackReceiveFrame)DataFromHexapod, new object[] { data }));
                    //Comm.GetInstance().SetCallBackSendingFrame(data => Invoke((Comm.CallbackSendingFrame)DataToHexapod, new object[] { data }));
                    Comm.GetInstance().SetCallBackReceive(DataFromHexapod);
                    Comm.GetInstance().SetCallBackSentFrame(DataToHexapod);
                    Comm.GetInstance().Open();
                    //read version
                    SendDataToHexapod(Protocol.GetInstance().ReadVersion());
                    //read all servos
                    SendDataToHexapod(Protocol.GetInstance().ReadAllServos());
                    this.callbackConnectionStatus(EConnectionStatus.CONNECTED);
                    return true;
                }
                catch
                {
                    Comm.GetInstance().Close();
                    this.callbackConnectionStatus(EConnectionStatus.CONNECTION_ERROR);
                    return false;
                }
            }
            else
            {
                Comm.GetInstance().Close();
                this.callbackConnectionStatus(EConnectionStatus.DISCONNECTED);
                return false;
            }
        }

        /// <summary>
        /// disconnect bot
        /// </summary>
        /// <returns>true if well disconnected</returns>
        public bool Disconnect()
        {
            if (Comm.GetInstance().IsOpen())
            {
                try
                {
                    Comm.GetInstance().RemoveCallBackReceive(DataFromHexapod);
                    Comm.GetInstance().RemoveCallBackSentFrame(DataToHexapod);
                    Comm.GetInstance().Close();
                    this.callbackConnectionStatus(EConnectionStatus.DISCONNECTED);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// set the callback, hits when bot connection changed
        /// </summary>
        /// <param name="CallbackConnectionStatus">callback to set when data has been received</param>
        public void SetCallbackConnectionStatus(CallbackConnectionStatus callbackConnexionStatus)
        {
            this.callbackConnectionStatus = callbackConnexionStatus;
        }

        /// <summary>
        /// set the callback, hits when version is updated
        /// </summary>
        /// <param name="callbackUpdateVersion">callback to set when data has been received</param>
        public void SetCallbackUpdateVersion(CallbackUpdateVersion callbackUpdateVersion)
        {
            this.callbackUpdateVersion = callbackUpdateVersion;
        }

        /// <summary>
        /// get status of connexion
        /// </summary>
        /// <returns>true if connected</returns>
        public bool IsConnected()
        {
            return Comm.GetInstance().IsOpen();
        }




        public bool SetMotorPosition(int id, int angle)
        {
            motors[id].angle = angle;
            return false;
        }

        public int GetMotorPosition(int id)
        {
            return motors[id].angle;
        }

        public bool SetMotorDelay(int id, int delay)
        {
            motors[id].delay = delay;
            return false;
        }

        public int GetMotorDelay(int id)
        {
            return motors[id].delay;
        }










        /// <summary>
        /// send data to serial port 
        /// </summary>
        /// <param name="data">data to send</param>
        private void SendDataToHexapod(string data)
        {
            //only if open
            if (Comm.GetInstance().IsOpen())
            {
                Comm.GetInstance().SendData(data);
            }
            else
            {
                Disconnect();
            }
        }



        private void DataToHexapod(string data)
        {
        }

        private void DataFromHexapod(Comm.HexapodResponse data)
        {
            if (data.GetStatus() == Comm.HexapodResponse.Status.NO_ERROR)
            {
                Protocol.Frame frame = Protocol.GetInstance().Parse(data.GetResponse());
                if (frame.cmdId == Protocol.CMD_ID_VERSION)
                {
                    this.version = frame.parameters[0] + "." + frame.parameters[1];
                    if(this.callbackUpdateVersion != null)
                    {
                        this.callbackUpdateVersion(this.version);
                    }
                }
                else if (frame.cmdId == Protocol.CMD_ID_READ_SERVOS)
                {
                    /*this.version = frame.parameters[0] + "." + frame.parameters[1];
                    if (this.callbackUpdateVersion != null)
                    {
                        this.callbackUpdateVersion(this.version);
                    }*/
                }
            }
        }
    }
}
