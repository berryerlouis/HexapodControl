using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    class ClusterLeg : Cluster
    {
        //COMM_CLUSTER_IMU	
        public static int CLUSTER_ID_LEG = (int)ClustersID.CLUSTERS_ID.CLUSTER_LEG;
        public static string CLUSTER_NAME_LEG = "LEG";
        //COMMAND IMU
        private static Command cmdSetLegXYZ = new Command(CLUSTER_ID_LEG, 0x00, "SET LEG X Y Z");
        
        public ClusterLeg()
        {
            this.setClusterId(CLUSTER_ID_LEG);
            this.setClusterName(CLUSTER_NAME_LEG);
            
            this.setCommand(cmdSetLegXYZ);
            
        }


        #region commands
       
        //command set threshold
        public static string setLegXYZ(int legId,int x, int y, int z, int delay, Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdSetLegXYZ.addObserver((frame) =>
            {
                genericReceive(new List<Object>() { });
                if (killCallback)
                {
                    cmdSetLegXYZ.removeObserver();
                }
            });
            return cmdSetLegXYZ.sendCommand(11, new string[] {
                legId.ToString("X1"),
                x.ToString("X2").Substring(x.ToString("X2").Length - 2),
                y.ToString("X2").Substring(y.ToString("X2").Length - 2),
                z.ToString("X2").Substring(z.ToString("X2").Length - 2),
                delay.ToString("X4") });
        }
        
        #endregion
    }
}
