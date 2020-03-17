using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexapodControl
{
    public partial class Form1 : Form
    {
        class Leg
        {
            public int x;
            public int y;
            public int z;
            public int delay;
            public Leg(int x, int y, int z, int delay)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                this.delay = delay;
            }
        }
        Leg[] legSequence0 = new Leg[] { };
        Leg[] legSequence1 = new Leg[] { };
        int legSequenceIndex = 0;

        int[] servos = new int[20];
        string versionHexapod = null;
        public Form1()
        {
            InitializeComponent();
            this.comboBoxPortCom.Items.AddRange(Comm.GetInstance().GetPortNames());
            if(this.comboBoxPortCom.Items.Count > 0)
            {
                this.comboBoxPortCom.SelectedIndex = 0;
            }
            for(int i = 0; i  < servos.Length; i++)
            {
                servos[i] = 90;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Comm.GetInstance().Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if(this.comboBoxPortCom.SelectedItem != null && this.comboBoxPortCom.SelectedItem.ToString() != "" && !Comm.GetInstance().IsOpen())
            {
                try
                {
                    Comm.GetInstance().SetPortName(this.comboBoxPortCom.SelectedItem.ToString());
                    Comm.GetInstance().SetCallBackReceive(data => Invoke((Comm.CallbackReceiveFrame)DataFromHexapod, new object[] { data }));
                    Comm.GetInstance().SetCallBackSentFrame(data => Invoke((Comm.CallbackSentFrame)DataToHexapod, new object[] { data }));
                    Comm.GetInstance().Open();
                    connectedToHexapod();
                }
                catch
                {
                    Comm.GetInstance().Close();
                    DisconnectFromHexapod();
                }
            }
            else
            {
                Comm.GetInstance().Close();
                DisconnectFromHexapod();
            }
        }

        private void connectedToHexapod()
        {
            this.toolStripLabelConnectStatus.Text = "Connected";
            this.toolStripLabelConnectStatus.ForeColor = System.Drawing.Color.Green;
            this.buttonConnect.Text = "Disconnect";
            this.buttonConnect.ForeColor = System.Drawing.Color.Red;
            this.groupBoxHexapod.Visible = true;
            ReadVersion();
            ReadAllServos();
        }

        private void DisconnectFromHexapod()
        {
            this.toolStripLabelConnectStatus.Text = "Disconnected";
            this.toolStripLabelConnectStatus.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabelStream.Items.Clear();
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.ForeColor = System.Drawing.Color.Green;
            this.toolStripLabelFifoCount.Text = "fifo : 0";
            this.groupBoxHexapod.Visible = false;
        }

        private void SendDataToHexapod(string data)
        {
            if(Comm.GetInstance().IsOpen())
            {
                Comm.GetInstance().SendData(data);
            }
            else
            {
                DisconnectFromHexapod();
            }
        }

        private void DataToHexapod(String data)
        {
            this.toolStripLabelStream.Items.Add("Tx : " + data);
            this.toolStripLabelStream.SelectedIndex = this.toolStripLabelStream.Items.Count - 1;
        }

        private void DataFromHexapod(Comm.HexapodResponse data)
        {
            if(data.GetStatus() == Comm.HexapodResponse.Status.NO_ERROR)
            {
                this.toolStripLabelConnectStatus.Text = "Connected";
                if (versionHexapod != null)
                {
                    this.toolStripLabelConnectStatus.Text += "(" + versionHexapod + ")";
                }
                this.toolStripLabelConnectStatus.ForeColor = System.Drawing.Color.Green;
                this.toolStripLabelStream.Items.Add("Rx : " + data.GetResponse());
                this.toolStripLabelStream.SelectedIndex = this.toolStripLabelStream.Items.Count - 1;
                if (data.GetResponse().Substring(1, 1) == "0") //header
                {
                    try
                    {
                        ExecuteCommand(data.GetResponse());
                    }
                    catch
                    {

                    }
                }

            }
            else if (data.GetStatus() == Comm.HexapodResponse.Status.ERROR)
            {
                if (data.GetError() == Comm.HexapodResponse.Error.TIMEOUT)
                {
                    this.toolStripLabelConnectStatus.ForeColor = System.Drawing.Color.Orange;
                    this.toolStripLabelConnectStatus.Text = "Timeout";
                }
            }
            this.toolStripLabelFifoCount.Text = "fifo : " + Comm.GetInstance().GetFifoSize();
        }

        private void panelHexapod_MouseClick(object sender, MouseEventArgs e)
        {
            ((Panel)(sender)).Invalidate();
        }

        private void panelHexapod_Paint(object sender, PaintEventArgs e)
        {
            const int LEG_COCYX_LENGHT = 32 / 2;	//horizontal
            const int LEG_FEMUR_LENGHT = 78 / 2;	//vertical
            const int LEG_TIBIA_LENGHT = 132 / 2;	//knee
            base.OnPaint(e);
            Graphics g;

            g = e.Graphics;

            Pen myPen = new Pen(Color.Black);
            myPen.Width = 2;

            int width = panelHexapod.Width;
            int height = panelHexapod.Height;


            //body
            int body_width = 150;
            int body_height = 200;
            int start_inter_leg = 20;
            int inter_leg = 80;

            g.DrawRectangle(myPen,
                new Rectangle(new Point(width / 2 - body_width / 2, height / 2 - body_height / 2),
                new Size(body_width, body_height)));


            //left
            for (int i = 0; i < 3; i++)
            { 
                int x1 = width / 2 - body_width / 2;
                int y1 = height / 2 - body_height / 2 + start_inter_leg + inter_leg * i;
                int x2 = (int)(Math.Cos(((90 - servos[i * 3]) * Math.PI) / 180) * LEG_COCYX_LENGHT);
                int y2 = (int)(Math.Sin(((90 - servos[i * 3]) * Math.PI) / 180) * LEG_COCYX_LENGHT);
                g.DrawArc(myPen, x1 - LEG_COCYX_LENGHT, y1 - LEG_COCYX_LENGHT, LEG_COCYX_LENGHT * 2, LEG_COCYX_LENGHT * 2, 90, 180);
                g.DrawLine(myPen,
                    new Point(x1, y1),
                    new Point(x1 - x2, y1 + y2));

                int x3 = (int)(Math.Cos(((0 - servos[(i * 3) + 1]) * Math.PI) / 180) * LEG_FEMUR_LENGHT);
                int y3 = (int)(Math.Sin(((0 - servos[(i * 3) + 1]) * Math.PI) / 180) * LEG_FEMUR_LENGHT);
                g.DrawLine(myPen,
                    new Point(x1 - x2, y1 + y2),
                    new Point(x1 - x2 - x3, y1 + y2 + y3));

                int x4 = (int)(Math.Cos(((0 - servos[(i * 3) + 1] - 0 + servos[(i * 3) + 2]) * Math.PI) / 180) * LEG_TIBIA_LENGHT);
                int y4 = (int)(Math.Sin(((0 - servos[(i * 3) + 1] - 0 + servos[(i * 3) + 2]) * Math.PI) / 180) * LEG_TIBIA_LENGHT);
                g.DrawLine(myPen,
                    new Point(x1 - x2 - x3, y1 + y2 + y3),
                    new Point(x1 - x2 - x3 - x4, y1 + y2 + y3 + y4));
            }
            //right
            for (int i = 3; i < 6; i++)
            {
                int x1 = width / 2 + body_width / 2;
                int y1 = height / 2 - body_height / 2 + start_inter_leg + inter_leg * (i-3); 
                int x2 = (int)(Math.Cos(((90 - servos[i * 3]) * Math.PI) / 180) * LEG_COCYX_LENGHT);
                int y2 = (int)(Math.Sin(((90 - servos[i * 3]) * Math.PI) / 180) * LEG_COCYX_LENGHT);
                g.DrawArc(myPen, x1 - LEG_COCYX_LENGHT, y1 - LEG_COCYX_LENGHT, LEG_COCYX_LENGHT * 2, LEG_COCYX_LENGHT * 2, 270, 180);
                g.DrawLine(myPen,
                    new Point(x1, y1),
                    new Point(x1 + x2, y1 - y2));

                int x3 = (int)(Math.Cos(((180 - servos[(i * 3) + 1]) * Math.PI) / 180) * LEG_FEMUR_LENGHT);
                int y3 = (int)(Math.Sin(((180 - servos[(i * 3) + 1]) * Math.PI) / 180) * LEG_FEMUR_LENGHT);
                g.DrawLine(myPen,
                    new Point(x1 + x2, y1 - y2),
                    new Point(x1 + x2 + x3, y1 - y2 - y3));

                int x4 = (int)(Math.Cos(((180 - servos[(i * 3) + 1] + 180 + servos[(i * 3) + 2]) * Math.PI) / 180) * LEG_TIBIA_LENGHT);
                int y4 = (int)(Math.Sin(((180 - servos[(i * 3) + 1] + 180 + servos[(i * 3) + 2]) * Math.PI) / 180) * LEG_TIBIA_LENGHT);
                g.DrawLine(myPen,
                    new Point(x1 + x2 + x3, y1 - y2 - y3),
                    new Point(x1 + x2 + x3 + x4, y1 - y2 - y3 - y4));
            }
        }

        private void buttonReadAll_Click(object sender, EventArgs e)
        {
            ReadAllServos();
        }

        private void buttonWriteAll_Click(object sender, EventArgs e)
        {
            for (int servoId = 0; servoId < 18; servoId++)
            {
                WriteServo(servoId, 90, 0);
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            int servoId = (int)numericUpDownServo.Value;
            ReadServo(servoId);
            GetEnableServo(servoId);
        }


        private void checkBoxEnableServo_CheckedChanged(object sender, EventArgs e)
        {
            int servoId = (int)numericUpDownServo.Value;
            bool check = checkBoxEnableServo.Checked;
            SetEnableServo(servoId, check);
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            int servoId = (int)numericUpDownServo.Value;
            int position = (int)numericUpDownServoPos.Value;
            int time = (int)numericUpDownDelay.Value;
            
            WriteServo(servoId, position, time);
            ReadServo(servoId);
        }
        
        private void buttonWriteLeg_Click(object sender, EventArgs e)
        {
            int legId = (int)numericUpDownLegId.Value;
            int positionX = (int)numericUpDownX.Value;
            int positionY = (int)numericUpDownY.Value;
            int positionZ = (int)numericUpDownZ.Value;

            WriteLeg(legId, positionX, positionY, positionZ, (int)numericUpDownDelayLeg.Value);
            ReadLeg(legId);
        }

        private void numericUpDownXYZ_ValueChanged(object sender, EventArgs e)
        {
            WriteLeg((int)numericUpDownLegId.Value, (int)numericUpDownX.Value, (int)numericUpDownY.Value, (int)numericUpDownZ.Value, (int)numericUpDownDelayLeg.Value);
            ReadLeg((int)numericUpDownLegId.Value);
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            legSequence0 = new Leg[] {
                new Leg(+15,0,-40,1000),
                new Leg(+15,0,0,1000),
                new Leg(-15,0,0,1000),
                new Leg(-15,0,-40,1000),
            };
            legSequence1 = new Leg[] {
                new Leg(-15,0,0,1000),
                new Leg(-15,0,-40,1000),
                new Leg(+15,0,-40,1000),
                new Leg(+15,0,0,1000),
            };
            timerLegSequence.Enabled = true;
            timerLegSequence.Interval = (int)numericUpDownDelayTimer.Value;
            timerLegSequence.Start();
            legSequenceIndex = 0;
            for (int legId = 0; legId < 6; legId++)
            {
                if (legId % 2 == 0)
                {
                    WriteLeg(legId,
                    legSequence0[legSequenceIndex].x,
                    legSequence0[legSequenceIndex].y,
                    legSequence0[legSequenceIndex].z,
                    legSequence0[legSequenceIndex].delay);
                }
                else
                {
                    WriteLeg(legId,
                    legSequence1[legSequenceIndex].x,
                    legSequence1[legSequenceIndex].y,
                    legSequence1[legSequenceIndex].z,
                    legSequence1[legSequenceIndex].delay);
                }
                ReadLeg(legId);
            }

            legSequenceIndex++;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerLegSequence.Stop();
            timerLegSequence.Enabled = false;
            SetPosition(0,5000);
        }
        
        private void timerLegSequence_Tick(object sender, EventArgs e)
        {
            if ( legSequenceIndex < legSequence0.Count())
            {
                for (int legId = 0; legId < 6; legId++)
                {
                    if (legId % 2 == 0)
                    {
                        WriteLeg(legId,
                        legSequence0[legSequenceIndex].x,
                        legSequence0[legSequenceIndex].y,
                        legSequence0[legSequenceIndex].z,
                        legSequence0[legSequenceIndex].delay);
                    }
                    else
                    {
                        WriteLeg(legId,
                        legSequence1[legSequenceIndex].x,
                        legSequence1[legSequenceIndex].y,
                        legSequence1[legSequenceIndex].z,
                        legSequence1[legSequenceIndex].delay);
                    }
                    ReadLeg(legId);
                }
                legSequenceIndex++;
            }
            else
            {
                if (!checkBoxRepeat.Checked)
                {
                    timerLegSequence.Stop();
                    timerLegSequence.Enabled = false;
                }
                else
                {
                    legSequenceIndex = 0;
                    for (int legId = 0; legId < 6; legId++)
                    {
                        if (legId % 2 == 0)
                        {
                            WriteLeg(legId,
                            legSequence0[legSequenceIndex].x,
                            legSequence0[legSequenceIndex].y,
                            legSequence0[legSequenceIndex].z,
                            legSequence0[legSequenceIndex].delay);
                        }
                        else
                        {
                            WriteLeg(legId,
                            legSequence1[legSequenceIndex].x,
                            legSequence1[legSequenceIndex].y,
                            legSequence1[legSequenceIndex].z,
                            legSequence1[legSequenceIndex].delay);
                        }
                        ReadLeg(legId);
                    }
                    legSequenceIndex++;
                }
            }
            //ReadAllServos();
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            SetPosition(0, 5000);
        }

        private void buttonStraight_Click(object sender, EventArgs e)
        {
            SetPosition(1, 5000);
        }

        private void buttonWalk1_Click(object sender, EventArgs e)
        {
            SetWalk(1,(int)numericUpDownSpeed.Value);
        }

        private void buttonWalk2_Click(object sender, EventArgs e)
        {
            SetWalk(2,(int)numericUpDownSpeed.Value);
        }

        private void buttonStopp_Click(object sender, EventArgs e)
        {
            SetWalk(0, (int)numericUpDownSpeed.Value);
        }

        private void numericUpDownBodyXYZ_ValueChanged(object sender, EventArgs e)
        {
            for (int legId = 0; legId < 6; legId++)
            {
                if(legId < 3)
                {
                    WriteLeg(legId, (int)numericUpDownBodyX.Value, (int)numericUpDownBodyY.Value, (int)numericUpDownBodyZ.Value, (int)numericUpDownBodyDelay.Value);
                }
                else
                {
                    WriteLeg(legId, -1 * (int)numericUpDownBodyX.Value, -1 * (int)numericUpDownBodyY.Value, (int)numericUpDownBodyZ.Value, (int)numericUpDownBodyDelay.Value);
                }
               // ReadLeg(legId);
            }
        }
        



        //Command
        private void ReadVersion()
        {
            SendDataToHexapod("<00>");
        }

        private void ReadAllServos()
        {
            SendDataToHexapod("<0318>");            
        }
        private void SetEnableServo(int servoId, bool enable)
        {
            SendDataToHexapod("<01" + servoId.ToString("00") + (enable ? "1" : "0") + ">");
        }
        private void GetEnableServo(int servoId)
        {
            SendDataToHexapod("<02" + servoId.ToString("00") + ">");
        }
        private void ReadServo(int servoId)
        {
            SendDataToHexapod("<03" + servoId.ToString("00") + ">");
        }
        private void WriteServo(int servoId, int position, int time)
        {
            SendDataToHexapod("<04" + servoId.ToString("00") + position.ToString("000") + time.ToString("0000") + ">");
        }
        private void WriteLeg(int legId, int positionX, int positionY, int positionZ, int time)
        {
            SendDataToHexapod("<09" + 
                legId.ToString("0") +
                ((positionX < 0) ? "-" :"+") +
                positionX.ToString("000") +
                ((positionY < 0) ? "-" : "+") +
                positionY.ToString("000") +
                ((positionZ < 0) ? "-" : "+") +
                positionZ.ToString("000") +
                time.ToString("0000") +
                ">");
        }
        private void ReadLeg(int legId)
        {
            ReadServo(legId * 3);
            ReadServo(legId * 3 + 1);
            ReadServo(legId * 3 + 2);
        }
        private void SetPosition(int position, int delay)
        {
            SendDataToHexapod("<0A" + position.ToString("0") + delay.ToString("0000") + ">");
        }
        private void SetWalk(int walk, int delay)
        {
            SendDataToHexapod("<0B" + walk.ToString("0") + delay.ToString("0000") + ">");
        }
        private void SetMove(int move, int delay)
        {
            SendDataToHexapod("<0C" + move.ToString("0") + delay.ToString("0000") + ">");
        }
        private void ExecuteCommand(String data)
        {
            int cmdId = int.Parse(data.Substring(2, 1));
            if (cmdId == 0)
            {
                versionHexapod = data.Substring(3, 1) + "." + data.Substring(4, 1);
            }
            else if (cmdId == 2)
            {
                checkBoxEnableServo.Checked = data.Substring(5, 1) == "1" ? true : false;
            }
            else if (cmdId == 3)
            {
                int servoId = int.Parse(data.Substring(3, 2));
                if (servoId != 18)
                {
                    int position = int.Parse(data.Substring(5, 3));
                    int time = int.Parse(data.Substring(8, 4));

                    servos[servoId] = position;

                    if ((int)numericUpDownServo.Value == servoId)
                    {
                        numericUpDownServoPos.Value = position;
                    }
                    if ((int)numericUpDownLegId.Value * 3 == servoId)
                    {
                        labelCoxa.Text = "coxa : " + position;
                    }
                    if ((int)numericUpDownLegId.Value * 3 + 1 == servoId)
                    {
                        labelFemur.Text = "femur : " + position;
                    }
                    if ((int)numericUpDownLegId.Value * 3 + 2 == servoId)
                    {
                        labelTibia.Text = "tibia : " + position;
                    }
                }
                else
                {
                    for (int i = 0; i < 18; i++)
                    {
                        int position = int.Parse(data.Substring(5 + (i*3), 3));
                        servos[i] = position;
                    }
                }

                panelHexapod.Refresh();
            }
            else if (cmdId == 5)
            {
                int servoId = int.Parse(data.Substring(3, 2));
                int position = int.Parse(data.Substring(5, 3));

                servos[servoId] = position;
                panelHexapod.Refresh();
            }
            else if (cmdId == 7)
            {
                int servoId = int.Parse(data.Substring(3, 2));
                int position = int.Parse(data.Substring(5, 3));

                servos[servoId] = position;
                panelHexapod.Refresh();
            }
        }

        private void buttonWave_Click(object sender, EventArgs e)
        {
            SetMove(1, (int)numericUpDownSpeed.Value);
        }

        private void buttonRipple_Click(object sender, EventArgs e)
        {
            SetMove(2, (int)numericUpDownSpeed.Value);
        }

        private void buttonTripod_Click(object sender, EventArgs e)
        {
            SetMove(0, (int)numericUpDownSpeed.Value);
        }

        private void numericUpDownServo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            this.toolStripLabelStream.Items.Clear();
            this.toolStripLabelStream.SelectedIndex = this.toolStripLabelStream.Items.Count - 1;
        }

        private void buttonDisableAll_Click(object sender, EventArgs e)
        {
            for (int servoId = 0; servoId < 18; servoId++)
            {
                SetEnableServo(servoId, false);
            }
        }
    }
}
