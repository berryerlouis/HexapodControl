using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    public class Protocol
    {
        public static string COMM_START_MESSAGE = "<";
        public static string COMM_STOP_MESSAGE = ">";

        public static int COMM_HEADER_MESSAGE = 0;  //header

        public class Frame
        {
            public int protocolId = -1;
            public int clusterId = -1;
            public string clusterName = "";
            public int cmdId = -1;
            public string cmdName = "";
            public int size = -1;
            public int[] parameters = new int[] { };
            public string raw = "";
            public int sequenceId = 0;
        }
        //Command

        public static string CreateFrame(int cluster, int command)
        {
            string message =
                COMM_START_MESSAGE +
                COMM_HEADER_MESSAGE +
                cluster.ToString("X2") +
                command.ToString("X2") +
                0.ToString("X2") +
                COMM_STOP_MESSAGE;
            return message;
        }
        public static string CreateFrame(int cluster, int command, int size, string[] payload)
        {
            string data = "";
            for (int i = 0; i < payload.Length; i++)
            {
                data += payload[i];
            }
            string message =
                COMM_START_MESSAGE +
                COMM_HEADER_MESSAGE +
                cluster.ToString("X2") +
                command.ToString("X2") +
                size.ToString("X2") +
                data +
                COMM_STOP_MESSAGE;
            return message;
        }

        public static Frame Parse(string data)
        {
            Frame frame = new Frame();
            frame.raw = data;
            try
            {
                frame.protocolId = int.Parse(data.Substring(1, 1), System.Globalization.NumberStyles.HexNumber);
                frame.clusterId = int.Parse(data.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                frame.clusterName = ClustersID.getClusterById(frame.clusterId).getClusterName();
                frame.cmdId = int.Parse(data.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                frame.cmdName = ClustersID.getClusterById(frame.clusterId).getCommandName(frame.cmdId);
                frame.size = int.Parse(data.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                frame.parameters = new int[frame.size];
                for (int i = 0; i < frame.size; i++)
                {
                    frame.parameters[i] = int.Parse(data.Substring(8 + i, 1), System.Globalization.NumberStyles.HexNumber);
                }
            }
            catch
            {
                frame.protocolId = -1;
                frame.clusterId = -1;
                frame.clusterName = "";
                frame.cmdId = -1;
                frame.cmdName = "";
                frame.size = -1;
                frame.parameters = new int[]{ };
            }

            return frame;
        }
    }
}
