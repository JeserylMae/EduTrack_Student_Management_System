
using System;
using System.Drawing;
using System.Windows.Forms;
using PresentationLayer.Views;
using PresentationLayer.UserControls;

namespace PresentationLayer.Presenters
{
    internal class EdutrackMainFormPresenter
    {
        public EdutrackMainFormPresenter(IEdutrackMainForm edutrackMainForm)
        {
            _edutrackMainForm = edutrackMainForm;

            _edutrackMainForm.WindowExit      += ExitAppButton_Click; 
            _edutrackMainForm.WindowMaximized += MaximizeAppButton_Click;
            _edutrackMainForm.WindowMinimized += MinimizeAppButton_Click;
            _edutrackMainForm.MouseMoved      += EdutrackMainForm_MouseMove;
            _edutrackMainForm.MousePressed    += EdutrackMainForm_MouseDown;

            _edutrackMainForm.UserControlPage = new LogInPage(_edutrackMainForm);
        }

        private void ExitAppButton_Click(object sender, EventArgs e)
            => Application.Exit();

        private void MinimizeAppButton_Click(object sender, EventArgs e)
        {
            if (_edutrackMainForm.FormWindowState != FormWindowState.Minimized)
                _edutrackMainForm.FormWindowState = FormWindowState.Minimized;
            else
                _edutrackMainForm.FormWindowState = FormWindowState.Normal;
        }

        private void MaximizeAppButton_Click(object sender, EventArgs e)
        {
            if (_edutrackMainForm.IsAppMaximized)
            {
                int height = 720, width = 1280;

                _edutrackMainForm.FormWidth         = width;
                _edutrackMainForm.FormHeight        = height;
                _edutrackMainForm.IsAppMaximized    = false;
                _edutrackMainForm.FormStartPosition = FormStartPosition.CenterScreen;
                _edutrackMainForm.LeftPosition      = (int)((Screen.PrimaryScreen.WorkingArea.Width / 2) - (width / 2));
                _edutrackMainForm.TopPosition       = (int)((Screen.PrimaryScreen.WorkingArea.Height / 2) - (height / 2));
            }
            else
            {
                _edutrackMainForm.LeftPosition = _edutrackMainForm.TopPosition = 0;

                _edutrackMainForm.FormWidth      = Screen.PrimaryScreen.WorkingArea.Width;
                _edutrackMainForm.FormHeight     = Screen.PrimaryScreen.WorkingArea.Height;
                _edutrackMainForm.IsAppMaximized = true;
            }
        }

        private void EdutrackMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void EdutrackMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;

                mousePose.Offset(MouseLocation);
                _edutrackMainForm.WindowLocation = mousePose;
            }
        }


        internal Point MouseLocation;
        private IEdutrackMainForm _edutrackMainForm;
    }
}
