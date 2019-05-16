using System;
using System.Drawing;
using System.Windows.Forms;

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
    }
}
