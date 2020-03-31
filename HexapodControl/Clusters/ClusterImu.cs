using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    class ClusterImu : Cluster
    {
        //COMM_CLUSTER_IMU	
        public static int CLUSTER_ID_IMU = (int)ClustersID.CLUSTERS_ID.CLUSTER_IMU;
        public static string CLUSTER_NAME_IMU = "IMU";
        //COMMAND IMU
        private static Command cmdGetThreshold = new Command(CLUSTER_ID_IMU, 0x00, "GET THRESHOLD");
        private static Command cmdSetThreshold = new Command(CLUSTER_ID_IMU, 0x01, "SET THRESHOLD");
        private static Command cmdGetRPY = new Command(CLUSTER_ID_IMU, 0x02, "GET ROLL PITCH YAW");
        private static Command cmdGetRoll = new Command(CLUSTER_ID_IMU, 0x03, "GET ROLL");
        private static Command cmdGetPitch = new Command(CLUSTER_ID_IMU, 0x04, "GET PITCH");
        private static Command cmdGetYaw = new Command(CLUSTER_ID_IMU, 0x05, "GET YAW");

        public static int threshold = 0;
        public static int axisX = 0;
        public static int axisY = 0;
        public static int axisZ = 0;
        public static int roll = 0;
        public static int pitch = 0;
        public static int yaw = 0;

        public ClusterImu()
        {
            this.setClusterId(CLUSTER_ID_IMU);
            this.setClusterName(CLUSTER_NAME_IMU);
            
            this.setCommand(cmdGetThreshold);
            this.setCommand(cmdSetThreshold);
            this.setCommand(cmdGetRPY);
            this.setCommand(cmdGetRoll);
            this.setCommand(cmdGetPitch);
            this.setCommand(cmdGetYaw);
        }


        #region commands
        //command set threshold
        public static string setThreshold(Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdSetThreshold.addObserver((frame) =>
            {
                genericReceive(new List<Object>() { });
                if (killCallback)
                {
                    cmdSetThreshold.removeObserver();
                }
            });
            return cmdSetThreshold.sendCommand();
        }
        //command get threshold
        public static string GetThreshold(Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdGetThreshold.addObserver((frame) =>
            {
                threshold = (Int16)(frame.GetResponses()[0].parameters[0] * 16 + frame.GetResponses()[0].parameters[1]);
                genericReceive(new List<Object>() { threshold });
                if (killCallback)
                {
                    cmdGetThreshold.removeObserver();
                }
            });
            return cmdGetThreshold.sendCommand();
        }
        //command get roulis
        public static string GetRoll(Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdGetRoll.addObserver((frame) =>
            {
                roll = (Int16)(frame.GetResponses()[0].parameters[0] * 4096 +
                frame.GetResponses()[0].parameters[1] * 256 +
                frame.GetResponses()[0].parameters[2] * 16 +
                frame.GetResponses()[0].parameters[3]);
                genericReceive(new List<Object>() { roll });
                if (killCallback)
                {
                    cmdGetRoll.removeObserver();
                }
            });
            return cmdGetRoll.sendCommand();
        }
        //command get tangage
        public static string GetPitch(Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdGetPitch.addObserver((frame) =>
            {
                pitch = (Int16)(frame.GetResponses()[0].parameters[0] * 4096 +
                frame.GetResponses()[0].parameters[1] * 256 +
                frame.GetResponses()[0].parameters[2] * 16 +
                frame.GetResponses()[0].parameters[3]);
                genericReceive(new List<Object>() { pitch });
                if (killCallback)
                {
                    cmdGetPitch.removeObserver();
                }
            });
            return cmdGetPitch.sendCommand();
        }
        //command get yaw
        public static string GetYaw(Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdGetYaw.addObserver((frame) =>
            {
                yaw = (Int16)(frame.GetResponses()[0].parameters[0] * 4096 +
                frame.GetResponses()[0].parameters[1] * 256 +
                frame.GetResponses()[0].parameters[2] * 16 +
                frame.GetResponses()[0].parameters[3]);
                genericReceive(new List<Object>() { yaw });
                if (killCallback)
                {
                    cmdGetYaw.removeObserver();
                }
            });
            return cmdGetYaw.sendCommand();
        }
        //command get yaw
        public static string GetRollPitchYaw(Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdGetRPY.addObserver((frame) =>
            {
                roll = (Int16)(frame.GetResponses()[0].parameters[0] * 4096 +
                frame.GetResponses()[0].parameters[1] * 256 +
                frame.GetResponses()[0].parameters[2] * 16 +
                frame.GetResponses()[0].parameters[3]);
                pitch = (Int16)(frame.GetResponses()[0].parameters[4] * 4096 +
                frame.GetResponses()[0].parameters[5] * 256 +
                frame.GetResponses()[0].parameters[6] * 16 +
                frame.GetResponses()[0].parameters[7]);
                yaw = (Int16)(frame.GetResponses()[0].parameters[8] * 4096 +
                frame.GetResponses()[0].parameters[9] * 256 +
                frame.GetResponses()[0].parameters[10] * 16 +
                frame.GetResponses()[0].parameters[11]);
                genericReceive(new List<Object>() { roll, pitch, yaw });
                if (killCallback)
                {
                    cmdGetRPY.removeObserver();
                }
            });
            return cmdGetRPY.sendCommand();
        }
        #endregion
    }
}
