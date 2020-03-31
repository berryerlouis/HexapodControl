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
        public static List<UserControl> userControls = new List<UserControl>()
        {
            new UserLog(),
            new UserShow(),
            new UserConfig()
        };

        public IHM()
        {
            InitializeComponent();

            DoubleBuffered = true;
            Bot.GetInstance().SetCallbackConnectionStatus(ConnectionStatusChanged);

            //add user control to panelBackground
            for (int i = 0; i < userControls.Count; i++)
            {
                UserControl uc = userControls[i];
                panelBackground.Controls.Add(uc);
                panelBackground.Controls[panelBackground.Controls.IndexOf(uc)].Dock = System.Windows.Forms.DockStyle.Fill;
            }
        }

        private void IHM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bot.GetInstance().Disconnect();
        }

        #region buttons
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if(!Bot.GetInstance().IsConnected())
            {

                Bot.GetInstance().Connect();
                //read version
                Bot.GetInstance().SendData(ClusterGeneral.ReadVersion((List <Object> obj) =>
                {
                    this.labelVersion.Invoke(new MethodInvoker(delegate
                    {
                        this.labelVersion.Text = "Version : " + obj[0];
                    }));
                },true));
            }
            else
            {
                Bot.GetInstance().Disconnect();
            }
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < userControls.Count; i++)
            {
                UserControl uc = userControls[i];
                if (uc is UserLog)
                {
                    uc.BringToFront();
                }
                else
                {
                    uc.SendToBack();
                }
            }
        }
        private void buttonShowBot_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < userControls.Count; i++)
            {
                UserControl uc = userControls[i];
                if (uc is UserShow)
                {
                    uc.BringToFront();
                }
                else
                {
                    uc.SendToBack();
                }
            }
        }
        private void buttonConfig_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < userControls.Count; i++)
            {
                UserControl uc = userControls[i];
                if (uc is UserConfig)
                {
                    uc.BringToFront();
                }
                else
                {
                    uc.SendToBack();
                }
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
        
        #endregion


    }
}
