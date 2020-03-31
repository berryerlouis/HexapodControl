namespace HexapodControl
{
    partial class UserConfigBody
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
            this.groupBoxBody = new System.Windows.Forms.GroupBox();
            this.contextMenuStripRead = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBodyStraight = new System.Windows.Forms.Button();
            this.buttonBodyStar = new System.Windows.Forms.Button();
            this.buttonBodyStop = new System.Windows.Forms.Button();
            this.labelServoDelay = new System.Windows.Forms.Label();
            this.textBoxServoDelay = new System.Windows.Forms.TextBox();
            this.groupBoxBody.SuspendLayout();
            this.contextMenuStripRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBody
            // 
            this.groupBoxBody.Controls.Add(this.labelServoDelay);
            this.groupBoxBody.Controls.Add(this.textBoxServoDelay);
            this.groupBoxBody.Controls.Add(this.buttonBodyStraight);
            this.groupBoxBody.Controls.Add(this.buttonBodyStar);
            this.groupBoxBody.Controls.Add(this.buttonBodyStop);
            this.groupBoxBody.ForeColor = System.Drawing.Color.White;
            this.groupBoxBody.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBody.Name = "groupBoxBody";
            this.groupBoxBody.Size = new System.Drawing.Size(194, 194);
            this.groupBoxBody.TabIndex = 19;
            this.groupBoxBody.TabStop = false;
            this.groupBoxBody.Text = "Body";
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
            // 
            // buttonBodyStraight
            // 
            this.buttonBodyStraight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBodyStraight.Location = new System.Drawing.Point(130, 35);
            this.buttonBodyStraight.Name = "buttonBodyStraight";
            this.buttonBodyStraight.Size = new System.Drawing.Size(53, 42);
            this.buttonBodyStraight.TabIndex = 24;
            this.buttonBodyStraight.Text = "Straight";
            this.buttonBodyStraight.UseVisualStyleBackColor = true;
            this.buttonBodyStraight.Click += new System.EventHandler(this.buttonBodyStraight_Click);
            // 
            // buttonBodyStar
            // 
            this.buttonBodyStar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBodyStar.Location = new System.Drawing.Point(72, 35);
            this.buttonBodyStar.Name = "buttonBodyStar";
            this.buttonBodyStar.Size = new System.Drawing.Size(53, 42);
            this.buttonBodyStar.TabIndex = 23;
            this.buttonBodyStar.Text = "Star";
            this.buttonBodyStar.UseVisualStyleBackColor = true;
            this.buttonBodyStar.Click += new System.EventHandler(this.buttonBodyStar_Click);
            // 
            // buttonBodyStop
            // 
            this.buttonBodyStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBodyStop.Location = new System.Drawing.Point(14, 35);
            this.buttonBodyStop.Name = "buttonBodyStop";
            this.buttonBodyStop.Size = new System.Drawing.Size(53, 42);
            this.buttonBodyStop.TabIndex = 22;
            this.buttonBodyStop.Text = "Stop";
            this.buttonBodyStop.UseVisualStyleBackColor = true;
            this.buttonBodyStop.Click += new System.EventHandler(this.buttonBodyStop_Click);
            // 
            // labelServoDelay
            // 
            this.labelServoDelay.AutoSize = true;
            this.labelServoDelay.ForeColor = System.Drawing.Color.White;
            this.labelServoDelay.Location = new System.Drawing.Point(34, 97);
            this.labelServoDelay.Name = "labelServoDelay";
            this.labelServoDelay.Size = new System.Drawing.Size(40, 13);
            this.labelServoDelay.TabIndex = 26;
            this.labelServoDelay.Text = "Delay :";
            // 
            // textBoxServoDelay
            // 
            this.textBoxServoDelay.AcceptsReturn = true;
            this.textBoxServoDelay.AcceptsTab = true;
            this.textBoxServoDelay.Location = new System.Drawing.Point(89, 94);
            this.textBoxServoDelay.Name = "textBoxServoDelay";
            this.textBoxServoDelay.Size = new System.Drawing.Size(36, 20);
            this.textBoxServoDelay.TabIndex = 25;
            this.textBoxServoDelay.Text = "500";
            // 
            // UserConfigBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.groupBoxBody);
            this.Name = "UserConfigBody";
            this.Size = new System.Drawing.Size(200, 200);
            this.groupBoxBody.ResumeLayout(false);
            this.groupBoxBody.PerformLayout();
            this.contextMenuStripRead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxBody;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRead;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.Button buttonBodyStraight;
        private System.Windows.Forms.Button buttonBodyStar;
        private System.Windows.Forms.Button buttonBodyStop;
        private System.Windows.Forms.Label labelServoDelay;
        private System.Windows.Forms.TextBox textBoxServoDelay;
    }
}
