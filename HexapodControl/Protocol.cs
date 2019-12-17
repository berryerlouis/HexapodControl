using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodControl
{
    class Protocol
    {
        public static int CMD_ID_VERSION = 0;
        public static int CMD_ID_READ_SERVOS = 3;
        public class Frame
        {
            public int protocolId = -1;
            public int cmdId = -1;
            public int []parameters = new int[]{ };
            public string description = "";
        }

        private static Protocol protocol = new Protocol();
        //singleton
        public static Protocol GetInstance()
        {
            if (protocol == null)
            {
                protocol = new Protocol();
            }
            return protocol;
        }

        //Command
        public string ReadVersion()
        {
            return "<00>";
        }

        public string ReadAllServos()
        {
            return "<0318>";
        }
        public string SetEnableServo(int servoId, bool enable)
        {
            return "<01" + servoId.ToString("00") + (enable ? "1" : "0") + ">";
        }
        public string GetEnableServo(int servoId)
        {
            return "<02" + servoId.ToString("00") + ">";
        }
        public string ReadServo(int servoId)
        {
            return "<03" + servoId.ToString("00") + ">";
        }
        public string WriteServo(int servoId, int position, int time)
        {
            return "<04" + servoId.ToString("00") + position.ToString("000") + time.ToString("0000") + ">";
        }

        public Frame Parse(string data)
        {
            Frame frame = new Frame();

            if (data == "<OK>")
            {
                frame.description = "Ack";
            }
            else if (data == "<KO>")
            {
                frame.description = "Nack";
            }
            else
            {
                frame.protocolId = int.Parse(data.Substring(1, 1));
                frame.cmdId = int.Parse(data.Substring(2, 1));

                if (frame.cmdId == CMD_ID_VERSION)
                {
                    frame.description = "Version";
                    if (data.Substring(3, 1) != ">")
                    {
                        frame.parameters = new int[2];
                        frame.parameters[0] = int.Parse(data.Substring(3, 1));
                        frame.parameters[1] = int.Parse(data.Substring(4, 1));
                    }
                }
                else if (frame.cmdId == CMD_ID_READ_SERVOS)
                {
                    frame.description = "Read Servos";
                    if (data.Substring(5, 1) != ">")
                    {
                        frame.parameters = new int[18];
                        for (int i = 0; i < 18; i++)
                        {
                            int position = int.Parse(data.Substring(5 + (i * 3), 3));
                            frame.parameters[i] = position;
                        }
                    }
                }
            }
            return frame;
        }
    }
}
