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
        UserLog ul = new UserLog();
        UserShow us = new UserShow();
        public IHM()
        {
            InitializeComponent();

            Bot.GetInstance().SetCallbackConnexionStatus(ConnexionStatusChanged);
            Bot.GetInstance().SetCallbackUpdateVersion(UpdateVersion);
            panelBackground.Controls.Add(ul);
            panelBackground.Controls[panelBackground.Controls.IndexOf(ul)].Dock = System.Windows.Forms.DockStyle.Fill;
            panelBackground.Controls[panelBackground.Controls.IndexOf(ul)].Hide();
            panelBackground.Controls.Add(us);
            panelBackground.Controls[panelBackground.Controls.IndexOf(us)].Dock = System.Windows.Forms.DockStyle.Fill;
            panelBackground.Controls[panelBackground.Controls.IndexOf(us)].Hide();
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
            Control c = panelBackground.Controls[panelBackground.Controls.IndexOf(ul)];
            if (!c.Visible)
            {
                c.Show();
            }
            else
            {
                c.Hide();
            }
        }
        private void buttonShowBot_Click(object sender, EventArgs e)
        {
            Control c = panelBackground.Controls[panelBackground.Controls.IndexOf(us)];
            if (!c.Visible)
            {
                c.Show();
            }
            else
            {
                c.Hide();
            }
        }
        #endregion




        private void ConnexionStatusChanged(bool connected)
        {
            if(connected)
            {
                this.buttonConnect.Text = "Disconnect";
                this.buttonConnect.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.buttonConnect.Text = "Connect";
                this.buttonConnect.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void UpdateVersion(string version)
        {
            this.labelVersion.Invoke(new MethodInvoker(delegate
            {
                this.labelVersion.Text = "Version : " + version;
            }));
        }
    }
}
