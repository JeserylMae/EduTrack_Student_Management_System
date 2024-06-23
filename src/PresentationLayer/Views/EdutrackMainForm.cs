
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

        private void TopBarButton(object sender, EventArgs e)
        {
            TopBarButtonFunction topBarButtonFunction = new TopBarButtonFunction();
            bool ShouldNotTriggerClick = false;

            if (!(sender is Button clickedButton))  return;
            
            switch (clickedButton.Name)
            {
                case "ExitAppButton":
                    topBarButtonFunction.TopBarButtonClicked += TopBarButtonFunction.ExitAppButton_Click;
                    break;
                case "MaximizeAppbutton":
                    topBarButtonFunction.TopBarButtonClicked += TopBarButtonFunction.MaximizeAppButton_Click;
                    break;
                case "MinimizeAppButton":
                    topBarButtonFunction.TopBarButtonClicked += TopBarButtonFunction.MinimizeAppButton_Click;
                    break;
                default:
                    ShouldNotTriggerClick = true;
                    break;
            }

            if (!ShouldNotTriggerClick) topBarButtonFunction.Clicked(this);
        }

        private async Task AppMainPanelEventSubscriber()
        {
            await MainFormProperties.TopBarCreated.Task;

            MainFormProperties.MainForm = this;
            TopBarPanel.MouseDown += new MouseEventHandler(MainFormProperties.EdutrackMainForm_MouseDown);
            TopBarPanel.MouseMove += new MouseEventHandler(MainFormProperties.EdutrackMainForm_MouseMove);
        }

        internal static UserControl OpenedUserControl { get; set; }
    }
}
