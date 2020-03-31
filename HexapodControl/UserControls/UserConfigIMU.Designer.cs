namespace HexapodControl
{
    partial class UserConfigIMU
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
            this.labelThreshold = new System.Windows.Forms.Label();
            this.groupBoxImu = new System.Windows.Forms.GroupBox();
            this.contextMenuStripRead = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelYaw = new System.Windows.Forms.Label();
            this.labelPitch = new System.Windows.Forms.Label();
            this.labelRoll = new System.Windows.Forms.Label();
            this.groupBoxImu.SuspendLayout();
            this.contextMenuStripRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.ForeColor = System.Drawing.Color.White;
            this.labelThreshold.Location = new System.Drawing.Point(6, 25);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(60, 13);
            this.labelThreshold.TabIndex = 18;
            this.labelThreshold.Text = "Threshold :";
            // 
            // groupBoxImu
            // 
            this.groupBoxImu.ContextMenuStrip = this.contextMenuStripRead;
            this.groupBoxImu.Controls.Add(this.labelYaw);
            this.groupBoxImu.Controls.Add(this.labelPitch);
            this.groupBoxImu.Controls.Add(this.labelRoll);
            this.groupBoxImu.Controls.Add(this.labelThreshold);
            this.groupBoxImu.ForeColor = System.Drawing.Color.White;
            this.groupBoxImu.Location = new System.Drawing.Point(3, 3);
            this.groupBoxImu.Name = "groupBoxImu";
            this.groupBoxImu.Size = new System.Drawing.Size(194, 194);
            this.groupBoxImu.TabIndex = 19;
            this.groupBoxImu.TabStop = false;
            this.groupBoxImu.Text = "IMU";
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
            // labelYaw
            // 
            this.labelYaw.AutoSize = true;
            this.labelYaw.ForeColor = System.Drawing.Color.White;
            this.labelYaw.Location = new System.Drawing.Point(6, 96);
            this.labelYaw.Name = "labelYaw";
            this.labelYaw.Size = new System.Drawing.Size(34, 13);
            this.labelYaw.TabIndex = 21;
            this.labelYaw.Text = "Yaw :";
            // 
            // labelPitch
            // 
            this.labelPitch.AutoSize = true;
            this.labelPitch.ForeColor = System.Drawing.Color.White;
            this.labelPitch.Location = new System.Drawing.Point(6, 74);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.Size = new System.Drawing.Size(37, 13);
            this.labelPitch.TabIndex = 20;
            this.labelPitch.Text = "Pitch :";
            // 
            // labelRoll
            // 
            this.labelRoll.AutoSize = true;
            this.labelRoll.ForeColor = System.Drawing.Color.White;
            this.labelRoll.Location = new System.Drawing.Point(6, 51);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(31, 13);
            this.labelRoll.TabIndex = 19;
            this.labelRoll.Text = "Roll :";
            // 
            // UserConfigIMU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.groupBoxImu);
            this.Name = "UserConfigIMU";
            this.Size = new System.Drawing.Size(200, 200);
            this.groupBoxImu.ResumeLayout(false);
            this.groupBoxImu.PerformLayout();
            this.contextMenuStripRead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.GroupBox groupBoxImu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRead;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.Label labelYaw;
        private System.Windows.Forms.Label labelPitch;
        private System.Windows.Forms.Label labelRoll;
    }
}
