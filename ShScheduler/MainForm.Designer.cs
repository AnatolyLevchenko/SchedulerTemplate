namespace ShScheduler
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnSmtp = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnShowTriggers = new System.Windows.Forms.Button();
            this.btnShowJobs = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIExit = new System.Windows.Forms.ToolStripMenuItem();
            this._ucFeedbacks1 = new ShScheduler._ucFeedbacks();
            this._ucUsers1 = new ShScheduler._ucUsers();
            this._ucTriggers1 = new ShScheduler._ucTriggers();
            this._ucJobs1 = new ShScheduler._ucJobs();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btnFeedback);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnSmtp);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnShowTriggers);
            this.panel1.Controls.Add(this.btnShowJobs);
            this.panel1.Name = "panel1";
            // 
            // btnFeedback
            // 
            resources.ApplyResources(this.btnFeedback, "btnFeedback");
            this.btnFeedback.BackColor = System.Drawing.Color.Khaki;
            this.btnFeedback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.Khaki;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUsers
            // 
            resources.ApplyResources(this.btnUsers, "btnUsers");
            this.btnUsers.BackColor = System.Drawing.Color.Khaki;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnSmtp
            // 
            resources.ApplyResources(this.btnSmtp, "btnSmtp");
            this.btnSmtp.BackColor = System.Drawing.Color.Khaki;
            this.btnSmtp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSmtp.Name = "btnSmtp";
            this.btnSmtp.UseVisualStyleBackColor = false;
            this.btnSmtp.Click += new System.EventHandler(this.btnSmtp_Click);
            // 
            // lbUser
            // 
            resources.ApplyResources(this.lbUser, "lbUser");
            this.lbUser.BackColor = System.Drawing.Color.Lime;
            this.lbUser.Name = "lbUser";
            // 
            // btnRegister
            // 
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.BackColor = System.Drawing.Color.Khaki;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogOut
            // 
            resources.ApplyResources(this.btnLogOut, "btnLogOut");
            this.btnLogOut.BackColor = System.Drawing.Color.Khaki;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnShowTriggers
            // 
            resources.ApplyResources(this.btnShowTriggers, "btnShowTriggers");
            this.btnShowTriggers.BackColor = System.Drawing.Color.Khaki;
            this.btnShowTriggers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnShowTriggers.Name = "btnShowTriggers";
            this.btnShowTriggers.UseVisualStyleBackColor = false;
            this.btnShowTriggers.Click += new System.EventHandler(this.btnShowTriggers_Click);
            // 
            // btnShowJobs
            // 
            resources.ApplyResources(this.btnShowJobs, "btnShowJobs");
            this.btnShowJobs.BackColor = System.Drawing.Color.Khaki;
            this.btnShowJobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnShowJobs.Name = "btnShowJobs";
            this.btnShowJobs.UseVisualStyleBackColor = false;
            this.btnShowJobs.Click += new System.EventHandler(this.btnShowJobs_Click);
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripMenuIExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // toolStripMenuItemShow
            // 
            resources.ApplyResources(this.toolStripMenuItemShow, "toolStripMenuItemShow");
            this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            this.toolStripMenuItemShow.Click += new System.EventHandler(this.toolStripMenuItemShow_Click);
            // 
            // toolStripMenuIExit
            // 
            resources.ApplyResources(this.toolStripMenuIExit, "toolStripMenuIExit");
            this.toolStripMenuIExit.Name = "toolStripMenuIExit";
            this.toolStripMenuIExit.Click += new System.EventHandler(this.toolStripMenuIExit_Click);
            // 
            // _ucFeedbacks1
            // 
            resources.ApplyResources(this._ucFeedbacks1, "_ucFeedbacks1");
            this._ucFeedbacks1.Name = "_ucFeedbacks1";
            // 
            // _ucUsers1
            // 
            resources.ApplyResources(this._ucUsers1, "_ucUsers1");
            this._ucUsers1.Name = "_ucUsers1";
            // 
            // _ucTriggers1
            // 
            resources.ApplyResources(this._ucTriggers1, "_ucTriggers1");
            this._ucTriggers1.Name = "_ucTriggers1";
            // 
            // _ucJobs1
            // 
            resources.ApplyResources(this._ucJobs1, "_ucJobs1");
            this._ucJobs1.Name = "_ucJobs1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._ucFeedbacks1);
            this.Controls.Add(this._ucUsers1);
            this.Controls.Add(this._ucTriggers1);
            this.Controls.Add(this._ucJobs1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowJobs;
        private System.Windows.Forms.Button btnShowTriggers;
        private _ucJobs _ucJobs1;
        private _ucTriggers _ucTriggers1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnSmtp;
        private System.Windows.Forms.Button btnUsers;
        private _ucUsers _ucUsers1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIExit;
        private System.Windows.Forms.Button btnExit;
        private _ucFeedbacks _ucFeedbacks1;
        private System.Windows.Forms.Button btnFeedback;
    }
}

