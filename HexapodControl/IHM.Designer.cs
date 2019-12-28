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
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1312, 34);
            this.panelHeader.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Silver;
            this.panelMenu.Controls.Add(this.buttonShowBot);
            this.panelMenu.Controls.Add(this.buttonLog);
            this.panelMenu.Controls.Add(this.buttonConnect);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 34);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(261, 720);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonShowBot
            // 
            this.buttonShowBot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShowBot.Location = new System.Drawing.Point(4, 130);
            this.buttonShowBot.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowBot.Name = "buttonShowBot";
            this.buttonShowBot.Size = new System.Drawing.Size(253, 46);
            this.buttonShowBot.TabIndex = 2;
            this.buttonShowBot.Text = "Show";
            this.buttonShowBot.UseVisualStyleBackColor = true;
            this.buttonShowBot.Click += new System.EventHandler(this.buttonShowBot_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLog.Location = new System.Drawing.Point(4, 76);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(253, 46);
            this.buttonLog.TabIndex = 1;
            this.buttonLog.Text = "Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.ForeColor = System.Drawing.Color.Green;
            this.buttonConnect.Location = new System.Drawing.Point(4, 22);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(253, 46);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.labelVersion);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(261, 722);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1051, 32);
            this.panelBottom.TabIndex = 2;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelVersion.Location = new System.Drawing.Point(8, 5);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(88, 17);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version : 0.0";
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(261, 34);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(4);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1051, 688);
            this.panelBackground.TabIndex = 3;
            // 
            // IHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1312, 754);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "IHM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spider Bot";
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
    }
}