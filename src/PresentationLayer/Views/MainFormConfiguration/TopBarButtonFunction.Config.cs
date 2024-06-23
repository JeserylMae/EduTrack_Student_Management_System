
using System;
using System.Windows.Forms;


namespace PresentationLayer.Views.MainFormConfiguration
{
    internal partial class TopBarButtonFunction
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
            if (TopBarButtonFunction.IsAppMaximized)
            {
                int height = 720, width = 1280;
                form.ClientSize = new System.Drawing.Size(width, height);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Top = (int)((Screen.PrimaryScreen.WorkingArea.Height / 2) - (height / 2));
                form.Left = (int)((Screen.PrimaryScreen.WorkingArea.Width / 2) - (width / 2));
                TopBarButtonFunction.IsAppMaximized = false;
            }
            else
            {
                form.Left = form.Top = 0;
                form.Width = Screen.PrimaryScreen.WorkingArea.Width;
                form.Height = Screen.PrimaryScreen.WorkingArea.Height;
                TopBarButtonFunction.IsAppMaximized = true;
            }
        }

        internal static bool IsAppMaximized;
    }
}