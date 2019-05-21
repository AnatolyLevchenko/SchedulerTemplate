namespace ShScheduler
{
    partial class _ucUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ucUsers));
            this.olvUsers = new BrightIdeasSoftware.ObjectListView();
            this.olvLogin = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvAdmin = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvChangePassword = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvEmail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // olvUsers
            // 
            this.olvUsers.AllColumns.Add(this.olvLogin);
            this.olvUsers.AllColumns.Add(this.olvAdmin);
            this.olvUsers.AllColumns.Add(this.olvChangePassword);
            this.olvUsers.AllColumns.Add(this.olvEmail);
            this.olvUsers.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvUsers.CellEditUseWholeCell = false;
            this.olvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvLogin,
            this.olvAdmin,
            this.olvChangePassword,
            this.olvEmail});
            this.olvUsers.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.olvUsers, "olvUsers");
            this.olvUsers.FullRowSelect = true;
            this.olvUsers.Name = "olvUsers";
            this.olvUsers.RowHeight = 65;
            this.olvUsers.ShowGroups = false;
            this.olvUsers.UseAlternatingBackColors = true;
            this.olvUsers.UseCompatibleStateImageBehavior = false;
            this.olvUsers.View = System.Windows.Forms.View.Details;
            this.olvUsers.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvUsers_ButtonClick);
            this.olvUsers.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.olvUsers_CellEditFinishing);
            // 
            // olvLogin
            // 
            this.olvLogin.AspectName = "Login";
            this.olvLogin.IsEditable = false;
            resources.ApplyResources(this.olvLogin, "olvLogin");
            // 
            // olvAdmin
            // 
            this.olvAdmin.AspectName = "Admin";
            resources.ApplyResources(this.olvAdmin, "olvAdmin");
            // 
            // olvChangePassword
            // 
            this.olvChangePassword.AspectName = "ChangePassword";
            this.olvChangePassword.IsButton = true;
            resources.ApplyResources(this.olvChangePassword, "olvChangePassword");
            // 
            // olvEmail
            // 
            this.olvEmail.AspectName = "Email";
            this.olvEmail.FillsFreeSpace = true;
            resources.ApplyResources(this.olvEmail, "olvEmail");
            this.olvEmail.WordWrap = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Khaki;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // _ucUsers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.olvUsers);
            this.Name = "_ucUsers";
            ((System.ComponentModel.ISupportInitialize)(this.olvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvUsers;
        private BrightIdeasSoftware.OLVColumn olvLogin;
        private BrightIdeasSoftware.OLVColumn olvAdmin;
        private BrightIdeasSoftware.OLVColumn olvEmail;
        private System.Windows.Forms.Button btnRefresh;
        private BrightIdeasSoftware.OLVColumn olvChangePassword;
    }
}
