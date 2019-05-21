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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ucTriggers));
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
            resources.ApplyResources(this.btnAddTrigger, "btnAddTrigger");
            this.btnAddTrigger.Name = "btnAddTrigger";
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
            resources.ApplyResources(this.olvTriggers, "olvTriggers");
            this.olvTriggers.FullRowSelect = true;
            this.olvTriggers.Name = "olvTriggers";
            this.olvTriggers.RowHeight = 65;
            this.olvTriggers.ShowGroups = false;
            this.olvTriggers.UseCompatibleStateImageBehavior = false;
            this.olvTriggers.View = System.Windows.Forms.View.Details;
            // 
            // olvTriggerKey
            // 
            this.olvTriggerKey.AspectName = "TriggerKey";
            resources.ApplyResources(this.olvTriggerKey, "olvTriggerKey");
            this.olvTriggerKey.WordWrap = true;
            // 
            // olvJobName
            // 
            this.olvJobName.AspectName = "JobName";
            resources.ApplyResources(this.olvJobName, "olvJobName");
            // 
            // olvState
            // 
            this.olvState.AspectName = "State";
            resources.ApplyResources(this.olvState, "olvState");
            // 
            // olvNextFire
            // 
            this.olvNextFire.AspectName = "NextFireTimeUTC";
            resources.ApplyResources(this.olvNextFire, "olvNextFire");
            this.olvNextFire.WordWrap = true;
            // 
            // olvColumnAction
            // 
            this.olvColumnAction.AspectName = "Action";
            this.olvColumnAction.ButtonSize = new System.Drawing.Size(80, 26);
            this.olvColumnAction.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.FixedBounds;
            this.olvColumnAction.FillsFreeSpace = true;
            this.olvColumnAction.IsButton = true;
            resources.ApplyResources(this.olvColumnAction, "olvColumnAction");
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Khaki;
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // _ucTriggers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddTrigger);
            this.Controls.Add(this.olvTriggers);
            this.Name = "_ucTriggers";
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
