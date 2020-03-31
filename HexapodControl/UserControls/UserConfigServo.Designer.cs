namespace HexapodControl
{
    partial class UserConfigServo
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxServo = new System.Windows.Forms.GroupBox();
            this.contextMenuStripRead = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelServoDelay = new System.Windows.Forms.Label();
            this.labelServoWritePosition = new System.Windows.Forms.Label();
            this.textBoxServoDelay = new System.Windows.Forms.TextBox();
            this.textBoxServoPosition = new System.Windows.Forms.TextBox();
            this.buttonServoWrite = new System.Windows.Forms.Button();
            this.checkBoxEnable = new System.Windows.Forms.CheckBox();
            this.trackBarPosition = new System.Windows.Forms.TrackBar();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.groupBoxServo.SuspendLayout();
            this.contextMenuStripRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxServo
            // 
            this.groupBoxServo.ContextMenuStrip = this.contextMenuStripRead;
            this.groupBoxServo.Controls.Add(this.labelServoDelay);
            this.groupBoxServo.Controls.Add(this.labelServoWritePosition);
            this.groupBoxServo.Controls.Add(this.textBoxServoDelay);
            this.groupBoxServo.Controls.Add(this.textBoxServoPosition);
            this.groupBoxServo.Controls.Add(this.buttonServoWrite);
            this.groupBoxServo.Controls.Add(this.checkBoxEnable);
            this.groupBoxServo.Controls.Add(this.trackBarPosition);
            this.groupBoxServo.Controls.Add(this.labelMax);
            this.groupBoxServo.Controls.Add(this.labelMin);
            this.groupBoxServo.Controls.Add(this.labelPosition);
            this.groupBoxServo.ForeColor = System.Drawing.Color.White;
            this.groupBoxServo.Location = new System.Drawing.Point(3, 3);
            this.groupBoxServo.Name = "groupBoxServo";
            this.groupBoxServo.Size = new System.Drawing.Size(194, 194);
            this.groupBoxServo.TabIndex = 19;
            this.groupBoxServo.TabStop = false;
            this.groupBoxServo.Text = "SERVO : 00";
            // 
            // contextMenuStripRead
            // 
            this.contextMenuStripRead.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem});
            this.contextMenuStripRead.Name = "contextMenuStripRead";
            this.contextMenuStripRead.Size = new System.Drawing.Size(101, 26);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // labelServoDelay
            // 
            this.labelServoDelay.AutoSize = true;
            this.labelServoDelay.ForeColor = System.Drawing.Color.White;
            this.labelServoDelay.Location = new System.Drawing.Point(15, 156);
            this.labelServoDelay.Name = "labelServoDelay";
            this.labelServoDelay.Size = new System.Drawing.Size(40, 13);
            this.labelServoDelay.TabIndex = 21;
            this.labelServoDelay.Text = "Delay :";
            // 
            // labelServoWritePosition
            // 
            this.labelServoWritePosition.AutoSize = true;
            this.labelServoWritePosition.ForeColor = System.Drawing.Color.White;
            this.labelServoWritePosition.Location = new System.Drawing.Point(15, 134);
            this.labelServoWritePosition.Name = "labelServoWritePosition";
            this.labelServoWritePosition.Size = new System.Drawing.Size(50, 13);
            this.labelServoWritePosition.TabIndex = 20;
            this.labelServoWritePosition.Text = "Position :";
            // 
            // textBoxServoDelay
            // 
            this.textBoxServoDelay.AcceptsReturn = true;
            this.textBoxServoDelay.AcceptsTab = true;
            this.textBoxServoDelay.Location = new System.Drawing.Point(70, 153);
            this.textBoxServoDelay.Name = "textBoxServoDelay";
            this.textBoxServoDelay.Size = new System.Drawing.Size(36, 20);
            this.textBoxServoDelay.TabIndex = 19;
            this.textBoxServoDelay.Text = "0";
            // 
            // textBoxServoPosition
            // 
            this.textBoxServoPosition.AcceptsReturn = true;
            this.textBoxServoPosition.AcceptsTab = true;
            this.textBoxServoPosition.Location = new System.Drawing.Point(70, 131);
            this.textBoxServoPosition.Name = "textBoxServoPosition";
            this.textBoxServoPosition.Size = new System.Drawing.Size(23, 20);
            this.textBoxServoPosition.TabIndex = 18;
            this.textBoxServoPosition.Text = "90";
            // 
            // buttonServoWrite
            // 
            this.buttonServoWrite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonServoWrite.Location = new System.Drawing.Point(113, 131);
            this.buttonServoWrite.Name = "buttonServoWrite";
            this.buttonServoWrite.Size = new System.Drawing.Size(53, 42);
            this.buttonServoWrite.TabIndex = 17;
            this.buttonServoWrite.Text = "Write";
            this.buttonServoWrite.UseVisualStyleBackColor = true;
            this.buttonServoWrite.Click += new System.EventHandler(this.buttonServoWrite_Click);
            // 
            // checkBoxEnable
            // 
            this.checkBoxEnable.AutoSize = true;
            this.checkBoxEnable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEnable.Checked = true;
            this.checkBoxEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnable.ForeColor = System.Drawing.Color.White;
            this.checkBoxEnable.Location = new System.Drawing.Point(129, 28);
            this.checkBoxEnable.Name = "checkBoxEnable";
            this.checkBoxEnable.Size = new System.Drawing.Size(59, 17);
            this.checkBoxEnable.TabIndex = 15;
            this.checkBoxEnable.Text = "Enable";
            this.checkBoxEnable.UseVisualStyleBackColor = true;
            this.checkBoxEnable.Enabled = false;
            // 
            // trackBarPosition
            // 
            this.trackBarPosition.Enabled = false;
            this.trackBarPosition.Location = new System.Drawing.Point(9, 89);
            this.trackBarPosition.Maximum = 180;
            this.trackBarPosition.Name = "trackBarPosition";
            this.trackBarPosition.Size = new System.Drawing.Size(179, 45);
            this.trackBarPosition.TabIndex = 14;
            this.trackBarPosition.TickFrequency = 10;
            this.trackBarPosition.Value = 90;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.ForeColor = System.Drawing.Color.White;
            this.labelMax.Location = new System.Drawing.Point(6, 73);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(33, 13);
            this.labelMax.TabIndex = 13;
            this.labelMax.Text = "Max :";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.ForeColor = System.Drawing.Color.White;
            this.labelMin.Location = new System.Drawing.Point(6, 51);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(30, 13);
            this.labelMin.TabIndex = 12;
            this.labelMin.Text = "Min :";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.ForeColor = System.Drawing.Color.White;
            this.labelPosition.Location = new System.Drawing.Point(6, 29);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(50, 13);
            this.labelPosition.TabIndex = 11;
            this.labelPosition.Text = "Position :";
            // 
            // UserConfigServo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.groupBoxServo);
            this.Name = "UserConfigServo";
            this.Size = new System.Drawing.Size(200, 200);
            this.groupBoxServo.ResumeLayout(false);
            this.groupBoxServo.PerformLayout();
            this.contextMenuStripRead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxServo;
        private System.Windows.Forms.Label labelServoDelay;
        private System.Windows.Forms.Label labelServoWritePosition;
        private System.Windows.Forms.TextBox textBoxServoDelay;
        private System.Windows.Forms.TextBox textBoxServoPosition;
        private System.Windows.Forms.Button buttonServoWrite;
        private System.Windows.Forms.CheckBox checkBoxEnable;
        private System.Windows.Forms.TrackBar trackBarPosition;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRead;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
    }
}
