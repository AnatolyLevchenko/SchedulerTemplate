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
            this.txtSmtp.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmtp.Location = new System.Drawing.Point(15, 41);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(400, 31);
            this.txtSmtp.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "SMTP server";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(15, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 31);
            this.txtEmail.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "E-Mail ";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(15, 161);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(400, 31);
            this.txtPass.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(15, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Port";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(313, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 34);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveSmtp
            // 
            this.btnSaveSmtp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSaveSmtp.FlatAppearance.BorderSize = 0;
            this.btnSaveSmtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSmtp.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSmtp.ForeColor = System.Drawing.Color.White;
            this.btnSaveSmtp.Location = new System.Drawing.Point(18, 355);
            this.btnSaveSmtp.Name = "btnSaveSmtp";
            this.btnSaveSmtp.Size = new System.Drawing.Size(283, 34);
            this.btnSaveSmtp.TabIndex = 49;
            this.btnSaveSmtp.Text = "Save";
            this.btnSaveSmtp.UseVisualStyleBackColor = false;
            this.btnSaveSmtp.Click += new System.EventHandler(this.btnSaveSmtp_Click);
            // 
            // nupPort
            // 
            this.nupPort.Location = new System.Drawing.Point(18, 268);
            this.nupPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupPort.Name = "nupPort";
            this.nupPort.Size = new System.Drawing.Size(88, 20);
            this.nupPort.TabIndex = 51;
            // 
            // btnTestSettings
            // 
            this.btnTestSettings.Location = new System.Drawing.Point(322, 263);
            this.btnTestSettings.Name = "btnTestSettings";
            this.btnTestSettings.Size = new System.Drawing.Size(93, 23);
            this.btnTestSettings.TabIndex = 52;
            this.btnTestSettings.Text = "Test Settings";
            this.btnTestSettings.UseVisualStyleBackColor = true;
            this.btnTestSettings.Click += new System.EventHandler(this.btnTestSettings_Click);
            // 
            // txtTextEmail
            // 
            this.txtTextEmail.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextEmail.Location = new System.Drawing.Point(142, 263);
            this.txtTextEmail.Name = "txtTextEmail";
            this.txtTextEmail.Size = new System.Drawing.Size(165, 31);
            this.txtTextEmail.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(153, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Test Email";
            // 
            // cbSsl
            // 
            this.cbSsl.AutoSize = true;
            this.cbSsl.Location = new System.Drawing.Point(18, 212);
            this.cbSsl.Name = "cbSsl";
            this.cbSsl.Size = new System.Drawing.Size(46, 17);
            this.cbSsl.TabIndex = 55;
            this.cbSsl.Text = "SSL";
            this.cbSsl.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(15, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "!!!Save settings and test them to verify letters are send";
            // 
            // _ucSmtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Size = new System.Drawing.Size(531, 428);
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
