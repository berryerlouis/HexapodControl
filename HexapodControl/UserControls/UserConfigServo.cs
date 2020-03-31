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
    public partial class UserConfigServo : UserControl
    {

        private Timer timerEnable = new Timer();
        private int idServo = 0;
        public UserConfigServo(int id) :base()
        {
            this.idServo = id;
            InitializeComponent();
            timerEnable.Enabled = false;
            timerEnable.Interval = 2000;
            timerEnable.Tick += TimerEnable_Tick;
            this.groupBoxServo.Text = "SERVO : " + id.ToString("00");
        }

        private void TimerEnable_Tick(object sender, EventArgs e)
        {
            if (!this.Enabled) this.Enabled = true;
        }

        private void buttonServoWrite_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            timerEnable.Start();
            Bot.GetInstance().SendData(ClusterServo.WriteServo(idServo, int.Parse(textBoxServoPosition.Text) + 90, int.Parse(textBoxServoDelay.Text), (List<Object> obj) =>
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    timerEnable.Stop();
                    this.Enabled = true;
                }));
            }, true));

            Bot.GetInstance().SendData(ClusterServo.ReadServo(idServo, (List<Object> obj) =>
            {
                this.labelPosition.Invoke(new MethodInvoker(delegate
                {
                    this.labelPosition.Text = "Position : " + obj[1];
                    this.textBoxServoPosition.Text = "" + obj[1];
                }));
                this.trackBarPosition.Invoke(new MethodInvoker(delegate
                {
                    this.trackBarPosition.Value = (int)obj[1];
                }));
            }, true));
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            timerEnable.Start();

            Bot.GetInstance().SendData(ClusterServo.ReadServo(idServo, (List<Object> obj) =>
            {
                this.labelMin.Invoke(new MethodInvoker(delegate
                {
                    labelPosition.Text = "Position : " + obj[1];
                    textBoxServoPosition.Text = obj[1].ToString();
                    trackBarPosition.Minimum = (int)obj[1]; 
                    trackBarPosition.Maximum = (int)obj[1];
                    trackBarPosition.Value = (int)obj[1];
                }));
            }, true));
            Bot.GetInstance().SendData(ClusterServo.ReadMinServo(idServo, (List<Object> obj) =>
            {
                this.labelMin.Invoke(new MethodInvoker(delegate
                {
                    this.labelMin.Text = "Min : " + obj[1];
                    this.trackBarPosition.Minimum = (int)obj[1];
                }));
            }, true));
            Bot.GetInstance().SendData(ClusterServo.ReadMaxServo(idServo, (List<Object> obj) =>
            {
                this.labelMax.Invoke(new MethodInvoker(delegate
                {
                    this.labelMax.Text = "Max : " + obj[1];
                    this.trackBarPosition.Maximum = (int)obj[1];
                }));
            }, true));
            Bot.GetInstance().SendData(ClusterServo.ServoStatus(idServo, (List<Object> obj) =>
            {
                this.checkBoxEnable.Invoke(new MethodInvoker(delegate
                {
                    timerEnable.Stop();
                    this.checkBoxEnable.Checked = (bool)obj[1];
                    this.Enabled = true;
                }));
            }, true));
        }
    }
}
