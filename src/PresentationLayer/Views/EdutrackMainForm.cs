
using PresentationLayer.UserControls;
using PresentationLayer.Views.MainFormConfiguration;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EdutrackMainForm : Form
    {
        public EdutrackMainForm()
        {
            InitializeComponent();
            TopBarButtonFunction.IsAppMaximized = false;
            MainFormProperties.OnTopBarPanelCreated(TopBarPanel);
            _ = AppMainPanelEventSubscriber();
            InitializeLogInPage();
        }

        private void AddNewUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            AppPagesHolderPanel.Controls.Clear();
            AppPagesHolderPanel.Controls.Add(userControl);
            userControl.BringToFront();
            EdutrackMainForm.OpenedUserControl = userControl;
        }

        private void InitializeLogInPage()
        {
            LogInPage logInPage = new LogInPage();
            AddNewUserControl(logInPage);
        }


        internal static UserControl OpenedUserControl { get; set; }
    }
}
