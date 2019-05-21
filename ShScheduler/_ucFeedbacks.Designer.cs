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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ucFeedbacks));
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
            resources.ApplyResources(this.olvFeedback, "olvFeedback");
            this.olvFeedback.FullRowSelect = true;
            this.olvFeedback.Name = "olvFeedback";
            this.olvFeedback.ShowGroups = false;
            this.olvFeedback.UseCompatibleStateImageBehavior = false;
            this.olvFeedback.View = System.Windows.Forms.View.Details;
            // 
            // olvJobName
            // 
            this.olvJobName.AspectName = "JobName";
            resources.ApplyResources(this.olvJobName, "olvJobName");
            // 
            // olvTriggerName
            // 
            this.olvTriggerName.AspectName = "TriggerName";
            resources.ApplyResources(this.olvTriggerName, "olvTriggerName");
            // 
            // olvText
            // 
            this.olvText.AspectName = "Text";
            resources.ApplyResources(this.olvText, "olvText");
            // 
            // olvUser
            // 
            this.olvUser.AspectName = "User";
            this.olvUser.FillsFreeSpace = true;
            resources.ApplyResources(this.olvUser, "olvUser");
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Khaki;
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // _ucFeedbacks
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.olvFeedback);
            this.Name = "_ucFeedbacks";
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
