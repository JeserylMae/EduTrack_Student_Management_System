
using PresentationLayer.UserControls.AdminSubControls;
using System.Windows.Forms;


namespace PresentationLayer.UserControls
{
    public partial class AdminModifyInfoControl : UserControl
    {
        public AdminModifyInfoControl()
        {
            InitializeComponent();
            InitializeInfoTable();

            UserControl userControl = new PersonalInfoControl();
            MainControlHolder.Controls.Add(userControl);
            userControl.Dock = DockStyle.Left;
        }
    }
}
