using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    class ClusterBehavior : Cluster
    {
        //COMM_CLUSTER_IMU	
        public static int CLUSTER_ID_BEHAVIOR = (int)ClustersID.CLUSTERS_ID.CLUSTER_BEHAVIOR;
        public static string CLUSTER_NAME_BEHAVIOR = "BEHAVIOR";
        //COMMAND IMU
        private static Command cmdGetBehavior = new Command(CLUSTER_ID_BEHAVIOR, 0x00, "GET BEHAVIOR");
        private static Command cmdSetBehavior = new Command(CLUSTER_ID_BEHAVIOR, 0x01, "SET BEHAVIOR");
        private static Command cmdGetElevation = new Command(CLUSTER_ID_BEHAVIOR, 0x02, "GET ELEVATION");
        private static Command cmdSetElevation = new Command(CLUSTER_ID_BEHAVIOR, 0x03, "SET ELEVATION"); 
        private static Command cmdSetPosXY = new Command(CLUSTER_ID_BEHAVIOR, 0x04, "SET POSITION X Y");

        public static int behavior = 0;
        public static int elevation = 0;

        public ClusterBehavior()
        {
            this.setClusterId(CLUSTER_ID_BEHAVIOR);
            this.setClusterName(CLUSTER_NAME_BEHAVIOR);
            
            this.setCommand(cmdGetBehavior);
            this.setCommand(cmdSetBehavior);
            this.setCommand(cmdGetElevation);
            this.setCommand(cmdSetElevation); 
            this.setCommand(cmdSetPosXY);
            
        }


        #region commands
        //command set threshold
        public static string setBehavior(int behav, int delay, Command.CbGenericReceive genericReceive, bool killCallback)
        {
            behavior = behav;
            cmdSetBehavior.addObserver((frame) =>
            {
                genericReceive(new List<Object>() { });
                if (killCallback)
                {
                    cmdSetBehavior.removeObserver();
                }
            });
            return cmdSetBehavior.sendCommand(5, new string[] {
                behavior.ToString("X1"),
                delay.ToString("X4") });
        }
        //command get threshold
        public static string GetBehavior(Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdGetBehavior.addObserver((frame) =>
            {
                behavior = frame.GetResponses()[0].parameters[0];
                genericReceive(new List<Object>() { behavior });
                if (killCallback)
                {
                    cmdGetBehavior.removeObserver();
                }
            });
            return cmdGetBehavior.sendCommand();
        }

        //command set threshold
        public static string setElevation(int elevation, int delay, Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdSetElevation.addObserver((frame) =>
            {
                genericReceive(new List<Object>() { });
                if (killCallback)
                {
                    cmdSetElevation.removeObserver();
                }
            });
            return cmdSetElevation.sendCommand(6, new string[] { elevation.ToString("X2"), delay.ToString("X4") });
        }
        //command get threshold
        public static string GetElevation(Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdGetElevation.addObserver((frame) =>
            {
                elevation = (Int16)(frame.GetResponses()[0].parameters[0] * 16 + frame.GetResponses()[0].parameters[1]);
                genericReceive(new List<Object>() { elevation });
                if (killCallback)
                {
                    cmdGetElevation.removeObserver();
                }
            });
            return cmdGetElevation.sendCommand();
        }
        
        //command set threshold
        public static string setPosXY( int x, int y, Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdSetPosXY.addObserver((frame) =>
            {
                genericReceive(new List<Object>() { });
                if (killCallback)
                {
                    cmdSetPosXY.removeObserver();
                }
            });
            return cmdSetPosXY.sendCommand(4, new string[] {
                x.ToString("X2").Substring(x.ToString("X2").Length - 2),
                y.ToString("X2").Substring(y.ToString("X2").Length - 2) });
        }
        
        #endregion
    }
}
