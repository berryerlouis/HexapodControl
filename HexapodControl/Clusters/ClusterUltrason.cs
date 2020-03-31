using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    class ClusterUltrason : Cluster
    {
        //COMM_CLUSTER_GENARAL	
        public static int CLUSTER_ID_ULTRASON = (int)ClustersID.CLUSTERS_ID.CLUSTER_ULTRASON;
        public static string CLUSTER_NAME_ULTRASON = "ULTRASON";
        //COMMAND GENERAL
        private static Command cmdGetThreshold = new Command(CLUSTER_ID_ULTRASON, 0x00, "GET THRESHOLD");
        private static Command cmdSetThreshold = new Command(CLUSTER_ID_ULTRASON, 0x01, "SET THRESHOLD");
        public static Command cmdReadDistance = new Command(CLUSTER_ID_ULTRASON, 0x02, "READ DISTANCE");
        //version
        private static int threshold = 0;
        private static int distance_left = 0;
        private static int distance_right = 0;

        //constructor
        public ClusterUltrason()
        {
            this.setClusterId(CLUSTER_ID_ULTRASON);
            this.setClusterName(CLUSTER_NAME_ULTRASON);
            this.setCommand(cmdGetThreshold);
            this.setCommand(cmdSetThreshold);
            this.setCommand(cmdReadDistance);
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
        //command Read
        public static string ReadDistance(Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdReadDistance.addObserver( (response)=>
            {
                distance_left = (Int16)(response.GetResponses()[0].parameters[2] * 16 + response.GetResponses()[0].parameters[3]);
                distance_right = (Int16)(response.GetResponses()[0].parameters[0] * 16 + response.GetResponses()[0].parameters[1]);
                genericReceive(new List<Object>() { distance_left, distance_right });
                if (killCallback)
                {
                    cmdReadDistance.removeObserver();
                }
            });
            return cmdReadDistance.sendCommand();
        }
        #endregion
    }
}
