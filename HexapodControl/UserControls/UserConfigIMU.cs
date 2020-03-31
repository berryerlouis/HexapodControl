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
    public partial class UserConfigIMU : UserControl
    {

        private Timer timerEnable = new Timer();

        public UserConfigIMU() :base()
        {
            InitializeComponent();
            timerEnable.Enabled = false;
            timerEnable.Interval = 2000;
            timerEnable.Tick += TimerEnable_Tick;
        }

        private void TimerEnable_Tick(object sender, EventArgs e)
        {
            if (!this.Enabled) this.Enabled = true;
        }
        
        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            timerEnable.Start();
            
            Bot.GetInstance().SendData(ClusterImu.GetThreshold((List<Object> obj) =>
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    timerEnable.Stop();
                    this.Enabled = true;
                    this.labelThreshold.Text = "Threshold : " + obj[0];
                }));
            }, false));
            Bot.GetInstance().SendData(ClusterImu.GetRollPitchYaw((List<Object> obj) =>
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    timerEnable.Stop();
                    this.Enabled = true;
                    this.labelRoll.Text = "Roll : " + obj[0];
                    this.labelPitch.Text = "Pitch : " + obj[1];
                    this.labelYaw.Text = "Yaw : " + obj[2];
                    this.Enabled = true;
                }));
            }, false));
        }
    }
}
