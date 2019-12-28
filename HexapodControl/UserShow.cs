using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace HexapodControl
{
    public partial class UserShow : UserControl
    {

        public UserShow()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Comm.GetInstance().SetCallBackReceive(DataFromHexapod);
            Comm.GetInstance().SetCallBackSentFrame(DataToHexapod);
        }

        private void DataToHexapod(string data)
        {
        }

        private void DataFromHexapod(Comm.HexapodResponse data)
        {
            if (data.GetStatus() == Comm.HexapodResponse.Status.NO_ERROR)
            {
                Protocol.Frame frame = Protocol.GetInstance().Parse(data.GetResponse());
                if (frame.cmdId == Protocol.CMD_ID_READ_SERVOS)
                {
                    /*this.version = frame.parameters[0] + "." + frame.parameters[1];
                    if (this.callbackUpdateVersion != null)
                    {
                        this.callbackUpdateVersion(this.version);
                    }*/
                }
            }
        }

        private void UserShow_Paint(object sender, PaintEventArgs e)
        {
            // Create pen.
            Pen pg = new Pen(Color.Gray, 2);
            Pen pw = new Pen(Color.White, 2);
            Pen pus = new Pen(Color.LightGreen, 1);
            Pen pir = new Pen(Color.IndianRed, 1);

            //size of user control
            int width = ((UserControl)(sender)).Width;
            int height = ((UserControl)(sender)).Height;

            //body measures
            int botWidth = 120;
            int botHeight = 200;
            int botInterLeg = botHeight / 6;
            int botLegCoxa = 20;
            int botLegFemur = 70;
            int botLegTibia = 70;

            // Create rectangle for background
            e.Graphics.DrawRectangle(pg, new Rectangle(20, 20, width - 40, height - 40));


            // Create bot
            //create rectangle for body 
            e.Graphics.DrawPath(pw, RoundedRect(new Rectangle(width / 2 - botWidth / 2, height / 2 - botHeight / 2, botWidth, botHeight), 5));
            
            //create legs
            //left
            for (int i = 0; i < 3; i++)
            {
                //leg left top coxa
                int x1 = width / 2 - botWidth / 2;
                int y1 = height / 2 - botHeight / 2 + botInterLeg * (i * 2 + 1);
                int x2 = x1 - (int)(botLegCoxa * Math.Cos(NumericExtensions.ToRadians(trackBarCoxaAngle.Value)));
                int y2 = y1 + (int)(botLegCoxa * Math.Sin(NumericExtensions.ToRadians(trackBarCoxaAngle.Value)));
                e.Graphics.DrawLine(pw, x1, y1, x2, y2);

                //leg left top femur
                int x3 = x2;
                int y3 = y2;
                int x4 = x3 - (int)(botLegFemur * Math.Cos(NumericExtensions.ToRadians(trackBarFemurAngle.Value - 90 + trackBarCoxaAngle.Value)));
                int y4 = y3 + (int)(botLegFemur * Math.Sin(NumericExtensions.ToRadians(trackBarFemurAngle.Value - 90 + trackBarCoxaAngle.Value)));
                e.Graphics.DrawLine(pw, x3, y3, x4, y4);

                //leg left top tibia
                int x5 = x4;
                int y5 = y4;
                int x6 = x5 - (int)(botLegTibia * Math.Cos(NumericExtensions.ToRadians(trackBarTibiaAngle.Value + trackBarFemurAngle.Value + trackBarCoxaAngle.Value)));
                int y6 = y5 + (int)(botLegTibia * Math.Sin(NumericExtensions.ToRadians(trackBarTibiaAngle.Value + trackBarFemurAngle.Value + trackBarCoxaAngle.Value)));
                e.Graphics.DrawLine(pw, x5, y5, x6, y6);
            }
            //right
            for (int i = 0; i < 3; i++)
            {
                //leg left top coxa
                int x1 = width / 2 + botWidth / 2;
                int y1 = height / 2 - botHeight / 2 + botInterLeg * (i * 2 + 1);
                int x2 = x1 + (int)(botLegCoxa * Math.Cos(NumericExtensions.ToRadians(trackBarCoxaAngle.Value)));
                int y2 = y1 + (int)(botLegCoxa * Math.Sin(NumericExtensions.ToRadians(trackBarCoxaAngle.Value)));
                e.Graphics.DrawLine(pw, x1, y1, x2, y2);

                //leg left top femur
                int x3 = x2;
                int y3 = y2;
                int x4 = x3 + (int)(botLegFemur * Math.Cos(NumericExtensions.ToRadians(trackBarFemurAngle.Value - 90 + trackBarCoxaAngle.Value)));
                int y4 = y3 + (int)(botLegFemur * Math.Sin(NumericExtensions.ToRadians(trackBarFemurAngle.Value - 90 + trackBarCoxaAngle.Value)));
                e.Graphics.DrawLine(pw, x3, y3, x4, y4);

                //leg left top tibia
                int x5 = x4;
                int y5 = y4;
                int x6 = x5 + (int)(botLegTibia * Math.Cos(NumericExtensions.ToRadians(trackBarTibiaAngle.Value + trackBarFemurAngle.Value + trackBarCoxaAngle.Value)));
                int y6 = y5 + (int)(botLegTibia * Math.Sin(NumericExtensions.ToRadians(trackBarTibiaAngle.Value + trackBarFemurAngle.Value + trackBarCoxaAngle.Value)));
                e.Graphics.DrawLine(pw, x5, y5, x6, y6);
            }

            //radar ultrasound part
            //left
            if (radarTimer > 0)
                e.Graphics.DrawArc(pus, new Rectangle(width / 2 - botWidth / 2 + 30, height / 2 - botHeight / 2 - 10, 10, 10), 180, 90);
            if (radarTimer > 1)
                e.Graphics.DrawArc(pus, new Rectangle(width / 2 - botWidth / 2 + 15, height / 2 - botHeight / 2 - 30, 30, 30), 180, 90);
            if (radarTimer > 2)
                e.Graphics.DrawArc(pus, new Rectangle(width / 2 - botWidth / 2, height / 2 - botHeight / 2 - 50, 50, 50), 180, 90);

            //right
            if (radarTimer > 0)
                e.Graphics.DrawArc(pus, new Rectangle(width / 2 + botWidth / 2 - 40, height / 2 - botHeight / 2 - 10, 10, 10), 0, -90);
            if (radarTimer > 1)
                e.Graphics.DrawArc(pus, new Rectangle(width / 2 + botWidth / 2 - 45, height / 2 - botHeight / 2 - 30, 30, 30), 0, -90);
            if (radarTimer > 2)
                e.Graphics.DrawArc(pus, new Rectangle(width / 2 + botWidth / 2 - 50, height / 2 - botHeight / 2 - 50, 50, 50), 0, -90);

            //radar infrared part
            //center
            if (radarTimer > 0)
                e.Graphics.DrawArc(pir, new Rectangle(width / 2 - botWidth / 2 + 55, height / 2 - botHeight / 2 - 10, 10, 10), -135, 90);
            if (radarTimer > 1)
                e.Graphics.DrawArc(pir, new Rectangle(width / 2 - botWidth / 2 + 45, height / 2 - botHeight / 2 - 30, 30, 30), -135, 90);
            if (radarTimer > 2)
                e.Graphics.DrawArc(pir, new Rectangle(width / 2 - botWidth / 2 + 35, height / 2 - botHeight / 2 - 50, 50, 50), -135, 90);
        }

        int radarTimer = 0;
        private void timeRadar_Tick(object sender, EventArgs e)
        {
            radarTimer++;
            if (radarTimer == 4) radarTimer = 0;
            Invalidate();
        }

        private void UserShow_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void trackBarAngle_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
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
