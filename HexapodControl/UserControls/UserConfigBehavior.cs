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
    public partial class UserConfigBehavior : UserControl
    {

        private Timer timerEnable = new Timer();

        public UserConfigBehavior() :base()
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
            
            Bot.GetInstance().SendData(ClusterBehavior.GetElevation((List<Object> obj) =>
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    timerEnable.Stop();
                    this.Enabled = true;
                    this.labelBehaviorElevation.Text = "Elevation : " + obj[0];
                }));
            }, false));
        }

        private void buttonBehaviorWrite_Click(object sender, EventArgs e)
        {
            Bot.GetInstance().SendData(ClusterBehavior.setElevation(int.Parse(textBoxBehaviorPosition.Text), int.Parse(textBoxBehaviorDelay.Text), (List<Object> obj) =>
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    timerEnable.Stop();
                    this.Enabled = true;
                }));
            }, false));
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

            Bot.GetInstance().SendData(ClusterBehavior.setPosXY(
                int.Parse(textBoxPosX.Text),
                int.Parse(textBoxPosY.Text),
                (List<Object> obj) =>
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        timerEnable.Stop();
                        this.Enabled = true;
                    }));
                }, false));
        }
    }
}
