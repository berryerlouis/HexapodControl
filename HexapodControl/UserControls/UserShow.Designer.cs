namespace HexapodControl
{
    partial class UserShow
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
            this.panelViewRobot = new HexapodControl.UserShow.MyPanel();
            this.panelButtonsControl = new System.Windows.Forms.Panel();
            this.buttonReadAll = new System.Windows.Forms.Button();
            this.panelButtonsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelViewRobot
            // 
            this.panelViewRobot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelViewRobot.Location = new System.Drawing.Point(172, 3);
            this.panelViewRobot.Name = "panelViewRobot";
            this.panelViewRobot.Size = new System.Drawing.Size(517, 613);
            this.panelViewRobot.TabIndex = 0;
            this.panelViewRobot.Paint += new System.Windows.Forms.PaintEventHandler(this.panelViewRobot_Paint);
            // 
            // panelButtonsControl
            // 
            this.panelButtonsControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelButtonsControl.Controls.Add(this.buttonReadAll);
            this.panelButtonsControl.Location = new System.Drawing.Point(3, 3);
            this.panelButtonsControl.Name = "panelButtonsControl";
            this.panelButtonsControl.Size = new System.Drawing.Size(163, 613);
            this.panelButtonsControl.TabIndex = 1;
            this.panelButtonsControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelButtonsControl_Paint);
            // 
            // buttonReadAll
            // 
            this.buttonReadAll.Location = new System.Drawing.Point(3, 3);
            this.buttonReadAll.Name = "buttonReadAll";
            this.buttonReadAll.Size = new System.Drawing.Size(157, 31);
            this.buttonReadAll.TabIndex = 0;
            this.buttonReadAll.Text = "Read All";
            this.buttonReadAll.UseVisualStyleBackColor = true;
            this.buttonReadAll.Click += new System.EventHandler(this.buttonReadAll_Click);
            // 
            // UserShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelButtonsControl);
            this.Controls.Add(this.panelViewRobot);
            this.Name = "UserShow";
            this.Size = new System.Drawing.Size(692, 619);
            this.Resize += new System.EventHandler(this.UserShow_Resize);
            this.panelButtonsControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyPanel panelViewRobot;
        private System.Windows.Forms.Panel panelButtonsControl;
        private System.Windows.Forms.Button buttonReadAll;
    }
}
