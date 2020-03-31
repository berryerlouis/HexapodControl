using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    class ClusterGeneral : Cluster
    {
        //COMM_CLUSTER_GENARAL	
        public static int CLUSTER_ID_GENARAL = (int)ClustersID.CLUSTERS_ID.CLUSTER_GENERAL;
        public static string CLUSTER_NAME_GENARAL = "GENERAL";
        //COMMAND GENERAL
        public static Command cmdReadVersion = new Command(CLUSTER_ID_GENARAL, 0x00, "VERSION");
        //version
        private static string version = "0.0";
        
        //constructor
        public ClusterGeneral()
        {
            this.setClusterId(CLUSTER_ID_GENARAL);
            this.setClusterName(CLUSTER_NAME_GENARAL);
            this.setCommand(cmdReadVersion);
        }

        #region commands
        //command Read
        public static string ReadVersion(Command.CbGenericReceive genericReceive, bool killCallback)
        {
            cmdReadVersion.addObserver( (response)=>
            {
                version = response.GetResponses()[0].parameters[0].ToString() + "." + response.GetResponses()[0].parameters[1].ToString();
                if (killCallback)
                {
                    cmdReadVersion.removeObserver();
                }
            });
            return cmdReadVersion.sendCommand();
        }
        #endregion
    }
}
