
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class SplashScreen : Form, ISplashScreen
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        public void ShowForm() => this.Show();
        public void CloseForm() { this.Show(); this.Dispose(); }

        public void SetFormLocation(Point ParentLocation, Size ParentSize)        
        {
            int x =  ParentLocation.X + (ParentSize.Width/2 - this.Width/2);
            int y = ParentLocation.Y + (ParentSize.Height/2 - this.Height/2);

            this.Location = new System.Drawing.Point(x, y);
        }
    }
}
