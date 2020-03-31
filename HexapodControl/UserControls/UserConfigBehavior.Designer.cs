namespace HexapodControl
{
    partial class UserConfigBehavior
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
            this.groupBoxBehavior = new System.Windows.Forms.GroupBox();
            this.contextMenuStripRead = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPosY = new System.Windows.Forms.TextBox();
            this.textBoxPosX = new System.Windows.Forms.TextBox();
            this.textBoxBehaviorPosition = new System.Windows.Forms.TextBox();
            this.labelBehaviorDelay = new System.Windows.Forms.Label();
            this.textBoxBehaviorDelay = new System.Windows.Forms.TextBox();
            this.labelBehaviorElevation = new System.Windows.Forms.Label();
            this.buttonBehaviorWrite = new System.Windows.Forms.Button();
            this.groupBoxBehavior.SuspendLayout();
            this.contextMenuStripRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBehavior
            // 
            this.groupBoxBehavior.ContextMenuStrip = this.contextMenuStripRead;
            this.groupBoxBehavior.Controls.Add(this.button2);
            this.groupBoxBehavior.Controls.Add(this.label1);
            this.groupBoxBehavior.Controls.Add(this.label2);
            this.groupBoxBehavior.Controls.Add(this.textBoxPosY);
            this.groupBoxBehavior.Controls.Add(this.textBoxPosX);
            this.groupBoxBehavior.Controls.Add(this.textBoxBehaviorPosition);
            this.groupBoxBehavior.Controls.Add(this.labelBehaviorDelay);
            this.groupBoxBehavior.Controls.Add(this.textBoxBehaviorDelay);
            this.groupBoxBehavior.Controls.Add(this.labelBehaviorElevation);
            this.groupBoxBehavior.Controls.Add(this.buttonBehaviorWrite);
            this.groupBoxBehavior.ForeColor = System.Drawing.Color.White;
            this.groupBoxBehavior.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBehavior.Name = "groupBoxBehavior";
            this.groupBoxBehavior.Size = new System.Drawing.Size(194, 194);
            this.groupBoxBehavior.TabIndex = 19;
            this.groupBoxBehavior.TabStop = false;
            this.groupBoxBehavior.Text = "Behavior";
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
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(108, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 20);
            this.button2.TabIndex = 40;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "X";
            // 
            // textBoxPosY
            // 
            this.textBoxPosY.AcceptsReturn = true;
            this.textBoxPosY.AcceptsTab = true;
            this.textBoxPosY.Location = new System.Drawing.Point(56, 114);
            this.textBoxPosY.Name = "textBoxPosY";
            this.textBoxPosY.Size = new System.Drawing.Size(23, 20);
            this.textBoxPosY.TabIndex = 37;
            this.textBoxPosY.Text = "00";
            // 
            // textBoxPosX
            // 
            this.textBoxPosX.AcceptsReturn = true;
            this.textBoxPosX.AcceptsTab = true;
            this.textBoxPosX.Location = new System.Drawing.Point(27, 114);
            this.textBoxPosX.Name = "textBoxPosX";
            this.textBoxPosX.Size = new System.Drawing.Size(23, 20);
            this.textBoxPosX.TabIndex = 36;
            this.textBoxPosX.Text = "00";
            // 
            // textBoxBehaviorPosition
            // 
            this.textBoxBehaviorPosition.AcceptsReturn = true;
            this.textBoxBehaviorPosition.AcceptsTab = true;
            this.textBoxBehaviorPosition.Location = new System.Drawing.Point(64, 24);
            this.textBoxBehaviorPosition.Name = "textBoxBehaviorPosition";
            this.textBoxBehaviorPosition.Size = new System.Drawing.Size(23, 20);
            this.textBoxBehaviorPosition.TabIndex = 23;
            this.textBoxBehaviorPosition.Text = "00";
            // 
            // labelBehaviorDelay
            // 
            this.labelBehaviorDelay.AutoSize = true;
            this.labelBehaviorDelay.ForeColor = System.Drawing.Color.White;
            this.labelBehaviorDelay.Location = new System.Drawing.Point(9, 53);
            this.labelBehaviorDelay.Name = "labelBehaviorDelay";
            this.labelBehaviorDelay.Size = new System.Drawing.Size(40, 13);
            this.labelBehaviorDelay.TabIndex = 26;
            this.labelBehaviorDelay.Text = "Delay :";
            // 
            // textBoxBehaviorDelay
            // 
            this.textBoxBehaviorDelay.AcceptsReturn = true;
            this.textBoxBehaviorDelay.AcceptsTab = true;
            this.textBoxBehaviorDelay.Location = new System.Drawing.Point(64, 50);
            this.textBoxBehaviorDelay.Name = "textBoxBehaviorDelay";
            this.textBoxBehaviorDelay.Size = new System.Drawing.Size(36, 20);
            this.textBoxBehaviorDelay.TabIndex = 25;
            this.textBoxBehaviorDelay.Text = "500";
            // 
            // labelBehaviorElevation
            // 
            this.labelBehaviorElevation.AutoSize = true;
            this.labelBehaviorElevation.ForeColor = System.Drawing.Color.White;
            this.labelBehaviorElevation.Location = new System.Drawing.Point(9, 27);
            this.labelBehaviorElevation.Name = "labelBehaviorElevation";
            this.labelBehaviorElevation.Size = new System.Drawing.Size(60, 13);
            this.labelBehaviorElevation.TabIndex = 24;
            this.labelBehaviorElevation.Text = "Elevation : ";
            // 
            // buttonBehaviorWrite
            // 
            this.buttonBehaviorWrite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBehaviorWrite.Location = new System.Drawing.Point(122, 28);
            this.buttonBehaviorWrite.Name = "buttonBehaviorWrite";
            this.buttonBehaviorWrite.Size = new System.Drawing.Size(53, 42);
            this.buttonBehaviorWrite.TabIndex = 22;
            this.buttonBehaviorWrite.Text = "Write";
            this.buttonBehaviorWrite.UseVisualStyleBackColor = true;
            this.buttonBehaviorWrite.Click += new System.EventHandler(this.buttonBehaviorWrite_Click);
            // 
            // UserConfigBehavior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.groupBoxBehavior);
            this.Name = "UserConfigBehavior";
            this.Size = new System.Drawing.Size(200, 200);
            this.groupBoxBehavior.ResumeLayout(false);
            this.groupBoxBehavior.PerformLayout();
            this.contextMenuStripRead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxBehavior;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRead;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.Label labelBehaviorElevation;
        private System.Windows.Forms.TextBox textBoxBehaviorPosition;
        private System.Windows.Forms.Button buttonBehaviorWrite;
        private System.Windows.Forms.Label labelBehaviorDelay;
        private System.Windows.Forms.TextBox textBoxBehaviorDelay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPosY;
        private System.Windows.Forms.TextBox textBoxPosX;
    }
}
