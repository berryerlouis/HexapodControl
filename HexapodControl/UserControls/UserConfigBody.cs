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
    public partial class UserConfigBody : UserControl
    {

        private Timer timerEnable = new Timer();

        public UserConfigBody() :base()
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


        private void buttonBodyStop_Click(object sender, EventArgs e)
        {
            Bot.GetInstance().SendData(ClusterBehavior.setBehavior(0, int.Parse(textBoxServoDelay.Text),
                (List<Object> obj) =>
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        timerEnable.Stop();
                        this.Enabled = true;
                    }));
                }, false));
        }

        private void buttonBodyStar_Click(object sender, EventArgs e)
        {
            Bot.GetInstance().SendData(ClusterBehavior.setBehavior(1, int.Parse(textBoxServoDelay.Text),
                (List<Object> obj) =>
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        timerEnable.Stop();
                        this.Enabled = true;
                    }));
                }, false));
        }

        private void buttonBodyStraight_Click(object sender, EventArgs e)
        {
            Bot.GetInstance().SendData(ClusterBehavior.setBehavior(2, int.Parse(textBoxServoDelay.Text),
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
