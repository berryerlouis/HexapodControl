using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    class ClusterServo : Cluster
    {

        //COMM_CLUSTER_SERVOS	
        public static int CLUSTER_ID_SERVOS = (int)ClustersID.CLUSTERS_ID.CLUSTER_SERVOS;
        public static string CLUSTER_NAME_SERVOS = "SERVOS";
        //COMMAND SERVOS
        private static Command cmdStatus = new Command(CLUSTER_ID_SERVOS,0x00, "STATUS");
        private static Command cmdEnable= new Command(CLUSTER_ID_SERVOS, 0x01, "ENABLE");
        private static Command cmdRead = new Command(CLUSTER_ID_SERVOS, 0x02, "READ");
        private static Command cmdWrite = new Command(CLUSTER_ID_SERVOS, 0x03, "WRITE");
        private static Command cmdMinRead = new Command(CLUSTER_ID_SERVOS, 0x04, "MIN READ");
        private static Command cmdMinWrite = new Command(CLUSTER_ID_SERVOS,0x05, "MIN WRITE");
        private static Command cmdMaxRead = new Command(CLUSTER_ID_SERVOS, 0x06, "MAX READ");
        private static Command cmdMaxWrite = new Command(CLUSTER_ID_SERVOS, 0x07, "MAX WRITE");
        private static Command cmdReadAll = new Command(CLUSTER_ID_SERVOS, 0x08, "READ ALL");
        

        //constructor
        public ClusterServo()
        {
            this.setClusterId(CLUSTER_ID_SERVOS);
            this.setClusterName(CLUSTER_NAME_SERVOS);

            this.setCommand(cmdStatus);
            this.setCommand(cmdEnable);
            this.setCommand(cmdRead);
            this.setCommand(cmdWrite);
            this.setCommand(cmdMinRead);
            this.setCommand(cmdMinWrite);
            this.setCommand(cmdMaxRead);
            this.setCommand(cmdMaxWrite);
            this.setCommand(cmdReadAll);
        }

        #region commands
        //command Read All
        public static string ServoStatus(int servoId, Command.CbGenericReceive genericReceive, bool killCallback)
        {
            if (servoId < 18)
            {
                cmdStatus.addObserver((frame) =>
                {
                    int id = frame.GetResponses()[0].parameters[0] * 16 + frame.GetResponses()[0].parameters[1];
                    Servos.getInstance().getServo(id).SetEnable((frame.GetResponses()[0].parameters[2] == 1 ? true : false));
                    genericReceive(new List<Object>() { id, Servos.getInstance().getServo(id).GetEnable() });
                    if (killCallback)
                    {
                        cmdStatus.removeObserver();
                    }
                });
                return cmdStatus.sendCommand(2, new string[] { servoId.ToString("X2") });
            }
            return "";

        }      
        public static string EnableServo(int servoId, bool enable, Command.CbGenericReceive genericReceive, bool killCallback)
        {
            if (servoId < 18)
            {
                cmdEnable.addObserver((frame) =>
                {
                    genericReceive(new List<Object>() {  });
                    if (killCallback)
                    {
                        cmdEnable.removeObserver();
                    }
                });
                return cmdEnable.sendCommand(3, new string[] { servoId.ToString("X2"), enable ? "1" : "0" });
            }
            return "";
        }
        public static string ReadServo(int servoId, Command.CbGenericReceive genericReceive, bool killCallback)
        {
            if (servoId < 18)
            {
                cmdRead.addObserver((frame) =>
                {
                    int id = frame.GetResponses()[0].parameters[0] * 16 + frame.GetResponses()[0].parameters[1];
                    Servos.getInstance().getServo(id).SetPos(frame.GetResponses()[0].parameters[2] * 16 + frame.GetResponses()[0].parameters[3] - 90);
                    genericReceive(new List<Object>() { id, Servos.getInstance().getServo(id).GetPos() });
                    if (killCallback)
                    {
                        cmdRead.removeObserver();
                    }
                });
                return cmdRead.sendCommand(2, new string[] { servoId.ToString("X2") });
            }
            return "";
        }
        public static string ReadMinServo(int servoId, Command.CbGenericReceive genericReceive, bool killCallback)
        {
            if (servoId < 18)
            {
                cmdMinRead.addObserver((frame) =>
                {
                    int id = frame.GetResponses()[0].parameters[0] * 16 + frame.GetResponses()[0].parameters[1];
                    Servos.getInstance().getServo(id).SetMin(frame.GetResponses()[0].parameters[2] * 16 + frame.GetResponses()[0].parameters[3] - 90);
                    genericReceive(new List<Object>() { id, Servos.getInstance().getServo(id).GetMin() });
                    if (killCallback)
                    {
                        cmdMinRead.removeObserver();
                    }
                });
                return cmdMinRead.sendCommand(2, new string[] { servoId.ToString("X2") });
            }
            return "";
        }
        public static string ReadMaxServo(int servoId, Command.CbGenericReceive genericReceive, bool killCallback)
        {
            if (servoId < 18)
            {
                cmdMaxRead.addObserver((frame) =>
                {
                    int id = frame.GetResponses()[0].parameters[0] * 16 + frame.GetResponses()[0].parameters[1];
                    Servos.getInstance().getServo(id).SetMax(frame.GetResponses()[0].parameters[2] * 16 + frame.GetResponses()[0].parameters[3] - 90);
                    genericReceive(new List<Object>() { id, Servos.getInstance().getServo(id).GetMax() });
                    if (killCallback)
                    {
                        cmdMaxRead.removeObserver();
                    }
                });
                return cmdMaxRead.sendCommand(2, new string[] { servoId.ToString("X2") });
            }
            return "";
        }
        public static string WriteServo(int servoId, int position, int time, Command.CbGenericReceive genericReceive, bool killCallback)
        {
            if (servoId < 18)
            {
                cmdWrite.addObserver((frame) =>
                {
                    genericReceive(new List<Object>() {  });
                    if (killCallback)
                    {
                        cmdWrite.removeObserver();
                    }
                });
                return cmdWrite.sendCommand(8, new string[] { servoId.ToString("X2"), position.ToString("X2"), time.ToString("X4") });
            }
            return "";
        }
        public static string ReadAllServos(Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdReadAll.addObserver((frame) =>
            {
                List<Object> obj = new List<Object>();
                for (int i = 0; i < frame.GetResponses()[0].size; i += 2)
                {
                    Servos.getInstance().getServo(i / 2).SetPos((frame.GetResponses()[0].parameters[i + 0] * 16 + frame.GetResponses()[0].parameters[i + 1]) - 90);
                    obj.Add(Servos.getInstance().getServo(i/2).GetPos());
                }
                genericReceive(obj);
                if (killCallback)
                {
                    cmdReadAll.removeObserver();
                }
            });
            return cmdReadAll.sendCommand();
        }
        #endregion
    }
}