namespace HexapodControl
{
    partial class UserConfig
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
            this.flowLayoutPanelConfig = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelConfig
            // 
            this.flowLayoutPanelConfig.AutoScroll = true;
            this.flowLayoutPanelConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelConfig.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelConfig.Name = "flowLayoutPanelConfig";
            this.flowLayoutPanelConfig.Size = new System.Drawing.Size(857, 655);
            this.flowLayoutPanelConfig.TabIndex = 14;
            // 
            // UserConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.flowLayoutPanelConfig);
            this.Name = "UserConfig";
            this.Size = new System.Drawing.Size(857, 655);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelConfig;
    }
}
