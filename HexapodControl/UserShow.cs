using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexapodControl
{
    public partial class UserShow : UserControl
    {
        public UserShow()
        {
            InitializeComponent();

            Comm.GetInstance().SetCallBackReceive(DataFromHexapod);
            Comm.GetInstance().SetCallBackSentFrame(DataToHexapod);
        }

        private void DataToHexapod(string data)
        {
        }

        private void DataFromHexapod(Comm.HexapodResponse data)
        {
            if (data.GetStatus() == Comm.HexapodResponse.Status.NO_ERROR)
            {
                Protocol.Frame frame = Protocol.GetInstance().Parse(data.GetResponse());
                if (frame.cmdId == Protocol.CMD_ID_READ_SERVOS)
                {
                    /*this.version = frame.parameters[0] + "." + frame.parameters[1];
                    if (this.callbackUpdateVersion != null)
                    {
                        this.callbackUpdateVersion(this.version);
                    }*/
                }
            }
        }
    }
}
