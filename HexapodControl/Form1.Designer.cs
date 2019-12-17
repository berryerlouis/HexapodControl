using System;

namespace HexapodControl
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.toolStripStatus = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelConnectStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelLiveStream = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelStream = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabelFifoCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.groupBoxHexapod = new System.Windows.Forms.GroupBox();
            this.groupBoxBodyWalk = new System.Windows.Forms.GroupBox();
            this.buttonTripod = new System.Windows.Forms.Button();
            this.buttonRipple = new System.Windows.Forms.Button();
            this.buttonWave = new System.Windows.Forms.Button();
            this.buttonStopp = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.buttonMoveBW = new System.Windows.Forms.Button();
            this.buttonMoveFW = new System.Windows.Forms.Button();
            this.groupBoxControlBody = new System.Windows.Forms.GroupBox();
            this.numericUpDownBodyDelay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownBodyZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBodyY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBodyX = new System.Windows.Forms.NumericUpDown();
            this.buttonStraight = new System.Windows.Forms.Button();
            this.buttonStar = new System.Windows.Forms.Button();
            this.numericUpDownDelayLeg = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxSequence = new System.Windows.Forms.GroupBox();
            this.numericUpDownDelayTimer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxLeg = new System.Windows.Forms.GroupBox();
            this.labelTibia = new System.Windows.Forms.Label();
            this.labelFemur = new System.Windows.Forms.Label();
            this.labelCoxa = new System.Windows.Forms.Label();
            this.buttonWriteLeg = new System.Windows.Forms.Button();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.labelPosZ = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.labelPosY = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelPosX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownLegId = new System.Windows.Forms.NumericUpDown();
            this.groupBoxVisualization = new System.Windows.Forms.GroupBox();
            this.panelHexapod = new System.Windows.Forms.Panel();
            this.groupBoxLegs = new System.Windows.Forms.GroupBox();
            this.buttonDisableAll = new System.Windows.Forms.Button();
            this.buttonWriteAll = new System.Windows.Forms.Button();
            this.buttonReadAll = new System.Windows.Forms.Button();
            this.groupBoxControlLeg = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableServo = new System.Windows.Forms.CheckBox();
            this.numericUpDownServoPos = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.buttonWriteServo = new System.Windows.Forms.Button();
            this.buttonReadServo = new System.Windows.Forms.Button();
            this.labelDelay = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelServoId = new System.Windows.Forms.Label();
            this.numericUpDownServo = new System.Windows.Forms.NumericUpDown();
            this.groupBoxCommunication = new System.Windows.Forms.GroupBox();
            this.comboBoxPortCom = new System.Windows.Forms.ComboBox();
            this.timerLegSequence = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatus.SuspendLayout();
            this.groupBoxHexapod.SuspendLayout();
            this.groupBoxBodyWalk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.groupBoxControlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBodyDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBodyZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBodyY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBodyX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayLeg)).BeginInit();
            this.groupBoxSequence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayTimer)).BeginInit();
            this.groupBoxLeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLegId)).BeginInit();
            this.groupBoxVisualization.SuspendLayout();
            this.groupBoxLegs.SuspendLayout();
            this.groupBoxControlLeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownServoPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownServo)).BeginInit();
            this.groupBoxCommunication.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(10, 46);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(89, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelConnectStatus,
            this.toolStripSeparator1,
            this.toolStripLabelLiveStream,
            this.toolStripLabelStream,
            this.toolStripLabelFifoCount,
            this.toolStripSeparator2,
            this.toolStripButtonClear});
            this.toolStripStatus.Location = new System.Drawing.Point(0, 586);
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(1093, 25);
            this.toolStripStatus.TabIndex = 1;
            this.toolStripStatus.Text = "toolStrip1";
            // 
            // toolStripLabelConnectStatus
            // 
            this.toolStripLabelConnectStatus.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabelConnectStatus.Name = "toolStripLabelConnectStatus";
            this.toolStripLabelConnectStatus.Size = new System.Drawing.Size(79, 22);
            this.toolStripLabelConnectStatus.Text = "Disconnected";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelLiveStream
            // 
            this.toolStripLabelLiveStream.Name = "toolStripLabelLiveStream";
            this.toolStripLabelLiveStream.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabelLiveStream.Text = "Live Stream : ";
            // 
            // toolStripLabelStream
            // 
            this.toolStripLabelStream.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripLabelStream.DropDownWidth = 100;
            this.toolStripLabelStream.Name = "toolStripLabelStream";
            this.toolStripLabelStream.Size = new System.Drawing.Size(500, 25);
            // 
            // toolStripLabelFifoCount
            // 
            this.toolStripLabelFifoCount.Name = "toolStripLabelFifoCount";
            this.toolStripLabelFifoCount.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabelFifoCount.Text = "fifo : 0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(38, 22);
            this.toolStripButtonClear.Text = "Clear";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // groupBoxHexapod
            // 
            this.groupBoxHexapod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxHexapod.Controls.Add(this.groupBoxBodyWalk);
            this.groupBoxHexapod.Controls.Add(this.groupBoxControlBody);
            this.groupBoxHexapod.Controls.Add(this.numericUpDownDelayLeg);
            this.groupBoxHexapod.Controls.Add(this.label3);
            this.groupBoxHexapod.Controls.Add(this.groupBoxSequence);
            this.groupBoxHexapod.Controls.Add(this.groupBoxLeg);
            this.groupBoxHexapod.Controls.Add(this.groupBoxVisualization);
            this.groupBoxHexapod.Controls.Add(this.groupBoxLegs);
            this.groupBoxHexapod.Controls.Add(this.groupBoxControlLeg);
            this.groupBoxHexapod.Location = new System.Drawing.Point(119, 12);
            this.groupBoxHexapod.Name = "groupBoxHexapod";
            this.groupBoxHexapod.Size = new System.Drawing.Size(965, 555);
            this.groupBoxHexapod.TabIndex = 2;
            this.groupBoxHexapod.TabStop = false;
            this.groupBoxHexapod.Text = "Hexapod";
            this.groupBoxHexapod.Visible = false;
            // 
            // groupBoxBodyWalk
            // 
            this.groupBoxBodyWalk.Controls.Add(this.buttonTripod);
            this.groupBoxBodyWalk.Controls.Add(this.buttonRipple);
            this.groupBoxBodyWalk.Controls.Add(this.buttonWave);
            this.groupBoxBodyWalk.Controls.Add(this.buttonStopp);
            this.groupBoxBodyWalk.Controls.Add(this.labelSpeed);
            this.groupBoxBodyWalk.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxBodyWalk.Controls.Add(this.buttonMoveBW);
            this.groupBoxBodyWalk.Controls.Add(this.buttonMoveFW);
            this.groupBoxBodyWalk.Location = new System.Drawing.Point(305, 188);
            this.groupBoxBodyWalk.Name = "groupBoxBodyWalk";
            this.groupBoxBodyWalk.Size = new System.Drawing.Size(293, 136);
            this.groupBoxBodyWalk.TabIndex = 24;
            this.groupBoxBodyWalk.TabStop = false;
            this.groupBoxBodyWalk.Text = "Control Body Walk";
            // 
            // buttonTripod
            // 
            this.buttonTripod.Location = new System.Drawing.Point(168, 107);
            this.buttonTripod.Name = "buttonTripod";
            this.buttonTripod.Size = new System.Drawing.Size(75, 23);
            this.buttonTripod.TabIndex = 28;
            this.buttonTripod.Text = "Tripod";
            this.buttonTripod.UseVisualStyleBackColor = true;
            this.buttonTripod.Click += new System.EventHandler(this.buttonTripod_Click);
            // 
            // buttonRipple
            // 
            this.buttonRipple.Location = new System.Drawing.Point(87, 107);
            this.buttonRipple.Name = "buttonRipple";
            this.buttonRipple.Size = new System.Drawing.Size(75, 23);
            this.buttonRipple.TabIndex = 27;
            this.buttonRipple.Text = "Ripple";
            this.buttonRipple.UseVisualStyleBackColor = true;
            this.buttonRipple.Click += new System.EventHandler(this.buttonRipple_Click);
            // 
            // buttonWave
            // 
            this.buttonWave.Location = new System.Drawing.Point(6, 107);
            this.buttonWave.Name = "buttonWave";
            this.buttonWave.Size = new System.Drawing.Size(75, 23);
            this.buttonWave.TabIndex = 26;
            this.buttonWave.Text = "Wave";
            this.buttonWave.UseVisualStyleBackColor = true;
            this.buttonWave.Click += new System.EventHandler(this.buttonWave_Click);
            // 
            // buttonStopp
            // 
            this.buttonStopp.Location = new System.Drawing.Point(6, 38);
            this.buttonStopp.Name = "buttonStopp";
            this.buttonStopp.Size = new System.Drawing.Size(75, 23);
            this.buttonStopp.TabIndex = 25;
            this.buttonStopp.Text = "Stop";
            this.buttonStopp.UseVisualStyleBackColor = true;
            this.buttonStopp.Click += new System.EventHandler(this.buttonStopp_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(164, 43);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(44, 13);
            this.labelSpeed.TabIndex = 24;
            this.labelSpeed.Text = "Speed :";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(214, 41);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownSpeed.TabIndex = 23;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // buttonMoveBW
            // 
            this.buttonMoveBW.Location = new System.Drawing.Point(87, 57);
            this.buttonMoveBW.Name = "buttonMoveBW";
            this.buttonMoveBW.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveBW.TabIndex = 11;
            this.buttonMoveBW.Text = "RV";
            this.buttonMoveBW.UseVisualStyleBackColor = true;
            this.buttonMoveBW.Click += new System.EventHandler(this.buttonWalk2_Click);
            // 
            // buttonMoveFW
            // 
            this.buttonMoveFW.Location = new System.Drawing.Point(87, 19);
            this.buttonMoveFW.Name = "buttonMoveFW";
            this.buttonMoveFW.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveFW.TabIndex = 10;
            this.buttonMoveFW.Text = "FW";
            this.buttonMoveFW.UseVisualStyleBackColor = true;
            this.buttonMoveFW.Click += new System.EventHandler(this.buttonWalk1_Click);
            // 
            // groupBoxControlBody
            // 
            this.groupBoxControlBody.Controls.Add(this.numericUpDownBodyDelay);
            this.groupBoxControlBody.Controls.Add(this.label4);
            this.groupBoxControlBody.Controls.Add(this.numericUpDownBodyZ);
            this.groupBoxControlBody.Controls.Add(this.numericUpDownBodyY);
            this.groupBoxControlBody.Controls.Add(this.numericUpDownBodyX);
            this.groupBoxControlBody.Controls.Add(this.buttonStraight);
            this.groupBoxControlBody.Controls.Add(this.buttonStar);
            this.groupBoxControlBody.Location = new System.Drawing.Point(305, 20);
            this.groupBoxControlBody.Name = "groupBoxControlBody";
            this.groupBoxControlBody.Size = new System.Drawing.Size(293, 160);
            this.groupBoxControlBody.TabIndex = 23;
            this.groupBoxControlBody.TabStop = false;
            this.groupBoxControlBody.Text = "Control Body";
            // 
            // numericUpDownBodyDelay
            // 
            this.numericUpDownBodyDelay.Location = new System.Drawing.Point(133, 116);
            this.numericUpDownBodyDelay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownBodyDelay.Name = "numericUpDownBodyDelay";
            this.numericUpDownBodyDelay.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownBodyDelay.TabIndex = 28;
            this.numericUpDownBodyDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Delay :";
            // 
            // numericUpDownBodyZ
            // 
            this.numericUpDownBodyZ.Location = new System.Drawing.Point(162, 80);
            this.numericUpDownBodyZ.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownBodyZ.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
            this.numericUpDownBodyZ.Name = "numericUpDownBodyZ";
            this.numericUpDownBodyZ.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownBodyZ.TabIndex = 26;
            this.numericUpDownBodyZ.ValueChanged += new System.EventHandler(this.numericUpDownBodyXYZ_ValueChanged);
            // 
            // numericUpDownBodyY
            // 
            this.numericUpDownBodyY.Location = new System.Drawing.Point(103, 80);
            this.numericUpDownBodyY.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownBodyY.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
            this.numericUpDownBodyY.Name = "numericUpDownBodyY";
            this.numericUpDownBodyY.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownBodyY.TabIndex = 25;
            this.numericUpDownBodyY.ValueChanged += new System.EventHandler(this.numericUpDownBodyXYZ_ValueChanged);
            // 
            // numericUpDownBodyX
            // 
            this.numericUpDownBodyX.Location = new System.Drawing.Point(44, 80);
            this.numericUpDownBodyX.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownBodyX.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
            this.numericUpDownBodyX.Name = "numericUpDownBodyX";
            this.numericUpDownBodyX.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownBodyX.TabIndex = 24;
            this.numericUpDownBodyX.ValueChanged += new System.EventHandler(this.numericUpDownBodyXYZ_ValueChanged);
            // 
            // buttonStraight
            // 
            this.buttonStraight.Location = new System.Drawing.Point(212, 19);
            this.buttonStraight.Name = "buttonStraight";
            this.buttonStraight.Size = new System.Drawing.Size(75, 23);
            this.buttonStraight.TabIndex = 11;
            this.buttonStraight.Text = "Straight";
            this.buttonStraight.UseVisualStyleBackColor = true;
            this.buttonStraight.Click += new System.EventHandler(this.buttonStraight_Click);
            // 
            // buttonStar
            // 
            this.buttonStar.Location = new System.Drawing.Point(6, 19);
            this.buttonStar.Name = "buttonStar";
            this.buttonStar.Size = new System.Drawing.Size(75, 23);
            this.buttonStar.TabIndex = 10;
            this.buttonStar.Text = "Star";
            this.buttonStar.UseVisualStyleBackColor = true;
            this.buttonStar.Click += new System.EventHandler(this.buttonStar_Click);
            // 
            // numericUpDownDelayLeg
            // 
            this.numericUpDownDelayLeg.Location = new System.Drawing.Point(80, 354);
            this.numericUpDownDelayLeg.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownDelayLeg.Name = "numericUpDownDelayLeg";
            this.numericUpDownDelayLeg.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownDelayLeg.TabIndex = 22;
            this.numericUpDownDelayLeg.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Delay :";
            // 
            // groupBoxSequence
            // 
            this.groupBoxSequence.Controls.Add(this.numericUpDownDelayTimer);
            this.groupBoxSequence.Controls.Add(this.label2);
            this.groupBoxSequence.Controls.Add(this.checkBoxRepeat);
            this.groupBoxSequence.Controls.Add(this.buttonStop);
            this.groupBoxSequence.Controls.Add(this.buttonStart);
            this.groupBoxSequence.Location = new System.Drawing.Point(6, 397);
            this.groupBoxSequence.Name = "groupBoxSequence";
            this.groupBoxSequence.Size = new System.Drawing.Size(293, 146);
            this.groupBoxSequence.TabIndex = 10;
            this.groupBoxSequence.TabStop = false;
            this.groupBoxSequence.Text = "Leg Sequence";
            // 
            // numericUpDownDelayTimer
            // 
            this.numericUpDownDelayTimer.Location = new System.Drawing.Point(154, 73);
            this.numericUpDownDelayTimer.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownDelayTimer.Name = "numericUpDownDelayTimer";
            this.numericUpDownDelayTimer.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownDelayTimer.TabIndex = 22;
            this.numericUpDownDelayTimer.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Delay :";
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Checked = true;
            this.checkBoxRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRepeat.Location = new System.Drawing.Point(111, 45);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(61, 17);
            this.checkBoxRepeat.TabIndex = 20;
            this.checkBoxRepeat.Text = "Repeat";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(12, 70);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 19;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 41);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 18;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxLeg
            // 
            this.groupBoxLeg.Controls.Add(this.labelTibia);
            this.groupBoxLeg.Controls.Add(this.labelFemur);
            this.groupBoxLeg.Controls.Add(this.labelCoxa);
            this.groupBoxLeg.Controls.Add(this.buttonWriteLeg);
            this.groupBoxLeg.Controls.Add(this.numericUpDownZ);
            this.groupBoxLeg.Controls.Add(this.labelPosZ);
            this.groupBoxLeg.Controls.Add(this.numericUpDownY);
            this.groupBoxLeg.Controls.Add(this.labelPosY);
            this.groupBoxLeg.Controls.Add(this.numericUpDownX);
            this.groupBoxLeg.Controls.Add(this.labelPosX);
            this.groupBoxLeg.Controls.Add(this.label1);
            this.groupBoxLeg.Controls.Add(this.numericUpDownLegId);
            this.groupBoxLeg.Location = new System.Drawing.Point(6, 228);
            this.groupBoxLeg.Name = "groupBoxLeg";
            this.groupBoxLeg.Size = new System.Drawing.Size(293, 163);
            this.groupBoxLeg.TabIndex = 9;
            this.groupBoxLeg.TabStop = false;
            this.groupBoxLeg.Text = "Control Leg";
            // 
            // labelTibia
            // 
            this.labelTibia.AutoSize = true;
            this.labelTibia.Location = new System.Drawing.Point(140, 102);
            this.labelTibia.Name = "labelTibia";
            this.labelTibia.Size = new System.Drawing.Size(32, 13);
            this.labelTibia.TabIndex = 20;
            this.labelTibia.Text = "tibia :";
            // 
            // labelFemur
            // 
            this.labelFemur.AutoSize = true;
            this.labelFemur.Location = new System.Drawing.Point(133, 78);
            this.labelFemur.Name = "labelFemur";
            this.labelFemur.Size = new System.Drawing.Size(39, 13);
            this.labelFemur.TabIndex = 19;
            this.labelFemur.Text = "femur :";
            // 
            // labelCoxa
            // 
            this.labelCoxa.AutoSize = true;
            this.labelCoxa.Location = new System.Drawing.Point(136, 55);
            this.labelCoxa.Name = "labelCoxa";
            this.labelCoxa.Size = new System.Drawing.Size(36, 13);
            this.labelCoxa.TabIndex = 18;
            this.labelCoxa.Text = "coxa :";
            // 
            // buttonWriteLeg
            // 
            this.buttonWriteLeg.Location = new System.Drawing.Point(212, 68);
            this.buttonWriteLeg.Name = "buttonWriteLeg";
            this.buttonWriteLeg.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteLeg.TabIndex = 17;
            this.buttonWriteLeg.Text = "Write";
            this.buttonWriteLeg.UseVisualStyleBackColor = true;
            this.buttonWriteLeg.Click += new System.EventHandler(this.buttonWriteLeg_Click);
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.Location = new System.Drawing.Point(74, 100);
            this.numericUpDownZ.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownZ.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownZ.TabIndex = 16;
            this.numericUpDownZ.ValueChanged += new System.EventHandler(this.numericUpDownXYZ_ValueChanged);
            // 
            // labelPosZ
            // 
            this.labelPosZ.AutoSize = true;
            this.labelPosZ.Location = new System.Drawing.Point(9, 102);
            this.labelPosZ.Name = "labelPosZ";
            this.labelPosZ.Size = new System.Drawing.Size(60, 13);
            this.labelPosZ.TabIndex = 15;
            this.labelPosZ.Text = "Position Z :";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(74, 76);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownY.TabIndex = 14;
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownXYZ_ValueChanged);
            // 
            // labelPosY
            // 
            this.labelPosY.AutoSize = true;
            this.labelPosY.Location = new System.Drawing.Point(9, 78);
            this.labelPosY.Name = "labelPosY";
            this.labelPosY.Size = new System.Drawing.Size(60, 13);
            this.labelPosY.TabIndex = 13;
            this.labelPosY.Text = "Position Y :";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(74, 53);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownX.TabIndex = 12;
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownXYZ_ValueChanged);
            // 
            // labelPosX
            // 
            this.labelPosX.AutoSize = true;
            this.labelPosX.Location = new System.Drawing.Point(9, 55);
            this.labelPosX.Name = "labelPosX";
            this.labelPosX.Size = new System.Drawing.Size(60, 13);
            this.labelPosX.TabIndex = 11;
            this.labelPosX.Text = "Position X :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Leg Id :";
            // 
            // numericUpDownLegId
            // 
            this.numericUpDownLegId.Location = new System.Drawing.Point(74, 26);
            this.numericUpDownLegId.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownLegId.Name = "numericUpDownLegId";
            this.numericUpDownLegId.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownLegId.TabIndex = 6;
            this.numericUpDownLegId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxVisualization
            // 
            this.groupBoxVisualization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxVisualization.Controls.Add(this.panelHexapod);
            this.groupBoxVisualization.Location = new System.Drawing.Point(604, 20);
            this.groupBoxVisualization.Name = "groupBoxVisualization";
            this.groupBoxVisualization.Size = new System.Drawing.Size(347, 401);
            this.groupBoxVisualization.TabIndex = 8;
            this.groupBoxVisualization.TabStop = false;
            this.groupBoxVisualization.Text = "Visualization";
            // 
            // panelHexapod
            // 
            this.panelHexapod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelHexapod.Location = new System.Drawing.Point(6, 19);
            this.panelHexapod.Name = "panelHexapod";
            this.panelHexapod.Size = new System.Drawing.Size(333, 376);
            this.panelHexapod.TabIndex = 0;
            this.panelHexapod.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHexapod_Paint);
            this.panelHexapod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelHexapod_MouseClick);
            // 
            // groupBoxLegs
            // 
            this.groupBoxLegs.Controls.Add(this.buttonDisableAll);
            this.groupBoxLegs.Controls.Add(this.buttonWriteAll);
            this.groupBoxLegs.Controls.Add(this.buttonReadAll);
            this.groupBoxLegs.Location = new System.Drawing.Point(6, 19);
            this.groupBoxLegs.Name = "groupBoxLegs";
            this.groupBoxLegs.Size = new System.Drawing.Size(293, 58);
            this.groupBoxLegs.TabIndex = 7;
            this.groupBoxLegs.TabStop = false;
            this.groupBoxLegs.Text = "Control Legs";
            // 
            // buttonDisableAll
            // 
            this.buttonDisableAll.Location = new System.Drawing.Point(109, 18);
            this.buttonDisableAll.Name = "buttonDisableAll";
            this.buttonDisableAll.Size = new System.Drawing.Size(75, 23);
            this.buttonDisableAll.TabIndex = 12;
            this.buttonDisableAll.Text = "DisableAll";
            this.buttonDisableAll.UseVisualStyleBackColor = true;
            this.buttonDisableAll.Click += new System.EventHandler(this.buttonDisableAll_Click);
            // 
            // buttonWriteAll
            // 
            this.buttonWriteAll.Location = new System.Drawing.Point(212, 19);
            this.buttonWriteAll.Name = "buttonWriteAll";
            this.buttonWriteAll.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteAll.TabIndex = 11;
            this.buttonWriteAll.Text = "WriteAll";
            this.buttonWriteAll.UseVisualStyleBackColor = true;
            this.buttonWriteAll.Click += new System.EventHandler(this.buttonWriteAll_Click);
            // 
            // buttonReadAll
            // 
            this.buttonReadAll.Location = new System.Drawing.Point(6, 19);
            this.buttonReadAll.Name = "buttonReadAll";
            this.buttonReadAll.Size = new System.Drawing.Size(75, 23);
            this.buttonReadAll.TabIndex = 10;
            this.buttonReadAll.Text = "ReadAll";
            this.buttonReadAll.UseVisualStyleBackColor = true;
            this.buttonReadAll.Click += new System.EventHandler(this.buttonReadAll_Click);
            // 
            // groupBoxControlLeg
            // 
            this.groupBoxControlLeg.Controls.Add(this.checkBoxEnableServo);
            this.groupBoxControlLeg.Controls.Add(this.numericUpDownServoPos);
            this.groupBoxControlLeg.Controls.Add(this.numericUpDownDelay);
            this.groupBoxControlLeg.Controls.Add(this.buttonWriteServo);
            this.groupBoxControlLeg.Controls.Add(this.buttonReadServo);
            this.groupBoxControlLeg.Controls.Add(this.labelDelay);
            this.groupBoxControlLeg.Controls.Add(this.labelPosition);
            this.groupBoxControlLeg.Controls.Add(this.labelServoId);
            this.groupBoxControlLeg.Controls.Add(this.numericUpDownServo);
            this.groupBoxControlLeg.Location = new System.Drawing.Point(6, 83);
            this.groupBoxControlLeg.Name = "groupBoxControlLeg";
            this.groupBoxControlLeg.Size = new System.Drawing.Size(293, 139);
            this.groupBoxControlLeg.TabIndex = 6;
            this.groupBoxControlLeg.TabStop = false;
            this.groupBoxControlLeg.Text = "Control Servo";
            // 
            // checkBoxEnableServo
            // 
            this.checkBoxEnableServo.AutoSize = true;
            this.checkBoxEnableServo.Location = new System.Drawing.Point(139, 106);
            this.checkBoxEnableServo.Name = "checkBoxEnableServo";
            this.checkBoxEnableServo.Size = new System.Drawing.Size(59, 17);
            this.checkBoxEnableServo.TabIndex = 11;
            this.checkBoxEnableServo.Text = "Enable";
            this.checkBoxEnableServo.UseVisualStyleBackColor = true;
            this.checkBoxEnableServo.CheckedChanged += new System.EventHandler(this.checkBoxEnableServo_CheckedChanged);
            // 
            // numericUpDownServoPos
            // 
            this.numericUpDownServoPos.Location = new System.Drawing.Point(71, 65);
            this.numericUpDownServoPos.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownServoPos.Name = "numericUpDownServoPos";
            this.numericUpDownServoPos.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownServoPos.TabIndex = 10;
            this.numericUpDownServoPos.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Location = new System.Drawing.Point(71, 105);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownDelay.TabIndex = 9;
            // 
            // buttonWriteServo
            // 
            this.buttonWriteServo.Location = new System.Drawing.Point(212, 74);
            this.buttonWriteServo.Name = "buttonWriteServo";
            this.buttonWriteServo.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteServo.TabIndex = 1;
            this.buttonWriteServo.Text = "Write";
            this.buttonWriteServo.UseVisualStyleBackColor = true;
            this.buttonWriteServo.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonReadServo
            // 
            this.buttonReadServo.Location = new System.Drawing.Point(212, 45);
            this.buttonReadServo.Name = "buttonReadServo";
            this.buttonReadServo.Size = new System.Drawing.Size(75, 23);
            this.buttonReadServo.TabIndex = 0;
            this.buttonReadServo.Text = "Read";
            this.buttonReadServo.UseVisualStyleBackColor = true;
            this.buttonReadServo.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(9, 107);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(40, 13);
            this.labelDelay.TabIndex = 7;
            this.labelDelay.Text = "Delay :";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(9, 67);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(50, 13);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "Position :";
            // 
            // labelServoId
            // 
            this.labelServoId.AutoSize = true;
            this.labelServoId.Location = new System.Drawing.Point(9, 24);
            this.labelServoId.Name = "labelServoId";
            this.labelServoId.Size = new System.Drawing.Size(53, 13);
            this.labelServoId.TabIndex = 5;
            this.labelServoId.Text = "Servo Id :";
            // 
            // numericUpDownServo
            // 
            this.numericUpDownServo.Location = new System.Drawing.Point(71, 22);
            this.numericUpDownServo.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownServo.Name = "numericUpDownServo";
            this.numericUpDownServo.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownServo.TabIndex = 3;
            this.numericUpDownServo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownServo.ValueChanged += new System.EventHandler(this.numericUpDownServo_ValueChanged);
            // 
            // groupBoxCommunication
            // 
            this.groupBoxCommunication.Controls.Add(this.comboBoxPortCom);
            this.groupBoxCommunication.Controls.Add(this.buttonConnect);
            this.groupBoxCommunication.Location = new System.Drawing.Point(8, 12);
            this.groupBoxCommunication.Name = "groupBoxCommunication";
            this.groupBoxCommunication.Size = new System.Drawing.Size(105, 78);
            this.groupBoxCommunication.TabIndex = 3;
            this.groupBoxCommunication.TabStop = false;
            this.groupBoxCommunication.Text = "Communication";
            // 
            // comboBoxPortCom
            // 
            this.comboBoxPortCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPortCom.FormattingEnabled = true;
            this.comboBoxPortCom.Location = new System.Drawing.Point(10, 19);
            this.comboBoxPortCom.Name = "comboBoxPortCom";
            this.comboBoxPortCom.Size = new System.Drawing.Size(89, 21);
            this.comboBoxPortCom.TabIndex = 1;
            // 
            // timerLegSequence
            // 
            this.timerLegSequence.Interval = 1000;
            this.timerLegSequence.Tick += new System.EventHandler(this.timerLegSequence_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1093, 611);
            this.Controls.Add(this.groupBoxCommunication);
            this.Controls.Add(this.groupBoxHexapod);
            this.Controls.Add(this.toolStripStatus);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Control Hexapod (v0.1)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStripStatus.ResumeLayout(false);
            this.toolStripStatus.PerformLayout();
            this.groupBoxHexapod.ResumeLayout(false);
            this.groupBoxHexapod.PerformLayout();
            this.groupBoxBodyWalk.ResumeLayout(false);
            this.groupBoxBodyWalk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.groupBoxControlBody.ResumeLayout(false);
            this.groupBoxControlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBodyDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBodyZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBodyY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBodyX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayLeg)).EndInit();
            this.groupBoxSequence.ResumeLayout(false);
            this.groupBoxSequence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayTimer)).EndInit();
            this.groupBoxLeg.ResumeLayout(false);
            this.groupBoxLeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLegId)).EndInit();
            this.groupBoxVisualization.ResumeLayout(false);
            this.groupBoxLegs.ResumeLayout(false);
            this.groupBoxControlLeg.ResumeLayout(false);
            this.groupBoxControlLeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownServoPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownServo)).EndInit();
            this.groupBoxCommunication.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ToolStrip toolStripStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabelConnectStatus;
        private System.Windows.Forms.GroupBox groupBoxHexapod;
        private System.Windows.Forms.GroupBox groupBoxCommunication;
        private System.Windows.Forms.ComboBox comboBoxPortCom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelLiveStream;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button buttonReadServo;
        private System.Windows.Forms.ToolStripComboBox toolStripLabelStream;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFifoCount;
        private System.Windows.Forms.GroupBox groupBoxControlLeg;
        private System.Windows.Forms.Label labelServoId;
        private System.Windows.Forms.Button buttonWriteServo;
        private System.Windows.Forms.NumericUpDown numericUpDownServo;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.GroupBox groupBoxLegs;
        private System.Windows.Forms.Button buttonReadAll;
        private System.Windows.Forms.GroupBox groupBoxVisualization;
        private System.Windows.Forms.Panel panelHexapod;
        private System.Windows.Forms.NumericUpDown numericUpDownServoPos;
        private System.Windows.Forms.GroupBox groupBoxLeg;
        private System.Windows.Forms.Button buttonWriteLeg;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.Label labelPosZ;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label labelPosY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label labelPosX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownLegId;
        private System.Windows.Forms.Button buttonWriteAll;
        private System.Windows.Forms.Label labelTibia;
        private System.Windows.Forms.Label labelFemur;
        private System.Windows.Forms.Label labelCoxa;
        private System.Windows.Forms.GroupBox groupBoxSequence;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerLegSequence;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.NumericUpDown numericUpDownDelayTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownDelayLeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxControlBody;
        private System.Windows.Forms.Button buttonStraight;
        private System.Windows.Forms.Button buttonStar;
        private System.Windows.Forms.GroupBox groupBoxBodyWalk;
        private System.Windows.Forms.Button buttonMoveBW;
        private System.Windows.Forms.Button buttonMoveFW;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownBodyZ;
        private System.Windows.Forms.NumericUpDown numericUpDownBodyY;
        private System.Windows.Forms.NumericUpDown numericUpDownBodyX;
        private System.Windows.Forms.NumericUpDown numericUpDownBodyDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStopp;
        private System.Windows.Forms.Button buttonTripod;
        private System.Windows.Forms.Button buttonRipple;
        private System.Windows.Forms.Button buttonWave;
        private System.Windows.Forms.CheckBox checkBoxEnableServo;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.Button buttonDisableAll;
    }
}

