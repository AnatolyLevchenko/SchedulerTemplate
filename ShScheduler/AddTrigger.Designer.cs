namespace ShScheduler
{
    partial class AddTrigger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTrigger));
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAddTrigger = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTriggerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJobName = new System.Windows.Forms.ComboBox();
            this.txtCronValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cronControl1 = new ShScheduler.Additional.CronControl();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(323, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 455);
            this.panel1.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::ShScheduler.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(929, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1145, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // btnAddTrigger
            // 
            this.btnAddTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAddTrigger.FlatAppearance.BorderSize = 0;
            this.btnAddTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrigger.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrigger.ForeColor = System.Drawing.Color.White;
            this.btnAddTrigger.Location = new System.Drawing.Point(25, 346);
            this.btnAddTrigger.Name = "btnAddTrigger";
            this.btnAddTrigger.Size = new System.Drawing.Size(283, 34);
            this.btnAddTrigger.TabIndex = 4;
            this.btnAddTrigger.Text = "Add";
            this.btnAddTrigger.UseVisualStyleBackColor = false;
            this.btnAddTrigger.Click += new System.EventHandler(this.btnAddTrigger_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(25, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Job";
            // 
            // txtTriggerName
            // 
            this.txtTriggerName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriggerName.Location = new System.Drawing.Point(28, 25);
            this.txtTriggerName.Name = "txtTriggerName";
            this.txtTriggerName.Size = new System.Drawing.Size(400, 31);
            this.txtTriggerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name";
            // 
            // cmbJobName
            // 
            this.cmbJobName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobName.FormattingEnabled = true;
            this.cmbJobName.ItemHeight = 13;
            this.cmbJobName.Location = new System.Drawing.Point(25, 84);
            this.cmbJobName.Name = "cmbJobName";
            this.cmbJobName.Size = new System.Drawing.Size(400, 21);
            this.cmbJobName.TabIndex = 2;
            // 
            // txtCronValue
            // 
            this.txtCronValue.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCronValue.Location = new System.Drawing.Point(29, 133);
            this.txtCronValue.Name = "txtCronValue";
            this.txtCronValue.Size = new System.Drawing.Size(400, 31);
            this.txtCronValue.TabIndex = 3;
            this.txtCronValue.Text = "0 0/1 * 1/1 * ? *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(25, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cron Expression";
            // 
            // cronControl1
            // 
            this.cronControl1.Location = new System.Drawing.Point(29, 170);
            this.cronControl1.MinimumSize = new System.Drawing.Size(0, 130);
            this.cronControl1.Name = "cronControl1";
            this.cronControl1.Size = new System.Drawing.Size(396, 130);
            this.cronControl1.TabIndex = 30;
            this.cronControl1.Value = "0 0/1 * 1/1 * ? *";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(29, 306);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 31;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // AddTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 455);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cronControl1);
            this.Controls.Add(this.txtCronValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbJobName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddTrigger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTriggerName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTrigger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTrigger";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAddTrigger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTriggerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJobName;
        private System.Windows.Forms.TextBox txtCronValue;
        private System.Windows.Forms.Label label5;
        private Additional.CronControl cronControl1;
        private System.Windows.Forms.Button btnGenerate;
    }
}