namespace ShScheduler.UserControls
{
    partial class _ucAddTrigger
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
            this.cbStartNow = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cronControl1 = new ShScheduler.Additional.CronControl();
            this.txtCronValue = new System.Windows.Forms.TextBox();
            this.cmbJobName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTrigger = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTriggerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbStartNow
            // 
            this.cbStartNow.AutoSize = true;
            this.cbStartNow.Location = new System.Drawing.Point(71, 124);
            this.cbStartNow.Name = "cbStartNow";
            this.cbStartNow.Size = new System.Drawing.Size(15, 14);
            this.cbStartNow.TabIndex = 44;
            this.cbStartNow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Start now";
            // 
            // cronControl1
            // 
            this.cronControl1.Location = new System.Drawing.Point(12, 203);
            this.cronControl1.MinimumSize = new System.Drawing.Size(0, 130);
            this.cronControl1.Name = "cronControl1";
            this.cronControl1.Size = new System.Drawing.Size(396, 130);
            this.cronControl1.TabIndex = 42;
            this.cronControl1.Value = "0 0/1 * 1/1 * ? *";
            // 
            // txtCronValue
            // 
            this.txtCronValue.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCronValue.Location = new System.Drawing.Point(16, 156);
            this.txtCronValue.Name = "txtCronValue";
            this.txtCronValue.Size = new System.Drawing.Size(400, 31);
            this.txtCronValue.TabIndex = 37;
            this.txtCronValue.Text = "0 0/1 * 1/1 * ? *";
            // 
            // cmbJobName
            // 
            this.cmbJobName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobName.FormattingEnabled = true;
            this.cmbJobName.ItemHeight = 13;
            this.cmbJobName.Location = new System.Drawing.Point(12, 87);
            this.cmbJobName.Name = "cmbJobName";
            this.cmbJobName.Size = new System.Drawing.Size(400, 21);
            this.cmbJobName.TabIndex = 36;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(306, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 34);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddTrigger
            // 
            this.btnAddTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAddTrigger.FlatAppearance.BorderSize = 0;
            this.btnAddTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrigger.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrigger.ForeColor = System.Drawing.Color.White;
            this.btnAddTrigger.Location = new System.Drawing.Point(11, 382);
            this.btnAddTrigger.Name = "btnAddTrigger";
            this.btnAddTrigger.Size = new System.Drawing.Size(283, 34);
            this.btnAddTrigger.TabIndex = 38;
            this.btnAddTrigger.Text = "Add";
            this.btnAddTrigger.UseVisualStyleBackColor = false;
            this.btnAddTrigger.Click += new System.EventHandler(this.btnAddTrigger_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Job";
            // 
            // txtTriggerName
            // 
            this.txtTriggerName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriggerName.Location = new System.Drawing.Point(15, 28);
            this.txtTriggerName.Name = "txtTriggerName";
            this.txtTriggerName.Size = new System.Drawing.Size(400, 31);
            this.txtTriggerName.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Name";
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(12, 339);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 45;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // _ucAddTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cbStartNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cronControl1);
            this.Controls.Add(this.txtCronValue);
            this.Controls.Add(this.cmbJobName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTrigger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTriggerName);
            this.Controls.Add(this.label1);
            this.Name = "_ucAddTrigger";
            this.Size = new System.Drawing.Size(432, 431);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbStartNow;
        private System.Windows.Forms.Label label2;
        private Additional.CronControl cronControl1;
        private System.Windows.Forms.TextBox txtCronValue;
        private System.Windows.Forms.ComboBox cmbJobName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTrigger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTriggerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
    }
}
