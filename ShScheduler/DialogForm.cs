using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShScheduler
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
            this.mainPanel.Dock = DockStyle.Fill;
        }

        private void DialogForm_Shown(object sender, EventArgs e)
        {
          var controls=this.mainPanel.Controls.OfType<UserControl>();
            foreach (UserControl control in controls)
            {
                var text = control.Controls.OfType<TextBox>().OrderBy(c => c.TabIndex).FirstOrDefault();
                if (text != null)
                    text.Focus();
            }
        }
    }
}
