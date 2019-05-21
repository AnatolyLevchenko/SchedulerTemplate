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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ucAddTrigger));
            this.cbStartNow = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCronValue = new System.Windows.Forms.TextBox();
            this.cmbJobName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTrigger = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTriggerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cronControl1 = new ShScheduler.Additional.CronControl();
            this.SuspendLayout();
            // 
            // cbStartNow
            // 
            resources.ApplyResources(this.cbStartNow, "cbStartNow");
            this.cbStartNow.Name = "cbStartNow";
            this.cbStartNow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Name = "label2";
            // 
            // txtCronValue
            // 
            resources.ApplyResources(this.txtCronValue, "txtCronValue");
            this.txtCronValue.Name = "txtCronValue";
            // 
            // cmbJobName
            // 
            this.cmbJobName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobName.FormattingEnabled = true;
            resources.ApplyResources(this.cmbJobName, "cmbJobName");
            this.cmbJobName.Name = "cmbJobName";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddTrigger
            // 
            this.btnAddTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAddTrigger.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddTrigger, "btnAddTrigger");
            this.btnAddTrigger.ForeColor = System.Drawing.Color.White;
            this.btnAddTrigger.Name = "btnAddTrigger";
            this.btnAddTrigger.UseVisualStyleBackColor = false;
            this.btnAddTrigger.Click += new System.EventHandler(this.btnAddTrigger_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Name = "label4";
            // 
            // txtTriggerName
            // 
            resources.ApplyResources(this.txtTriggerName, "txtTriggerName");
            this.txtTriggerName.Name = "txtTriggerName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Name = "label1";
            // 
            // btnGenerate
            // 
            resources.ApplyResources(this.btnGenerate, "btnGenerate");
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cronControl1
            // 
            resources.ApplyResources(this.cronControl1, "cronControl1");
            this.cronControl1.Name = "cronControl1";
            this.cronControl1.Value = "0 0/1 * 1/1 * ? *";
            // 
            // _ucAddTrigger
            // 
            resources.ApplyResources(this, "$this");
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
