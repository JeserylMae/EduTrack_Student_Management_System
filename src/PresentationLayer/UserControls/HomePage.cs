
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class HomePage : UserControl, IHomePage
    {
        public HomePage()
        {
            InitializeComponent();
            OnLoggoutButtonCreated(LogoutButton);
            _ = InitializeLogoutButtonSubscriber();    
        }

        public UserControl RightUserControlPage 
        { 
            get { return _rightUserControl; }
            set
            {
                if (_rightUserControl != null) TerminateRightUserControl();

                _rightUserControl = value;
                RightPanel.Controls.Add(value);
                _rightUserControl.BringToFront();
            }
        }

        public UserControl BottomUserControlPage
        {
            get { return _bottomUserControl; }
            set
            {
                if ( _bottomUserControl != null ) TerminateBottomUserControl();

                _bottomUserControl = value;
                BottomPanel.Controls.Add(value);
                _bottomUserControl.BringToFront();
            }
        }

        public event EventHandler LoggedOut;
        public void DestroyControl() { this.Dispose(); }

        private UserControl _rightUserControl;
        private UserControl _bottomUserControl;
        private TaskCompletionSource<bool> LogoutButtonCreated = new TaskCompletionSource<bool>();
    }
}
