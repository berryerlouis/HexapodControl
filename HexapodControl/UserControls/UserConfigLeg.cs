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
    public partial class UserConfigLeg : UserControl
    {

        private Timer timerEnable = new Timer();

        public UserConfigLeg() :base()
        {
            InitializeComponent();
            timerEnable.Enabled = false;
            timerEnable.Interval = 2000;
            timerEnable.Tick += TimerEnable_Tick;

            timerEnable.Stop();
            Bot.GetInstance().SendData(ClusterServo.ReadServo(
                0,
                (List<Object> obj) =>
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        panelLeg.Refresh();
                        timerEnable.Stop();
                        this.Enabled = true;
                    }));
                }, false));
            Bot.GetInstance().SendData(ClusterServo.ReadAllServos(
                (List<Object> obj) =>
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        panelLeg.Refresh();
                        timerEnable.Stop();
                        this.Enabled = true;
                    }));
                }, false));
        }
        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelLeg.Refresh();
        }

        private void panelLeg_Paint(object sender, PaintEventArgs e)
        {
            Pen pw = new Pen(Color.Red, 2);
            int botLegCoxa = 30/2;
            int botLegFemur = 85/2;
            int botLegTibia = 125/2;

            //leg left top coxa
            int x1 = 2*panelLeg.Width / 3 ;
            int y1 = panelLeg.Height / 2;
            int x2 = x1 + (int)(botLegCoxa * Math.Cos(0));
            int y2 = y1 + (int)(botLegCoxa * Math.Sin(0));
            pw = new Pen(Color.Red, 2);
            e.Graphics.DrawLine(pw, x1, y1, x2, y2);

            //leg left top femur
            int x3 = x2;
            int y3 = y2;
            int x4 = x3 + (int)(botLegFemur * Math.Cos(NumericExtensions.ToRadians(- Servos.getInstance().getServo(1).GetPos() + 80 - 90)));
            int y4 = y3 + (int)(botLegFemur * Math.Sin(NumericExtensions.ToRadians(- Servos.getInstance().getServo(1).GetPos() + 80 - 90 )));
            pw = new Pen(Color.Orange, 2);
            e.Graphics.DrawLine(pw, x3, y3, x4, y4);

            //leg left top tibia
            int x5 = x4;
            int y5 = y4;
            int x6 = x5 + (int)(botLegTibia * Math.Cos(NumericExtensions.ToRadians(Servos.getInstance().getServo(2).GetPos() - 70 + 180 - Servos.getInstance().getServo(1).GetPos() + 80 - 90)));
            int y6 = y5 + (int)(botLegTibia * Math.Sin(NumericExtensions.ToRadians(Servos.getInstance().getServo(2).GetPos() - 70 + 180 - Servos.getInstance().getServo(1).GetPos() + 80 - 90)));
            pw = new Pen(Color.Yellow, 2);
            e.Graphics.DrawLine(pw, x5, y5, x6, y6);


            /******************************************/

            //leg left top coxa
            x1 = 1 * panelLeg.Width / 4;
            y1 = panelLeg.Height / 2;
            x2 = x1 + (int)(botLegCoxa * Math.Cos(NumericExtensions.ToRadians(Servos.getInstance().getServo(0).GetPos() + 15)));
            y2 = y1 - (int)(botLegCoxa * Math.Sin(NumericExtensions.ToRadians(Servos.getInstance().getServo(0).GetPos() + 15)));
            pw = new Pen(Color.Red, 2);
            e.Graphics.DrawLine(pw, x1, y1, x2, y2);

            x3 = x2;
            y3 = y2;
            x4 = x3 + (int)(botLegFemur * Math.Cos(NumericExtensions.ToRadians(-Servos.getInstance().getServo(1).GetPos() + 80 - 90)));
            y4 = y3 - (int)(botLegCoxa * Math.Sin(NumericExtensions.ToRadians(Servos.getInstance().getServo(0).GetPos() + 15)));
            pw = new Pen(Color.Orange, 2);
            e.Graphics.DrawLine(pw, x3, y3, x4, y4);

            x5 = x4;
            y5 = y4;
            x6 = x5 + (int)(botLegTibia * Math.Cos(NumericExtensions.ToRadians(Servos.getInstance().getServo(2).GetPos() - 70 + 180 - Servos.getInstance().getServo(1).GetPos() + 80 - 90)));
            y6 = y5 - (int)(botLegCoxa * Math.Sin(NumericExtensions.ToRadians(Servos.getInstance().getServo(0).GetPos() + 15)));
            pw = new Pen(Color.Yellow, 2);
            e.Graphics.DrawLine(pw, x5, y5, x6, y6);
        }
        private void TimerEnable_Tick(object sender, EventArgs e)
        {
            if (!this.Enabled) this.Enabled = true;
        }
        

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            timerEnable.Start();
            Bot.GetInstance().SendData(ClusterLeg.setLegXYZ(
                int.Parse(textBoxLegId.Text),
                int.Parse(textBoxX.Text),
                int.Parse(textBoxY.Text),
                int.Parse(textBoxZ.Text),
                int.Parse(labelLegDelay.Text),
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
