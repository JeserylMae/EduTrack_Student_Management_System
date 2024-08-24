
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.Views
{
    public partial class EdutrackMainForm : Form, IEdutrackMainForm
    {
        public EdutrackMainForm(IServerInfoForm serverInfoForm)
        {
            InitializeComponent();
            IsAppMaximized = false;
            _serverInfoForm = serverInfoForm;

            OnTopBarPanelCreated(TopBarPanel);
            _ = AppMainPanelEventSubscriber();
            _ = InitializeTopBarButtonSubscribers();

            //MaximizeAppbutton.Enabled = false;
            //WindowState = FormWindowState.Normal;
            //RunServerForm();
            MaximizeAppbutton.Enabled = true;
            WindowState = FormWindowState.Normal;
        }

        public UserControl UserControlPage
        {
            get { return _userControl; }
            set {
                if (_userControl != null) TerminateUserControl();

                _userControl = value;
                _userControl.Dock = DockStyle.Fill;
                AppPagesHolderPanel.Controls.Add(_userControl);
                _userControl.BringToFront();
            }
        }

        public void SetWindowToMaximized()
        {
            WindowMaximized(this, EventArgs.Empty);
        }

        public string ConnectionString { get;             set;                     }
        public bool IsAppMaximized     { get;             set;                     }
        public int TopPosition         { get => Top;      set => Top = value;      }
        public int LeftPosition        { get => Left;     set => Left = value;     }
        public int FormWidth           { get => Width;    set => Width = value;    }
        public int FormHeight          { get => Height;   set => Height = value;   }
        public Point WindowLocation    { get => Location; set => Location = value; }
        public static UserControl OpenedUserControl { get;                  set;                          }
        public FormStartPosition FormStartPosition  { get => StartPosition; set => StartPosition = value; }
        public FormWindowState FormWindowState      { get => WindowState;   set => WindowState = value;   }
        public bool EnableMaximizeAppButton         { get => MaximizeAppbutton.Enabled; set => MaximizeAppbutton.Enabled = value; }

        public event EventHandler WindowExit;
        public event EventHandler WindowMaximized;
        public event EventHandler WindowMinimized;
        public event MouseEventHandler MouseMoved;
        public event MouseEventHandler MousePressed;

        private UserControl _userControl;
        private IServerInfoForm _serverInfoForm;
        private TaskCompletionSource<bool> TopBarCreated = new TaskCompletionSource<bool>();
    }
}
