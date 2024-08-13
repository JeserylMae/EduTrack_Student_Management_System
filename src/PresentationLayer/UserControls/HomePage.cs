
using PresentationLayer.UserControls.HomeSubControls;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();

            AdminHomeRightControl adminHomeRightControl = new AdminHomeRightControl();
            StudItrHomeBottomControl bottomControl = new StudItrHomeBottomControl();
            RightPanel.Controls.Add(adminHomeRightControl);
            BottomPanel.Controls.Add(bottomControl);    
        }
    }
}
