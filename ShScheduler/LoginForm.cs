using System;
using System.Drawing;
using System.Windows.Forms;
using ShData;
using ShScheduler.Helpers;
using ShScheduler.Properties;

namespace ShScheduler
{
    public partial class LoginForm : Form
    {
        private bool _dragging;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;
        public LoginForm()
        {
            InitializeComponent();
            MouseDown += LoginForm_MouseDown;
            MouseMove += LoginForm_MouseMove;
            MouseUp += LoginForm_MouseUp;

            panel1.MouseDown += LoginForm_MouseDown;
            panel1.MouseMove += LoginForm_MouseMove;
            panel1.MouseUp += LoginForm_MouseUp;
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                this.Location = Point.Add(_dragFormPoint, new Size(dif));
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = this.Location;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            var pan = sender as PictureBox;
            pan.BackColor = Color.Red;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.RememberMe)
            {
                if (Authorize(Settings.Default.Login, Settings.Default.Password))
                {
                    ////save login of user to Singleton instance and close form
                    //LoggedUser.GetInstance(Settings.Default.Login);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    FillLastLogged();
                }
            }

            else
            {
                FillLastLogged();
            }
        }
        private void FillLastLogged()
        {
            if (!string.IsNullOrEmpty(Settings.Default.LastLoggedUser))
            {
                txtLogin.Text = Settings.Default.LastLoggedUser;
                txtPass.Select();
            }
        }

        bool Authorize(string login, string password)
        {
            try
            {
                var result= DataAccess.Authorize(login, password);
                if (result == null)
                    return false;
                User.IsAdmin = result.IsAdmin;
                User.Name = result.Login;
                User.Email = result.Email;
                return true;
            }
            catch (Exception e)
            {
                MessageHelper.DisplayError(e.Message);
                return false;
            }
        }

        private void SaveToSetting(string login, string password)
        {
            Settings.Default.Login = login;
            Settings.Default.Password = password;
            Settings.Default.RememberMe = true;
            Settings.Default.Save();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Authorize(txtLogin.Text, txtPass.Text))
            {
                if (cbRememberMe.Checked)
                    SaveToSetting(txtLogin.Text, txtPass.Text);

                Settings.Default.LastLoggedUser = txtLogin.Text;
                Settings.Default.Save();
                DialogResult = DialogResult.OK;

                //save login of user to Singleton instance
                //LoggedUser.GetInstance(txtLogin.Text);


            }
            else
            {
                MessageHelper.DisplayError("Authorization failed");
            }
        }

        private void lbRemember_Click(object sender, EventArgs e)
        {
            cbRememberMe.Checked = !cbRememberMe.Checked;
        }
    }
}
