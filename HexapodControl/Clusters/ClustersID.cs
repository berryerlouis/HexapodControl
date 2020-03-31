using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    class ClustersID
    {
        //id of clusters
        public enum CLUSTERS_ID
        {
            CLUSTER_GENERAL,
            CLUSTER_BEHAVIOR,
            CLUSTER_IMU,
            CLUSTER_ULTRASON,
            CLUSTER_SERVOS,
            CLUSTER_LEG,
            CLUSTER_DISPLAY
        };

        public static Cluster getClusterById(int cluterId)
        {
            foreach(Cluster c in clusters)
            {
                if(c.getClusterId() == cluterId)
                {
                    return c;
                }
            }
            return null;
        }
        public static Cluster getClusterByName(string cluterName)
        {
            foreach (Cluster c in clusters)
            {
                if (c.getClusterName() == cluterName)
                {
                    return c;
                }
            }
            return null;
        }

        //list of cluster availables
       public static List<Cluster> clusters = new List<Cluster>()
        {
            new ClusterGeneral(),
            new ClusterBehavior(),
            new ClusterImu(),
            new ClusterServo(),
            new ClusterLeg(),
            new ClusterUltrason()
        };
    }
}
