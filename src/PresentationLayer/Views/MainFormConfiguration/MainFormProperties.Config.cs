
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Views.MainFormConfiguration
{
    internal partial class MainFormProperties
    {
        internal static void EdutrackMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            MainFormProperties.MouseLocation = new Point(-e.X, -e.Y);
        }

        internal static void EdutrackMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Form form = MainFormProperties.MainForm;
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MainFormProperties.MouseLocation);
                form.Location = mousePose;
            }
        }
        
        internal static Form MainForm { get; set; } 

        internal static Point MouseLocation;
    }
}
