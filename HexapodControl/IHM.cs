using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexapodControl
{
    public partial class IHM : Form
    {
        List<UserControl> userControls = new List<UserControl>() 
        { 
            new UserLog(), 
            new UserShow()
        };

        public IHM()
        {
            InitializeComponent();

            Bot.GetInstance().SetCallbackConnectionStatus(ConnectionStatusChanged);
            Bot.GetInstance().SetCallbackUpdateVersion(UpdateVersion);
            //add user control to panelBackground
            for (int i = 0; i < userControls.Count; i++)
            {
                UserControl uc = userControls[i];
                panelBackground.Controls.Add(uc);
                panelBackground.Controls[panelBackground.Controls.IndexOf(uc)].Dock = System.Windows.Forms.DockStyle.Fill;
                if(!(uc is UserShow))
                panelBackground.Controls[panelBackground.Controls.IndexOf(uc)].Hide();
            }
        }


        #region buttons
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if(!Bot.GetInstance().IsConnected())
            {

                Bot.GetInstance().Connect();
            }
            else
            {
                Bot.GetInstance().Disconnect();
            }
        }
        private void buttonLog_Click(object sender, EventArgs e)
        {
            Control c = null;
            for (int i = 0; i < userControls.Count; i++)
            {
                UserControl uc = userControls[i];
                if (uc is UserLog)
                {
                    c = uc;
                }
            }
            if (!c.Visible)
            {
                c.BringToFront();
                c.Show();
            }
            else
            {
                c.Hide();
            }
        }
        private void buttonShowBot_Click(object sender, EventArgs e)
        {
            Control c = null;
            for (int i = 0; i < userControls.Count; i++)
            {
                UserControl uc = userControls[i];
                if (uc is UserShow)
                {
                    c = uc;
                }
            }
            if (!c.Visible)
            {
                c.BringToFront();
                c.Show();
            }
            else
            {
                c.Hide();
            }
        }
        #endregion

        #region events
        private void ConnectionStatusChanged(Bot.EConnectionStatus status)
        {
            if (status == Bot.EConnectionStatus.CONNECTED)
            {
                this.buttonConnect.Text = "Disconnect";
                this.buttonConnect.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                //change
                this.buttonConnect.Text = "Connect";
                this.buttonConnect.ForeColor = System.Drawing.Color.Green;
                if (status == Bot.EConnectionStatus.CONNECTION_ERROR)
                { 
                    //ask to user to retry or not
                    DialogResult dr = MessageBox.Show("Connection failed !", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.Retry)
                    {
                        Bot.GetInstance().Connect();
                    }
                }
            }
        }

        private void UpdateVersion(string version)
        {
            this.labelVersion.Invoke(new MethodInvoker(delegate
            {
                this.labelVersion.Text = "Version : " + version;
            }));
        }
        #endregion
    }
}
