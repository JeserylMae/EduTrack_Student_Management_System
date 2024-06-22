
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Views.MainFormConfiguration
{
    internal partial class MainFormProperties
    {
        internal static void EdutrackMainForm_MouseDown(Form form, object sender, MouseEventArgs e)
        {
            MainFormProperties.MouseLocation = new Point(-e.X, -e.Y);
        }

        internal static void EdutrackMainForm_MouseMove(Form form, object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MainFormProperties.MouseLocation);
                form.Location = mousePose;
            }
        }

        internal static Point MouseLocation;
    }
}
