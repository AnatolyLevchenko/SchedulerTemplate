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
            this.olvState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvNextFire = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvTriggers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTrigger
            // 
            this.btnAddTrigger.BackColor = System.Drawing.Color.Khaki;
            this.btnAddTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrigger.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddTrigger.Location = new System.Drawing.Point(606, 3);
            this.btnAddTrigger.Name = "btnAddTrigger";
            this.btnAddTrigger.Size = new System.Drawing.Size(75, 26);
            this.btnAddTrigger.TabIndex = 10;
            this.btnAddTrigger.Text = "Add Trigger";
            this.btnAddTrigger.UseVisualStyleBackColor = false;
            this.btnAddTrigger.Click += new System.EventHandler(this.btnAddTrigger_Click);
            // 
            // olvTriggers
            // 
            this.olvTriggers.AllColumns.Add(this.olvTriggerKey);
            this.olvTriggers.AllColumns.Add(this.olvJobName);
            this.olvTriggers.AllColumns.Add(this.olvState);
            this.olvTriggers.AllColumns.Add(this.olvNextFire);
            this.olvTriggers.AllColumns.Add(this.olvColumnAction);
            this.olvTriggers.CellEditUseWholeCell = false;
            this.olvTriggers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvTriggerKey,
            this.olvJobName,
            this.olvState,
            this.olvNextFire,
            this.olvColumnAction});
            this.olvTriggers.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTriggers.Dock = System.Windows.Forms.DockStyle.Left;
            this.olvTriggers.FullRowSelect = true;
            this.olvTriggers.Location = new System.Drawing.Point(0, 0);
            this.olvTriggers.Name = "olvTriggers";
            this.olvTriggers.RowHeight = 65;
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
            this.olvTriggerKey.Width = 179;
            this.olvTriggerKey.WordWrap = true;
            // 
            // olvJobName
            // 
            this.olvJobName.AspectName = "JobName";
            this.olvJobName.Text = "Job";
            this.olvJobName.Width = 93;
            // 
            // olvState
            // 
            this.olvState.AspectName = "State";
            this.olvState.Text = "State";
            // 
            // olvNextFire
            // 
            this.olvNextFire.AspectName = "NextFireTimeUTC";
            this.olvNextFire.Text = "Next Fire Time";
            this.olvNextFire.Width = 136;
            this.olvNextFire.WordWrap = true;
            // 
            // olvColumnAction
            // 
            this.olvColumnAction.AspectName = "Action";
            this.olvColumnAction.ButtonSize = new System.Drawing.Size(80, 26);
            this.olvColumnAction.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.FixedBounds;
            this.olvColumnAction.FillsFreeSpace = true;
            this.olvColumnAction.IsButton = true;
            this.olvColumnAction.Text = "Action";
            this.olvColumnAction.Width = 124;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Khaki;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(606, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 28);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
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
        private BrightIdeasSoftware.OLVColumn olvState;
        private BrightIdeasSoftware.OLVColumn olvColumnAction;
    }
}
