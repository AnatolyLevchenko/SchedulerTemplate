namespace ShScheduler
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        ///// <summary>
        ///// Clean up any resources being used.
        ///// </summary>
        ///// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        ////protected override void Dispose(bool disposing)
        ////{
        ////    if (disposing && (components != null))
        ////    {
        ////        components.Dispose();
        ////    }
        ////    base.Dispose(disposing);
        ////}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.olvJobs = new BrightIdeasSoftware.ObjectListView();
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDurable = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnAddJob = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.olvTriggers = new BrightIdeasSoftware.ObjectListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTrigger = new System.Windows.Forms.Button();
            this.olvTriggerKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvTriggers)).BeginInit();
            this.SuspendLayout();
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
            this.olvJobs.FullRowSelect = true;
            this.olvJobs.Location = new System.Drawing.Point(13, 32);
            this.olvJobs.Name = "olvJobs";
            this.olvJobs.Scrollable = false;
            this.olvJobs.ShowGroups = false;
            this.olvJobs.ShowItemToolTips = true;
            this.olvJobs.Size = new System.Drawing.Size(601, 80);
            this.olvJobs.TabIndex = 1;
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
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(620, 32);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(75, 23);
            this.btnAddJob.TabIndex = 2;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(620, 62);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // olvTriggers
            // 
            this.olvTriggers.AllColumns.Add(this.olvTriggerKey);
            this.olvTriggers.CellEditUseWholeCell = false;
            this.olvTriggers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvTriggerKey});
            this.olvTriggers.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTriggers.Location = new System.Drawing.Point(13, 185);
            this.olvTriggers.Name = "olvTriggers";
            this.olvTriggers.Size = new System.Drawing.Size(600, 97);
            this.olvTriggers.TabIndex = 4;
            this.olvTriggers.UseCompatibleStateImageBehavior = false;
            this.olvTriggers.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "JOBS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TRIGGERS";
            // 
            // btnAddTrigger
            // 
            this.btnAddTrigger.Location = new System.Drawing.Point(620, 185);
            this.btnAddTrigger.Name = "btnAddTrigger";
            this.btnAddTrigger.Size = new System.Drawing.Size(75, 23);
            this.btnAddTrigger.TabIndex = 7;
            this.btnAddTrigger.Text = "Add Trigger";
            this.btnAddTrigger.UseVisualStyleBackColor = true;
            this.btnAddTrigger.Click += new System.EventHandler(this.btnAddTrigger_Click);
            // 
            // olvTriggerKey
            // 
            this.olvTriggerKey.AspectName = "TriggerKey";
            this.olvTriggerKey.Text = "Trigger";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.btnAddTrigger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.olvTriggers);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.olvJobs);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.olvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvTriggers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BrightIdeasSoftware.ObjectListView olvJobs;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Button btnRefresh;
        private BrightIdeasSoftware.OLVColumn olvName;
        private BrightIdeasSoftware.OLVColumn olvDescription;
        private BrightIdeasSoftware.OLVColumn olvDurable;
        private BrightIdeasSoftware.ObjectListView olvTriggers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTrigger;
        private BrightIdeasSoftware.OLVColumn olvTriggerKey;
    }
}

