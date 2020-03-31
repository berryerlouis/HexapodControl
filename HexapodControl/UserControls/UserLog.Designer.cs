namespace HexapodControl
{
    partial class UserLog
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
            this.listViewLogs = new System.Windows.Forms.ListView();
            this.columnHeaderTxRx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSeqId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.buttonSendLog1 = new System.Windows.Forms.Button();
            this.textBoxSendLog1 = new System.Windows.Forms.TextBox();
            this.buttonSendLog2 = new System.Windows.Forms.Button();
            this.textBoxSendPayload = new System.Windows.Forms.TextBox();
            this.comboBoxCluster = new System.Windows.Forms.ComboBox();
            this.comboBoxCommand = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewLogs
            // 
            this.listViewLogs.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLogs.AutoArrange = false;
            this.listViewLogs.BackColor = System.Drawing.Color.Gray;
            this.listViewLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTxRx,
            this.columnHeaderSeqId,
            this.columnHeaderData,
            this.columnHeaderDescription});
            this.listViewLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listViewLogs.FullRowSelect = true;
            this.listViewLogs.GridLines = true;
            this.listViewLogs.HideSelection = false;
            this.listViewLogs.Location = new System.Drawing.Point(0, 0);
            this.listViewLogs.Name = "listViewLogs";
            this.listViewLogs.Size = new System.Drawing.Size(704, 467);
            this.listViewLogs.TabIndex = 0;
            this.listViewLogs.UseCompatibleStateImageBehavior = false;
            this.listViewLogs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTxRx
            // 
            this.columnHeaderTxRx.Text = "Tx/Rx";
            this.columnHeaderTxRx.Width = 50;
            // 
            // columnHeaderSeqId
            // 
            this.columnHeaderSeqId.Text = "Seq Id";
            this.columnHeaderSeqId.Width = 58;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 140;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 1159;
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClearLog.Location = new System.Drawing.Point(3, 473);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(118, 51);
            this.buttonClearLog.TabIndex = 1;
            this.buttonClearLog.Text = "Clear Log";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // buttonSendLog1
            // 
            this.buttonSendLog1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendLog1.Location = new System.Drawing.Point(629, 473);
            this.buttonSendLog1.Name = "buttonSendLog1";
            this.buttonSendLog1.Size = new System.Drawing.Size(75, 23);
            this.buttonSendLog1.TabIndex = 2;
            this.buttonSendLog1.Text = "Send";
            this.buttonSendLog1.UseVisualStyleBackColor = true;
            this.buttonSendLog1.Click += new System.EventHandler(this.buttonSendLog1_Click);
            // 
            // textBoxSendLog1
            // 
            this.textBoxSendLog1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSendLog1.Location = new System.Drawing.Point(276, 475);
            this.textBoxSendLog1.Name = "textBoxSendLog1";
            this.textBoxSendLog1.Size = new System.Drawing.Size(344, 20);
            this.textBoxSendLog1.TabIndex = 3;
            this.textBoxSendLog1.Text = "0000000";
            // 
            // buttonSendLog2
            // 
            this.buttonSendLog2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendLog2.Location = new System.Drawing.Point(629, 502);
            this.buttonSendLog2.Name = "buttonSendLog2";
            this.buttonSendLog2.Size = new System.Drawing.Size(75, 23);
            this.buttonSendLog2.TabIndex = 4;
            this.buttonSendLog2.Text = "Send";
            this.buttonSendLog2.UseVisualStyleBackColor = true;
            this.buttonSendLog2.Click += new System.EventHandler(this.buttonSendLog2_Click);
            // 
            // textBoxSendPayload
            // 
            this.textBoxSendPayload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSendPayload.Location = new System.Drawing.Point(518, 504);
            this.textBoxSendPayload.Name = "textBoxSendPayload";
            this.textBoxSendPayload.Size = new System.Drawing.Size(102, 20);
            this.textBoxSendPayload.TabIndex = 5;
            // 
            // comboBoxCluster
            // 
            this.comboBoxCluster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCluster.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCluster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCluster.FormattingEnabled = true;
            this.comboBoxCluster.Location = new System.Drawing.Point(276, 504);
            this.comboBoxCluster.Name = "comboBoxCluster";
            this.comboBoxCluster.Size = new System.Drawing.Size(90, 21);
            this.comboBoxCluster.TabIndex = 9;
            this.comboBoxCluster.SelectedIndexChanged += new System.EventHandler(this.comboBoxCluster_SelectedIndexChanged);
            // 
            // comboBoxCommand
            // 
            this.comboBoxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCommand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCommand.FormattingEnabled = true;
            this.comboBoxCommand.Location = new System.Drawing.Point(372, 504);
            this.comboBoxCommand.Name = "comboBoxCommand";
            this.comboBoxCommand.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCommand.TabIndex = 10;
            // 
            // UserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.comboBoxCommand);
            this.Controls.Add(this.comboBoxCluster);
            this.Controls.Add(this.textBoxSendPayload);
            this.Controls.Add(this.buttonSendLog2);
            this.Controls.Add(this.textBoxSendLog1);
            this.Controls.Add(this.buttonSendLog1);
            this.Controls.Add(this.buttonClearLog);
            this.Controls.Add(this.listViewLogs);
            this.Name = "UserLog";
            this.Size = new System.Drawing.Size(704, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewLogs;
        private System.Windows.Forms.ColumnHeader columnHeaderTxRx;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Button buttonSendLog1;
        private System.Windows.Forms.TextBox textBoxSendLog1;
        private System.Windows.Forms.Button buttonSendLog2;
        private System.Windows.Forms.TextBox textBoxSendPayload;
        private System.Windows.Forms.ColumnHeader columnHeaderSeqId;
        private System.Windows.Forms.ComboBox comboBoxCluster;
        private System.Windows.Forms.ComboBox comboBoxCommand;
    }
}
