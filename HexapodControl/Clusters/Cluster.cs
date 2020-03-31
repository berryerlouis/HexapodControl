using System.Collections.Generic;

namespace HexapodControl
{
    class Cluster : Commands
    {
        //error command
        public static int CLUSTER_UNDEFINED = 0xFF;

        private int clusterID = CLUSTER_UNDEFINED;
        private string clusterName = "";

        public void setClusterId(int clusterID)
        {
            this.clusterID = clusterID;
        }

        public void setClusterName(string clusterName)
        {
            this.clusterName = clusterName;
        }

        public int getClusterId()
        {
            return this.clusterID;
        }

        public string getClusterName()
        {
            return clusterName;
        }

        public void NotifyIncommingResponse(HexapodResponse frame)
        {
            this.ExcecuteCommand(frame);
        }

        public void NotifyOutcommingFrame(Protocol.Frame f)
        {

        }
    }
}
