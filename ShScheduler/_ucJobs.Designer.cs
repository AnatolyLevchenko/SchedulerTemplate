namespace ShScheduler
{
    partial class _ucJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ucJobs));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.olvJobs = new BrightIdeasSoftware.ObjectListView();
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDurable = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Khaki;
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.Khaki;
            resources.ApplyResources(this.btnAddJob, "btnAddJob");
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // olvJobs
            // 
            this.olvJobs.AllColumns.Add(this.olvName);
            this.olvJobs.AllColumns.Add(this.olvDescription);
            this.olvJobs.AllColumns.Add(this.olvDurable);
            this.olvJobs.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvJobs.CellEditUseWholeCell = false;
            this.olvJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvName,
            this.olvDescription,
            this.olvDurable});
            this.olvJobs.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.olvJobs, "olvJobs");
            this.olvJobs.FullRowSelect = true;
            this.olvJobs.Name = "olvJobs";
            this.olvJobs.RowHeight = 65;
            this.olvJobs.Scrollable = false;
            this.olvJobs.ShowGroups = false;
            this.olvJobs.ShowItemToolTips = true;
            this.olvJobs.UseAlternatingBackColors = true;
            this.olvJobs.UseCompatibleStateImageBehavior = false;
            this.olvJobs.View = System.Windows.Forms.View.Details;
            this.olvJobs.CellEditValidating += new BrightIdeasSoftware.CellEditEventHandler(this.olvJobs_CellEditValidating);
            // 
            // olvName
            // 
            this.olvName.AspectName = "Key.Name";
            this.olvName.IsEditable = false;
            resources.ApplyResources(this.olvName, "olvName");
            // 
            // olvDescription
            // 
            this.olvDescription.AspectName = "Description";
            resources.ApplyResources(this.olvDescription, "olvDescription");
            // 
            // olvDurable
            // 
            this.olvDurable.AspectName = "Durable";
            this.olvDurable.FillsFreeSpace = true;
            this.olvDurable.IsEditable = false;
            resources.ApplyResources(this.olvDurable, "olvDurable");
            // 
            // _ucJobs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.olvJobs);
            this.Name = "_ucJobs";
            ((System.ComponentModel.ISupportInitialize)(this.olvJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddJob;
        private BrightIdeasSoftware.ObjectListView olvJobs;
        private BrightIdeasSoftware.OLVColumn olvName;
        private BrightIdeasSoftware.OLVColumn olvDescription;
        private BrightIdeasSoftware.OLVColumn olvDurable;
    }
}
