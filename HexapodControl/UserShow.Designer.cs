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
            this.components = new System.ComponentModel.Container();
            this.trackBarTibiaAngle = new System.Windows.Forms.TrackBar();
            this.trackBarFemurAngle = new System.Windows.Forms.TrackBar();
            this.trackBarCoxaAngle = new System.Windows.Forms.TrackBar();
            this.timeRadar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTibiaAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFemurAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCoxaAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarTibiaAngle
            // 
            this.trackBarTibiaAngle.Location = new System.Drawing.Point(143, 52);
            this.trackBarTibiaAngle.Maximum = 50;
            this.trackBarTibiaAngle.Minimum = -50;
            this.trackBarTibiaAngle.Name = "trackBarTibiaAngle";
            this.trackBarTibiaAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTibiaAngle.Size = new System.Drawing.Size(56, 229);
            this.trackBarTibiaAngle.TabIndex = 0;
            this.trackBarTibiaAngle.TickFrequency = 15;
            this.trackBarTibiaAngle.Value = 50;
            this.trackBarTibiaAngle.ValueChanged += new System.EventHandler(this.trackBarAngle_ValueChanged);
            // 
            // trackBarFemurAngle
            // 
            this.trackBarFemurAngle.Location = new System.Drawing.Point(81, 52);
            this.trackBarFemurAngle.Maximum = 90;
            this.trackBarFemurAngle.Name = "trackBarFemurAngle";
            this.trackBarFemurAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarFemurAngle.Size = new System.Drawing.Size(56, 229);
            this.trackBarFemurAngle.TabIndex = 1;
            this.trackBarFemurAngle.TickFrequency = 15;
            this.trackBarFemurAngle.ValueChanged += new System.EventHandler(this.trackBarAngle_ValueChanged);
            // 
            // trackBarCoxaAngle
            // 
            this.trackBarCoxaAngle.Location = new System.Drawing.Point(19, 52);
            this.trackBarCoxaAngle.Maximum = 30;
            this.trackBarCoxaAngle.Minimum = -30;
            this.trackBarCoxaAngle.Name = "trackBarCoxaAngle";
            this.trackBarCoxaAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarCoxaAngle.Size = new System.Drawing.Size(56, 229);
            this.trackBarCoxaAngle.TabIndex = 2;
            this.trackBarCoxaAngle.TickFrequency = 15;
            this.trackBarCoxaAngle.ValueChanged += new System.EventHandler(this.trackBarAngle_ValueChanged);
            // 
            // timeRadar
            // 
            this.timeRadar.Enabled = true;
            this.timeRadar.Interval = 250;
            this.timeRadar.Tick += new System.EventHandler(this.timeRadar_Tick);
            // 
            // UserShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.trackBarCoxaAngle);
            this.Controls.Add(this.trackBarFemurAngle);
            this.Controls.Add(this.trackBarTibiaAngle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserShow";
            this.Size = new System.Drawing.Size(737, 564);
            this.SizeChanged += new System.EventHandler(this.UserShow_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserShow_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTibiaAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFemurAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCoxaAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarTibiaAngle;
        private System.Windows.Forms.TrackBar trackBarFemurAngle;
        private System.Windows.Forms.TrackBar trackBarCoxaAngle;
        private System.Windows.Forms.Timer timeRadar;
    }
}
