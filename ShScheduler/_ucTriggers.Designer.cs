namespace ShScheduler
{
    partial class _ucTriggers
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
            this.btnAddTrigger = new System.Windows.Forms.Button();
            this.olvTriggers = new BrightIdeasSoftware.ObjectListView();
            this.olvTriggerKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvJobName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvNextFire = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvTriggers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTrigger
            // 
            this.btnAddTrigger.Location = new System.Drawing.Point(606, 3);
            this.btnAddTrigger.Name = "btnAddTrigger";
            this.btnAddTrigger.Size = new System.Drawing.Size(75, 23);
            this.btnAddTrigger.TabIndex = 10;
            this.btnAddTrigger.Text = "Add Trigger";
            this.btnAddTrigger.UseVisualStyleBackColor = true;
            this.btnAddTrigger.Click += new System.EventHandler(this.btnAddTrigger_Click);
            // 
            // olvTriggers
            // 
            this.olvTriggers.AllColumns.Add(this.olvTriggerKey);
            this.olvTriggers.AllColumns.Add(this.olvJobName);
            this.olvTriggers.AllColumns.Add(this.olvNextFire);
            this.olvTriggers.CellEditUseWholeCell = false;
            this.olvTriggers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvTriggerKey,
            this.olvJobName,
            this.olvNextFire});
            this.olvTriggers.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTriggers.Dock = System.Windows.Forms.DockStyle.Left;
            this.olvTriggers.FullRowSelect = true;
            this.olvTriggers.Location = new System.Drawing.Point(0, 0);
            this.olvTriggers.Name = "olvTriggers";
            this.olvTriggers.ShowGroups = false;
            this.olvTriggers.Size = new System.Drawing.Size(600, 345);
            this.olvTriggers.TabIndex = 8;
            this.olvTriggers.UseCompatibleStateImageBehavior = false;
            this.olvTriggers.View = System.Windows.Forms.View.Details;
            // 
            // olvTriggerKey
            // 
            this.olvTriggerKey.AspectName = "TriggerKey";
            this.olvTriggerKey.Text = "Trigger";
            this.olvTriggerKey.Width = 88;
            // 
            // olvJobName
            // 
            this.olvJobName.AspectName = "JobName";
            this.olvJobName.Text = "Job";
            this.olvJobName.Width = 93;
            // 
            // olvNextFire
            // 
            this.olvNextFire.AspectName = "NextFireTimeUTC";
            this.olvNextFire.FillsFreeSpace = true;
            this.olvNextFire.Text = "Next Fire Time";
            this.olvNextFire.Width = 274;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(606, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // _ucTriggers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddTrigger);
            this.Controls.Add(this.olvTriggers);
            this.Name = "_ucTriggers";
            this.Size = new System.Drawing.Size(688, 345);
            ((System.ComponentModel.ISupportInitialize)(this.olvTriggers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddTrigger;
        private BrightIdeasSoftware.ObjectListView olvTriggers;
        private BrightIdeasSoftware.OLVColumn olvTriggerKey;
        private BrightIdeasSoftware.OLVColumn olvJobName;
        private BrightIdeasSoftware.OLVColumn olvNextFire;
        private System.Windows.Forms.Button btnRefresh;
    }
}
