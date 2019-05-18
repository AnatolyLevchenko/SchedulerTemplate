namespace ShScheduler
{
    partial class _ucFeedbacks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.olvFeedback = new BrightIdeasSoftware.ObjectListView();
            this.olvJobName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvTriggerName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvText = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvUser = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // olvFeedback
            // 
            this.olvFeedback.AllColumns.Add(this.olvJobName);
            this.olvFeedback.AllColumns.Add(this.olvTriggerName);
            this.olvFeedback.AllColumns.Add(this.olvText);
            this.olvFeedback.AllColumns.Add(this.olvUser);
            this.olvFeedback.CellEditUseWholeCell = false;
            this.olvFeedback.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvJobName,
            this.olvTriggerName,
            this.olvText,
            this.olvUser});
            this.olvFeedback.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvFeedback.Dock = System.Windows.Forms.DockStyle.Left;
            this.olvFeedback.FullRowSelect = true;
            this.olvFeedback.Location = new System.Drawing.Point(0, 0);
            this.olvFeedback.Name = "olvFeedback";
            this.olvFeedback.ShowGroups = false;
            this.olvFeedback.Size = new System.Drawing.Size(588, 345);
            this.olvFeedback.TabIndex = 0;
            this.olvFeedback.UseCompatibleStateImageBehavior = false;
            this.olvFeedback.View = System.Windows.Forms.View.Details;
            // 
            // olvJobName
            // 
            this.olvJobName.AspectName = "JobName";
            this.olvJobName.Text = "Job";
            this.olvJobName.Width = 99;
            // 
            // olvTriggerName
            // 
            this.olvTriggerName.AspectName = "TriggerName";
            this.olvTriggerName.Text = "Trigger";
            this.olvTriggerName.Width = 113;
            // 
            // olvText
            // 
            this.olvText.AspectName = "Text";
            this.olvText.Text = "Feedback";
            this.olvText.Width = 267;
            // 
            // olvUser
            // 
            this.olvUser.AspectName = "User";
            this.olvUser.FillsFreeSpace = true;
            this.olvUser.Text = "User";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Khaki;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(594, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // _ucFeedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.olvFeedback);
            this.Name = "_ucFeedbacks";
            this.Size = new System.Drawing.Size(676, 345);
            ((System.ComponentModel.ISupportInitialize)(this.olvFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvFeedback;
        private System.Windows.Forms.Button btnRefresh;
        private BrightIdeasSoftware.OLVColumn olvJobName;
        private BrightIdeasSoftware.OLVColumn olvTriggerName;
        private BrightIdeasSoftware.OLVColumn olvText;
        private BrightIdeasSoftware.OLVColumn olvUser;
    }
}
