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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnSmtp = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnShowTriggers = new System.Windows.Forms.Button();
            this.btnShowJobs = new System.Windows.Forms.Button();
            this._ucUsers1 = new ShScheduler._ucUsers();
            this._ucTriggers1 = new ShScheduler._ucTriggers();
            this._ucJobs1 = new ShScheduler._ucJobs();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnSmtp);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnShowTriggers);
            this.panel1.Controls.Add(this.btnShowJobs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 495);
            this.panel1.TabIndex = 8;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Khaki;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUsers.Location = new System.Drawing.Point(3, 138);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(88, 37);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnSmtp
            // 
            this.btnSmtp.BackColor = System.Drawing.Color.Khaki;
            this.btnSmtp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSmtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmtp.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSmtp.Location = new System.Drawing.Point(3, 373);
            this.btnSmtp.Name = "btnSmtp";
            this.btnSmtp.Size = new System.Drawing.Size(88, 37);
            this.btnSmtp.TabIndex = 5;
            this.btnSmtp.Text = "SMTP";
            this.btnSmtp.UseVisualStyleBackColor = false;
            this.btnSmtp.Click += new System.EventHandler(this.btnSmtp_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Lime;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUser.Location = new System.Drawing.Point(12, 12);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(47, 20);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "User";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Khaki;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Location = new System.Drawing.Point(3, 330);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(88, 37);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Khaki;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.Location = new System.Drawing.Point(3, 432);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(88, 37);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnShowTriggers
            // 
            this.btnShowTriggers.BackColor = System.Drawing.Color.Khaki;
            this.btnShowTriggers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnShowTriggers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTriggers.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnShowTriggers.Location = new System.Drawing.Point(3, 95);
            this.btnShowTriggers.Name = "btnShowTriggers";
            this.btnShowTriggers.Size = new System.Drawing.Size(88, 37);
            this.btnShowTriggers.TabIndex = 1;
            this.btnShowTriggers.Text = "Triggers";
            this.btnShowTriggers.UseVisualStyleBackColor = false;
            this.btnShowTriggers.Click += new System.EventHandler(this.btnShowTriggers_Click);
            // 
            // btnShowJobs
            // 
            this.btnShowJobs.BackColor = System.Drawing.Color.Khaki;
            this.btnShowJobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnShowJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowJobs.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnShowJobs.Location = new System.Drawing.Point(3, 52);
            this.btnShowJobs.Name = "btnShowJobs";
            this.btnShowJobs.Size = new System.Drawing.Size(88, 37);
            this.btnShowJobs.TabIndex = 0;
            this.btnShowJobs.Text = "Jobs";
            this.btnShowJobs.UseVisualStyleBackColor = false;
            this.btnShowJobs.Click += new System.EventHandler(this.btnShowJobs_Click);
            // 
            // _ucUsers1
            // 
            this._ucUsers1.Location = new System.Drawing.Point(114, 12);
            this._ucUsers1.Name = "_ucUsers1";
            this._ucUsers1.Size = new System.Drawing.Size(688, 471);
            this._ucUsers1.TabIndex = 11;
            // 
            // _ucTriggers1
            // 
            this._ucTriggers1.Location = new System.Drawing.Point(114, 12);
            this._ucTriggers1.Name = "_ucTriggers1";
            this._ucTriggers1.Size = new System.Drawing.Size(688, 471);
            this._ucTriggers1.TabIndex = 10;
            // 
            // _ucJobs1
            // 
            this._ucJobs1.Location = new System.Drawing.Point(114, 12);
            this._ucJobs1.Name = "_ucJobs1";
            this._ucJobs1.Size = new System.Drawing.Size(693, 471);
            this._ucJobs1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 495);
            this.Controls.Add(this._ucUsers1);
            this.Controls.Add(this._ucTriggers1);
            this.Controls.Add(this._ucJobs1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

