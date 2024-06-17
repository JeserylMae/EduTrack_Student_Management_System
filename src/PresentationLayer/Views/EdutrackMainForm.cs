using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EdutrackMainForm : Form
    {
        public EdutrackMainForm()
        {
            InitializeComponent();
        }

        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeAppButton_Click(object sender, EventArgs e)
        {
            if (IsAppMaximized)
            {
                this.ClientSize = new System.Drawing.Size(1280, 720);
                this.CenterToScreen();
            }
            else
            {
                this.Left = this.Top = 0;
                this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                this.Height = Screen.PrimaryScreen.WorkingArea.Height; 
                IsAppMaximized = true;
            }
        }

        private void MinimizeAppButton_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
            else
                this.WindowState= FormWindowState.Normal;
        }

        private void EdutrackMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private Point mouseLocation;

        private void EdutrackMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation);
                Location = mousePose;
            }
        }
    }
}
