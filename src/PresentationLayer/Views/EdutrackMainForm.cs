
using PresentationLayer.Presenters;
using PresentationLayer.UserControls;
using PresentationLayer.Views;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EdutrackMainForm : Form, IEdutrackMainForm
    {
        public EdutrackMainForm()
        {
            InitializeComponent();
            EdutrackMainFormPresenter.IsAppMaximized = false;
            EdutrackMainFormPresenter.OnTopBarPanelCreated(TopBarPanel);
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

       
        public event TopBarButtonEventHandler WindowExit
        {
            add { _topBarButtonEventHandler += value; }
            remove { _topBarButtonEventHandler -= value; }
        }
        public event TopBarButtonEventHandler WindowMaximized
        {
            add { _topBarButtonEventHandler += value; }
            remove { _topBarButtonEventHandler -= value; }
        }
        public event TopBarButtonEventHandler WindowMinimized
        {
            add { _topBarButtonEventHandler += value; }
            remove { _topBarButtonEventHandler -= value; }
        }
        public event MouseClickedEventHandler MouseClicked
        {
            add { _mouseClickedEventHandler += value; }
            remove { _mouseClickedEventHandler -= value; }
        }
        public static UserControl OpenedUserControl { get; set; }

        //
        // Variables
        //
        private TopBarButtonEventHandler _topBarButtonEventHandler;
        private MouseClickedEventHandler _mouseClickedEventHandler;
    }
}
