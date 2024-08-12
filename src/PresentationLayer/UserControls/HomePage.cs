
using PresentationLayer.UserControls.HomeSubControls;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();

            ItrHomeRightControl homeRightControl = new ItrHomeRightControl();
            RightPanel.Controls.Add(homeRightControl);
            RightPanel.Show();
        }
    }
}
