namespace ShScheduler.UserControls
{
    partial class _ucSmtp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ucSmtp));
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveSmtp = new System.Windows.Forms.Button();
            this.nupPort = new System.Windows.Forms.NumericUpDown();
            this.btnTestSettings = new System.Windows.Forms.Button();
            this.txtTextEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSsl = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupPort)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSmtp
            // 
            resources.ApplyResources(this.txtSmtp, "txtSmtp");
            this.txtSmtp.Name = "txtSmtp";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Name = "label1";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Name = "label2";
            // 
            // txtPass
            // 
            resources.ApplyResources(this.txtPass, "txtPass");
            this.txtPass.Name = "txtPass";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Name = "label4";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveSmtp
            // 
            resources.ApplyResources(this.btnSaveSmtp, "btnSaveSmtp");
            this.btnSaveSmtp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSaveSmtp.FlatAppearance.BorderSize = 0;
            this.btnSaveSmtp.ForeColor = System.Drawing.Color.White;
            this.btnSaveSmtp.Name = "btnSaveSmtp";
            this.btnSaveSmtp.UseVisualStyleBackColor = false;
            this.btnSaveSmtp.Click += new System.EventHandler(this.btnSaveSmtp_Click);
            // 
            // nupPort
            // 
            resources.ApplyResources(this.nupPort, "nupPort");
            this.nupPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupPort.Name = "nupPort";
            // 
            // btnTestSettings
            // 
            resources.ApplyResources(this.btnTestSettings, "btnTestSettings");
            this.btnTestSettings.Name = "btnTestSettings";
            this.btnTestSettings.UseVisualStyleBackColor = true;
            this.btnTestSettings.Click += new System.EventHandler(this.btnTestSettings_Click);
            // 
            // txtTextEmail
            // 
            resources.ApplyResources(this.txtTextEmail, "txtTextEmail");
            this.txtTextEmail.Name = "txtTextEmail";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Name = "label5";
            // 
            // cbSsl
            // 
            resources.ApplyResources(this.cbSsl, "cbSsl");
            this.cbSsl.Name = "cbSsl";
            this.cbSsl.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Name = "label6";
            // 
            // _ucSmtp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSsl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTextEmail);
            this.Controls.Add(this.btnTestSettings);
            this.Controls.Add(this.nupPort);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveSmtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSmtp);
            this.Controls.Add(this.label1);
            this.Name = "_ucSmtp";
            this.Load += new System.EventHandler(this._ucSmtp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveSmtp;
        private System.Windows.Forms.NumericUpDown nupPort;
        private System.Windows.Forms.Button btnTestSettings;
        private System.Windows.Forms.TextBox txtTextEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbSsl;
        private System.Windows.Forms.Label label6;
    }
}
