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
    public partial class UserLog : UserControl, ICommReceive, ICommSent
    {
        public UserLog()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(
                    System.Windows.Forms.ControlStyles.UserPaint |
                    System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                    System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                    true);
            this.listViewLogs.View = View.Details;
            this.listViewLogs.GridLines = true;
            this.listViewLogs.FullRowSelect = true;

            foreach(Cluster c in ClustersID.clusters)
            {
                this.comboBoxCluster.Items.Add(c.getClusterName());
            }
            this.comboBoxCluster.SelectedIndex = 0;
            
            Comm.GetInstance().SetObserverReceive(this);
            Comm.GetInstance().SetObserverSent(this);
        }

        #region send and receive
        private string getDescription(Protocol.Frame frame)
        {
            if (frame.raw == "<OK>")
            {
                return "Ack";
            }
            else if (frame.raw == "<KO>")
            {
                return "Nack";
            }
            return "Cluster Id : " + frame.clusterId.ToString("X2") + " (" + frame.clusterName + ") / Command Id : " + frame.cmdId.ToString("X2") + " (" + frame.cmdName + ") ";
        }
        void ICommReceive.DataReceived(HexapodResponse response)
        {
            for (int i = 0; i < response.GetResponses().Count; i++)
            {
                ListViewItem LVI = new ListViewItem("Rx");
                LVI.SubItems.Add(response.GetResponses()[i].sequenceId.ToString("000"));
                LVI.SubItems.Add(response.GetResponses()[i].raw);
                LVI.SubItems.Add(getDescription(response.GetResponses()[i]));
                if (response.GetResponses()[i].raw == "<OK>")
                {
                    LVI.ForeColor = System.Drawing.Color.Green;
                }
                else if (response.GetResponses()[i].raw == "<KO>")
                {
                    LVI.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                }
                this.listViewLogs.Invoke(new MethodInvoker(delegate
                {
                    this.listViewLogs.Items.Add(LVI);
                    this.listViewLogs.Items[this.listViewLogs.Items.Count - 1].EnsureVisible();
                }));
            }
        }

        void ICommSent.DataSent(Protocol.Frame data)
        {
            ListViewItem LVI = new ListViewItem("Tx");
            LVI.SubItems.Add(data.sequenceId.ToString("000"));
            LVI.SubItems.Add(data.raw);
            LVI.SubItems.Add(getDescription(data));
            this.listViewLogs.Invoke(new MethodInvoker(delegate
            {
                this.listViewLogs.Items.Add(LVI);
                this.listViewLogs.Items[this.listViewLogs.Items.Count - 1].EnsureVisible();
            }));
        }
        #endregion
        
        private void comboBoxCluster_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxCommand.Items.Clear();
            foreach (Command c in ClustersID.getClusterByName((string)comboBoxCluster.SelectedItem).getCommands())
            {
                this.comboBoxCommand.Items.Add(c.getCmdName());
            }
            this.comboBoxCommand.SelectedIndex = 0;
        }
        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            this.listViewLogs.Invoke(new MethodInvoker(delegate
            {
                this.listViewLogs.Items.Clear();
            }));
        }

        private void buttonSendLog1_Click(object sender, EventArgs e)
        {
            Bot.GetInstance().SendData("<"+ textBoxSendLog1.Text+">");
        }

        private void buttonSendLog2_Click(object sender, EventArgs e)
        {
            Cluster c = ClustersID.getClusterByName((string)comboBoxCluster.SelectedItem);
            Command cc = c.getCommandByName((string)comboBoxCommand.SelectedItem);
            
            Bot.GetInstance().SendData(
                "<" +
                "0" +
                c.getClusterId().ToString("X2") +
                cc.getCmdId().ToString("X2") +
                textBoxSendPayload.Text.Count().ToString("X2") +
                textBoxSendPayload.Text + ">");
        }

    }
}
