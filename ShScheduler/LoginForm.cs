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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            var pan = sender as PictureBox;
            pan.BackColor = Color.Red;
        }
    }
}
