using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    class Command : ICommandReceive
    {
        //error command
        public static int COMMAND_UNDEFINED = 0xFF;

        private int cmdId = COMMAND_UNDEFINED;
        private string cmdName = "";
        private int clusterId = 0;

        public delegate void CbGenericReceive(List<Object> obj);
        public delegate void CbCommandReceive(HexapodResponse response);
        private List<CbCommandReceive> observers = new List<CbCommandReceive>();
        public Command(int clusterId, int cmdId, string cmdName) 
        {
            this.cmdId = cmdId;
            this.cmdName = cmdName;
            this.clusterId = clusterId;
        }
        
        public void receivedResponse(HexapodResponse response)
        {
            for(int i  = 0; i < this.observers.Count; i++)
            {
                observers[i](response);
            }
        }
        public void removeObserver()
        {
            this.observers.RemoveAt(this.observers.Count - 1);
        }
        public void addObserver(CbCommandReceive observer)
        {
            this.observers.Add(observer);
        }

        #region commands
        //command Read
        public string sendCommand()
        {
            return Protocol.CreateFrame(
                clusterId,
                this.getCmdId());
        }
        public string sendCommand(int size, string[] payload)
        {
            return Protocol.CreateFrame(
                clusterId,
                this.getCmdId(),size,payload);
        }

        public int getCmdId()
        {
            return this.cmdId;
        }

        public string getCmdName()
        {
            return this.cmdName;
        }
        

        #endregion
    }
}
