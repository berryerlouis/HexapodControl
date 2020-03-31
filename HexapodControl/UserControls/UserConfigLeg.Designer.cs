namespace HexapodControl
{
    partial class UserConfigLeg
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
            this.groupBoxLeg = new System.Windows.Forms.GroupBox();
            this.panelLeg = new System.Windows.Forms.Panel();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelLegId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxLegId = new System.Windows.Forms.TextBox();
            this.labelLegDelay = new System.Windows.Forms.Label();
            this.textBoxBehaviorDelay = new System.Windows.Forms.TextBox();
            this.contextMenuStripRead = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxLeg.SuspendLayout();
            this.contextMenuStripRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLeg
            // 
            this.groupBoxLeg.ContextMenuStrip = this.contextMenuStripRead;
            this.groupBoxLeg.Controls.Add(this.panelLeg);
            this.groupBoxLeg.Controls.Add(this.labelZ);
            this.groupBoxLeg.Controls.Add(this.labelY);
            this.groupBoxLeg.Controls.Add(this.labelX);
            this.groupBoxLeg.Controls.Add(this.labelLegId);
            this.groupBoxLeg.Controls.Add(this.button1);
            this.groupBoxLeg.Controls.Add(this.textBoxZ);
            this.groupBoxLeg.Controls.Add(this.textBoxY);
            this.groupBoxLeg.Controls.Add(this.textBoxX);
            this.groupBoxLeg.Controls.Add(this.textBoxLegId);
            this.groupBoxLeg.Controls.Add(this.labelLegDelay);
            this.groupBoxLeg.Controls.Add(this.textBoxBehaviorDelay);
            this.groupBoxLeg.ForeColor = System.Drawing.Color.White;
            this.groupBoxLeg.Location = new System.Drawing.Point(3, 3);
            this.groupBoxLeg.Name = "groupBoxLeg";
            this.groupBoxLeg.Size = new System.Drawing.Size(194, 194);
            this.groupBoxLeg.TabIndex = 19;
            this.groupBoxLeg.TabStop = false;
            this.groupBoxLeg.Text = "Leg";
            // 
            // panelLeg
            // 
            this.panelLeg.Location = new System.Drawing.Point(7, 88);
            this.panelLeg.Name = "panelLeg";
            this.panelLeg.Size = new System.Drawing.Size(181, 100);
            this.panelLeg.TabIndex = 36;
            this.panelLeg.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeg_Paint);
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(106, 43);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(14, 13);
            this.labelZ.TabIndex = 35;
            this.labelZ.Text = "Z";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(77, 43);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 34;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(48, 43);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 33;
            this.labelX.Text = "X";
            // 
            // labelLegId
            // 
            this.labelLegId.AutoSize = true;
            this.labelLegId.Location = new System.Drawing.Point(4, 43);
            this.labelLegId.Name = "labelLegId";
            this.labelLegId.Size = new System.Drawing.Size(34, 13);
            this.labelLegId.TabIndex = 32;
            this.labelLegId.Text = "LegId";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(126, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 20);
            this.button1.TabIndex = 31;
            this.button1.Text = "Write";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // textBoxZ
            // 
            this.textBoxZ.AcceptsReturn = true;
            this.textBoxZ.AcceptsTab = true;
            this.textBoxZ.Location = new System.Drawing.Point(97, 59);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(23, 20);
            this.textBoxZ.TabIndex = 30;
            this.textBoxZ.Text = "00";
            // 
            // textBoxY
            // 
            this.textBoxY.AcceptsReturn = true;
            this.textBoxY.AcceptsTab = true;
            this.textBoxY.Location = new System.Drawing.Point(68, 59);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(23, 20);
            this.textBoxY.TabIndex = 29;
            this.textBoxY.Text = "00";
            // 
            // textBoxX
            // 
            this.textBoxX.AcceptsReturn = true;
            this.textBoxX.AcceptsTab = true;
            this.textBoxX.Location = new System.Drawing.Point(39, 59);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(23, 20);
            this.textBoxX.TabIndex = 28;
            this.textBoxX.Text = "00";
            // 
            // textBoxLegId
            // 
            this.textBoxLegId.AcceptsReturn = true;
            this.textBoxLegId.AcceptsTab = true;
            this.textBoxLegId.Location = new System.Drawing.Point(10, 59);
            this.textBoxLegId.Name = "textBoxLegId";
            this.textBoxLegId.Size = new System.Drawing.Size(23, 20);
            this.textBoxLegId.TabIndex = 27;
            this.textBoxLegId.Text = "00";
            // 
            // labelLegDelay
            // 
            this.labelLegDelay.AutoSize = true;
            this.labelLegDelay.ForeColor = System.Drawing.Color.White;
            this.labelLegDelay.Location = new System.Drawing.Point(9, 22);
            this.labelLegDelay.Name = "labelLegDelay";
            this.labelLegDelay.Size = new System.Drawing.Size(40, 13);
            this.labelLegDelay.TabIndex = 26;
            this.labelLegDelay.Text = "Delay :";
            // 
            // textBoxBehaviorDelay
            // 
            this.textBoxBehaviorDelay.AcceptsReturn = true;
            this.textBoxBehaviorDelay.AcceptsTab = true;
            this.textBoxBehaviorDelay.Location = new System.Drawing.Point(64, 19);
            this.textBoxBehaviorDelay.Name = "textBoxBehaviorDelay";
            this.textBoxBehaviorDelay.Size = new System.Drawing.Size(36, 20);
            this.textBoxBehaviorDelay.TabIndex = 25;
            this.textBoxBehaviorDelay.Text = "500";
            // 
            // contextMenuStripRead
            // 
            this.contextMenuStripRead.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem});
            this.contextMenuStripRead.Name = "contextMenuStripRead";
            this.contextMenuStripRead.Size = new System.Drawing.Size(181, 48);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // UserConfigLeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.groupBoxLeg);
            this.Name = "UserConfigLeg";
            this.Size = new System.Drawing.Size(200, 200);
            this.groupBoxLeg.ResumeLayout(false);
            this.groupBoxLeg.PerformLayout();
            this.contextMenuStripRead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxLeg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRead;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.Label labelLegDelay;
        private System.Windows.Forms.TextBox textBoxBehaviorDelay;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxLegId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelLegId;
        private System.Windows.Forms.Panel panelLeg;
    }
}
