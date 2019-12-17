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
    public partial class UserLog : UserControl
    {
        public UserLog()
        {
            InitializeComponent();

            Comm.GetInstance().SetCallBackReceive(DataFromHexapod);
            Comm.GetInstance().SetCallBackSentFrame(DataToHexapod);

            listViewLogs.View = View.Details;
            listViewLogs.GridLines = true;
            listViewLogs.FullRowSelect = true;

        }

        private void DataToHexapod(string data)
        {
            ListViewItem LVI = new ListViewItem("Tx");
            LVI.SubItems.Add(data);
            LVI.SubItems.Add(Protocol.GetInstance().Parse(data).description);
            this.listViewLogs.Invoke(new MethodInvoker(delegate
            {
                    this.listViewLogs.Items.Add(LVI);
            }));
        }

        private void DataFromHexapod(Comm.HexapodResponse data)
        {
            ListViewItem LVI = new ListViewItem("Rx");
            LVI.SubItems.Add(data.GetResponse());
            LVI.SubItems.Add(Protocol.GetInstance().Parse(data.GetResponse()).description);
            this.listViewLogs.Invoke(new MethodInvoker(delegate
            {
                this.listViewLogs.Items.Add(LVI);
            }));
        }
    }
}
