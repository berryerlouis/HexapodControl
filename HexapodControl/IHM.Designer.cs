namespace HexapodControl
{
    partial class IHM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonShowBot = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Gray;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(840, 28);
            this.panelHeader.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.Silver;
            this.panelMenu.Controls.Add(this.buttonConfig);
            this.panelMenu.Controls.Add(this.buttonShowBot);
            this.panelMenu.Controls.Add(this.buttonLog);
            this.panelMenu.Controls.Add(this.buttonConnect);
            this.panelMenu.Location = new System.Drawing.Point(0, 28);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(196, 559);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonConfig
            // 
            this.buttonConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfig.Location = new System.Drawing.Point(3, 149);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(190, 37);
            this.buttonConfig.TabIndex = 3;
            this.buttonConfig.Text = "Config";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonShowBot
            // 
            this.buttonShowBot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShowBot.Location = new System.Drawing.Point(3, 106);
            this.buttonShowBot.Name = "buttonShowBot";
            this.buttonShowBot.Size = new System.Drawing.Size(190, 37);
            this.buttonShowBot.TabIndex = 2;
            this.buttonShowBot.Text = "Show";
            this.buttonShowBot.UseVisualStyleBackColor = true;
            this.buttonShowBot.Click += new System.EventHandler(this.buttonShowBot_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLog.Location = new System.Drawing.Point(3, 62);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(190, 37);
            this.buttonLog.TabIndex = 1;
            this.buttonLog.Text = "Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.ForeColor = System.Drawing.Color.Green;
            this.buttonConnect.Location = new System.Drawing.Point(3, 18);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(190, 37);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.labelVersion);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 587);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(840, 26);
            this.panelBottom.TabIndex = 2;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelVersion.Location = new System.Drawing.Point(6, 4);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(66, 13);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version : 0.0";
            // 
            // panelBackground
            // 
            this.panelBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelBackground.Location = new System.Drawing.Point(196, 28);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(644, 559);
            this.panelBackground.TabIndex = 3;
            // 
            // IHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(840, 613);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(754, 414);
            this.Name = "IHM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spider Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IHM_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button buttonShowBot;
        private System.Windows.Forms.Button buttonConfig;
    }
}