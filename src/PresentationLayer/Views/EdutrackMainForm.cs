
using PresentationLayer.Views;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EdutrackMainForm : Form, IEdutrackMainForm
    {
        public EdutrackMainForm()
        {
            InitializeComponent();
            IsAppMaximized = false;
            
            OnTopBarPanelCreated(TopBarPanel);
            _ = AppMainPanelEventSubscriber();
            _ = InitializeTopBarButtonSubscribers();
            
            InitializeLogInPage();
        }


        // ######################################################
        //                  CHANGE THIS PART
        // ######################################################
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
        // ######################################################
        //                      UNTIL HERE
        // ######################################################


        public bool IsAppMaximized  { get;           set;                   }
        public int TopPosition      { get => Top;    set => Top = value;    }
        public int LeftPosition     { get => Left;   set => Left = value;   }
        public int FormWidth        { get => Width;  set => Width = value;  }
        public int FormHeight       { get => Height; set => Height = value; }
        public Point WindowLocation { get => Location; set => Location = value; }
        public static UserControl OpenedUserControl { get; set; }
        public FormStartPosition FormStartPosition  { get => StartPosition; set => StartPosition = value; }
        public FormWindowState FormWindowState      { get => WindowState;   set => WindowState = value;   }


        public event EventHandler WindowExit;
        public event EventHandler WindowMaximized;
        public event EventHandler WindowMinimized;
        public event MouseEventHandler MouseMoved;
        public event MouseEventHandler MousePressed;
        

        internal TaskCompletionSource<bool> TopBarCreated = new TaskCompletionSource<bool>();
    }
}
