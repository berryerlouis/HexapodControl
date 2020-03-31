using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace HexapodControl
{
    public partial class UserShow : UserControl, ICommReceive
    {
        public class MyPanel : System.Windows.Forms.Panel
        {
            public MyPanel()
            {
                this.SetStyle(
                    System.Windows.Forms.ControlStyles.UserPaint |
                    System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                    System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                    true);
            }
        }

        public UserShow()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }


        public void DataReceived(HexapodResponse response)
        {
            for (int i = 0; i < response.GetResponses().Count; i++)
            {
                if(response.GetResponses()[i].clusterName == "SERVOS")
                {
                    this.panelViewRobot.Invoke(new MethodInvoker(delegate
                    {
                        this.panelViewRobot.Invalidate();
                    }));
                }
                
            }
        }


        private void panelViewRobot_Paint(object sender, PaintEventArgs e)
        {
            // Create pen.
            Pen pg = new Pen(Color.Gray, 2);
            Pen pw = new Pen(Color.White, 2);
            Pen pus = new Pen(Color.LightGreen, 2);
            Pen pir = new Pen(Color.IndianRed, 2);

            //size of user control
            int width = ((Panel)(sender)).Width;
            int height = ((Panel)(sender)).Height;

            //body measures
            int botWidth = 100;
            int botHeight = 175;
            int botInterLeg = 80;
            int botLegCoxa = 30;
            int botLegFemur = 85;
            int botLegTibia = 125;

            // Create rectangle for background
            e.Graphics.DrawRectangle(pg, new Rectangle(0, 0, width - 0, height - 0));


            // Create bot
            //create rectangle for body 
            e.Graphics.DrawPath(pw, RoundedRect(new Rectangle(width / 2 - botWidth / 2, height / 2 - botHeight / 2, botWidth, botHeight), 5));

            //create legs
            //left
            for (int i = 0; i < 9; i+=3)
            {
                //leg left top coxa
                int x1 = width / 2 - botWidth / 2;
                int y1 = height / 2 - botHeight / 2 + botInterLeg * (i/3) + 5;
                int x2 = x1 - (int)(botLegCoxa * Math.Cos(NumericExtensions.ToRadians(Servos.getInstance().getServo(i).GetPos())));
                int y2 = y1 - (int)(botLegCoxa * Math.Sin(NumericExtensions.ToRadians(Servos.getInstance().getServo(i).GetPos())));
                e.Graphics.DrawLine(pw, x1, y1, x2, y2);

                //leg left top femur
                int x3 = x2;
                int y3 = y2;
                int x4 = x3 + (int)(botLegFemur * Math.Cos(NumericExtensions.ToRadians(Servos.getInstance().getServo(i + 1).GetPos() + 180 + Servos.getInstance().getServo(i).GetPos())));
                int y4 = y3 + (int)(botLegFemur * Math.Sin(NumericExtensions.ToRadians(Servos.getInstance().getServo(i + 1).GetPos() + 180 + Servos.getInstance().getServo(i).GetPos())));
                e.Graphics.DrawLine(pw, x3, y3, x4, y4);

                //leg left top tibia
                int x5 = x4;
                int y5 = y4;
                int x6 = x5 - (int)(botLegTibia * Math.Cos(NumericExtensions.ToRadians(Servos.getInstance().getServo(i + 2).GetPos() + Servos.getInstance().getServo(i + 1).GetPos() + Servos.getInstance().getServo(i).GetPos())));
                int y6 = y5 + (int)(botLegTibia * Math.Sin(NumericExtensions.ToRadians(Servos.getInstance().getServo(i + 2).GetPos() + Servos.getInstance().getServo(i + 1).GetPos() + Servos.getInstance().getServo(i).GetPos())));
                e.Graphics.DrawLine(pw, x5, y5, x6, y6);

            }
            //right
            for (int i = 0; i < 9; i += 3)
            {
                //leg left top coxa
                int x1 = width / 2 + botWidth / 2;
                int y1 = height / 2 - botHeight / 2 + botInterLeg * (i/3) + 5;
                int x2 = x1 + (int)(botLegCoxa * Math.Cos(NumericExtensions.ToRadians(Servos.getInstance().getServo(i + 9).GetPos())));
                int y2 = y1 + (int)(botLegCoxa * Math.Sin(NumericExtensions.ToRadians(Servos.getInstance().getServo(i + 9).GetPos())));
                e.Graphics.DrawLine(pw, x1, y1, x2, y2);

                //leg left top femur
                int x3 = x2;
                int y3 = y2;
                int x4 = x3 + (int)(botLegFemur * Math.Cos(NumericExtensions.ToRadians(Servos.getInstance().getServo(i + 10).GetPos() + 180  + Servos.getInstance().getServo(i + 9).GetPos())));
                int y4 = y3 + (int)(botLegFemur * Math.Sin(NumericExtensions.ToRadians(Servos.getInstance().getServo(i + 10).GetPos() + 180 + Servos.getInstance().getServo(i + 9).GetPos())));
                e.Graphics.DrawLine(pw, x3, y3, x4, y4);

                //leg left top tibia
                int x5 = x4;
                int y5 = y4;
                int x6 = x5 + (int)(botLegTibia * Math.Cos(NumericExtensions.ToRadians(-Servos.getInstance().getServo(i + 11).GetPos() + Servos.getInstance().getServo(i + 10).GetPos() + Servos.getInstance().getServo(i + 9).GetPos())));
                int y6 = y5 + (int)(botLegTibia * Math.Sin(NumericExtensions.ToRadians(-Servos.getInstance().getServo(i + 11).GetPos() + Servos.getInstance().getServo(i + 10).GetPos() + Servos.getInstance().getServo(i + 9).GetPos())));
                e.Graphics.DrawLine(pw, x5, y5, x6, y6);
            }
        }
        private void panelButtonsControl_Paint(object sender, PaintEventArgs e)
        {
            // Create pen.
            Pen pg = new Pen(Color.Gray, 2);
            //size of user control
            int width = ((Panel)(sender)).Width;
            int height = ((Panel)(sender)).Height;
            // Create rectangle for background
            e.Graphics.DrawRectangle(pg, new Rectangle(0, 0, width - 0, height - 0));
        }

        
        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }





        private void buttonReadAll_Click(object sender, EventArgs e)
        {
            Bot.GetInstance().SendData(ClusterServo.ReadAllServos((List<Object> obj) =>
            {
                this.panelViewRobot.Invoke(new MethodInvoker(delegate
                {
                    this.panelViewRobot.Invalidate();
                }));
            }, true));
        }



        

        private void UserShow_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }


    /// <summary>
    /// Convert to Radians.
    /// </summary>
    /// <param name="val">The value to convert to radians</param>
    /// <returns>The value in radians</returns>
    public static class NumericExtensions
    {
        public static double ToRadians(this double val)
        {
            return Math.PI * val / 180.0;
        }

        public static double ToDegrees(this double val)
        {
            return val * (180.0 / Math.PI);
        }
    }
}
