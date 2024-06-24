
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Presenters
{
    internal class EdutrackMainFormPresenter
    {
        internal static void ExitAppButton_Click(Form form, object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal static void MinimizeAppButton_Click(Form form, object sender, EventArgs e)
        {
            if (form.WindowState != FormWindowState.Minimized)
                form.WindowState = FormWindowState.Minimized;
            else
                form.WindowState = FormWindowState.Normal;
        }

        internal static void MaximizeAppButton_Click(Form form, object sender, EventArgs e)
        {
            if (EdutrackMainFormPresenter.IsAppMaximized)
            {
                int height = 720, width = 1280;
                form.ClientSize = new System.Drawing.Size(width, height);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Top = (int)((Screen.PrimaryScreen.WorkingArea.Height / 2) - (height / 2));
                form.Left = (int)((Screen.PrimaryScreen.WorkingArea.Width / 2) - (width / 2));
                EdutrackMainFormPresenter.IsAppMaximized = false;
            }
            else
            {
                form.Left = form.Top = 0;
                form.Width = Screen.PrimaryScreen.WorkingArea.Width;
                form.Height = Screen.PrimaryScreen.WorkingArea.Height;
                EdutrackMainFormPresenter.IsAppMaximized = true;
            }
        }

        internal static void OnTopBarPanelCreated(Panel TopBarPanel)
        {
            if (TopBarPanel != null)
                EdutrackMainFormPresenter.TopBarCreated.TrySetResult(true);
        }

        internal static void EdutrackMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            EdutrackMainFormPresenter.MouseLocation = new Point(-e.X, -e.Y);
        }

        internal static void EdutrackMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Form form = EdutrackMainFormPresenter.MainForm;
                Point mousePose = Control.MousePosition;
                mousePose.Offset(EdutrackMainFormPresenter.MouseLocation);
                form.Location = mousePose;
            }
        }

        internal static Form MainForm { get; set; }

        internal static Point MouseLocation;

        internal static TaskCompletionSource<bool> TopBarCreated = new TaskCompletionSource<bool>();
        internal static bool IsAppMaximized;
    }
}
