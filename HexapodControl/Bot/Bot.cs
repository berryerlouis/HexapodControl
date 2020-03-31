using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace HexapodControl
{
    class Bot : ClustersID, ICommReceive, ICommSent
    {
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
        
        //constructor singleton
        private Bot()
        {
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

        #region connexion
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
                    Comm.GetInstance().SetObserverReceive(this);
                    Comm.GetInstance().SetObserverSent(this);
                    Comm.GetInstance().Open();
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
                    Comm.GetInstance().RemoveObserverReceive(this);
                    Comm.GetInstance().RemoveObserverSent(this);
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
        /// get status of connexion
        /// </summary>
        /// <returns>true if connected</returns>
        public bool IsConnected()
        {
            return Comm.GetInstance().IsOpen();
        }
        #endregion

        #region Callbacks
        /// <summary>
        /// set the callback, hits when bot connection changed
        /// </summary>
        /// <param name="CallbackConnectionStatus">callback to set when data has been received</param>
        public void SetCallbackConnectionStatus(CallbackConnectionStatus callbackConnexionStatus)
        {
            this.callbackConnectionStatus = callbackConnexionStatus;
        }


        #endregion

        
        /// <summary>
        /// send data to comm class
        /// </summary>
        /// <param name="data">data to send</param>
        public void SendData(string data)
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

        // Receive update from subject
        void ICommReceive.DataReceived(HexapodResponse response)
        {
            if (response.GetStatus() == HexapodResponse.Status.NO_ERROR)
            {
                //notify all cluster
                foreach (Cluster cb in ClustersID.clusters)
                {
                    if (cb.getClusterId() == ((response.GetResponses().Count > 1) ? 
                        response.GetResponses()[0].clusterId : 
                        response.GetSentFrame() != null ?
                            response.GetSentFrame().clusterId :
                            response.GetResponses()[0].clusterId ) 
                        )
                    {
                        cb.NotifyIncommingResponse(response);
                        return;
                    }
                }
            }
        }
        // Receive update from subject
        void ICommSent.DataSent(Protocol.Frame data)
        {
            //notify all cluster
            foreach (Cluster cb in ClustersID.clusters)
            {
                if (cb.getClusterId() == data.clusterId)
                {
                    cb.NotifyOutcommingFrame(data);
                }
            }
        }
    }
}
