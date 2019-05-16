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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-69, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "JOBS";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(607, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(607, 3);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(75, 23);
            this.btnAddJob.TabIndex = 7;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // olvJobs
            // 
            this.olvJobs.AllColumns.Add(this.olvName);
            this.olvJobs.AllColumns.Add(this.olvDescription);
            this.olvJobs.AllColumns.Add(this.olvDurable);
            this.olvJobs.CellEditUseWholeCell = false;
            this.olvJobs.CheckBoxes = true;
            this.olvJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvName,
            this.olvDescription,
            this.olvDurable});
            this.olvJobs.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvJobs.Dock = System.Windows.Forms.DockStyle.Left;
            this.olvJobs.FullRowSelect = true;
            this.olvJobs.Location = new System.Drawing.Point(0, 0);
            this.olvJobs.Name = "olvJobs";
            this.olvJobs.Scrollable = false;
            this.olvJobs.ShowGroups = false;
            this.olvJobs.ShowItemToolTips = true;
            this.olvJobs.Size = new System.Drawing.Size(601, 394);
            this.olvJobs.TabIndex = 6;
            this.olvJobs.UseAlternatingBackColors = true;
            this.olvJobs.UseCompatibleStateImageBehavior = false;
            this.olvJobs.View = System.Windows.Forms.View.Details;
            // 
            // olvName
            // 
            this.olvName.AspectName = "Key.Name";
            this.olvName.Text = "Name";
            this.olvName.Width = 245;
            // 
            // olvDescription
            // 
            this.olvDescription.AspectName = "Description";
            this.olvDescription.Text = "Description";
            this.olvDescription.Width = 251;
            // 
            // olvDurable
            // 
            this.olvDurable.AspectName = "Durable";
            this.olvDurable.FillsFreeSpace = true;
            this.olvDurable.Text = "Durable";
            this.olvDurable.Width = 100;
            // 
            // _ucJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.olvJobs);
            this.Name = "_ucJobs";
            this.Size = new System.Drawing.Size(693, 394);
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
