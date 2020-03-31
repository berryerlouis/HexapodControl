namespace HexapodControl
{
    partial class UserConfigUltrason
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
            this.groupBoxUltrason = new System.Windows.Forms.GroupBox();
            this.contextMenuStripRead = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.groupBoxUltrason.SuspendLayout();
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
            // groupBoxUltrason
            // 
            this.groupBoxUltrason.ContextMenuStrip = this.contextMenuStripRead;
            this.groupBoxUltrason.Controls.Add(this.labelRight);
            this.groupBoxUltrason.Controls.Add(this.labelLeft);
            this.groupBoxUltrason.Controls.Add(this.labelThreshold);
            this.groupBoxUltrason.ForeColor = System.Drawing.Color.White;
            this.groupBoxUltrason.Location = new System.Drawing.Point(3, 3);
            this.groupBoxUltrason.Name = "groupBoxUltrason";
            this.groupBoxUltrason.Size = new System.Drawing.Size(194, 194);
            this.groupBoxUltrason.TabIndex = 19;
            this.groupBoxUltrason.TabStop = false;
            this.groupBoxUltrason.Text = "Ultrason";
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
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.ForeColor = System.Drawing.Color.White;
            this.labelRight.Location = new System.Drawing.Point(100, 51);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(38, 13);
            this.labelRight.TabIndex = 20;
            this.labelRight.Text = "Right :";
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.ForeColor = System.Drawing.Color.White;
            this.labelLeft.Location = new System.Drawing.Point(6, 51);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(31, 13);
            this.labelLeft.TabIndex = 19;
            this.labelLeft.Text = "Left :";
            // 
            // UserConfigUltrason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.groupBoxUltrason);
            this.Name = "UserConfigUltrason";
            this.Size = new System.Drawing.Size(200, 200);
            this.groupBoxUltrason.ResumeLayout(false);
            this.groupBoxUltrason.PerformLayout();
            this.contextMenuStripRead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.GroupBox groupBoxUltrason;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRead;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelLeft;
    }
}
