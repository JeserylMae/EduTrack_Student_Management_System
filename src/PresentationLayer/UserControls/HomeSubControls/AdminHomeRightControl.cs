
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.UserControls.HomeSubControls
{
    public partial class AdminHomeRightControl : UserControl, IAdminHomeRightControl
    {
        public AdminHomeRightControl()
        {
            InitializeComponent();
            OnRightPanelButtonCreated();
            _ = InitializeRightPanelButton();
        }

        public void DestroyControl() { this.Dispose(); }
        public event EventHandler CourseInfoButtonClicked;
        public event EventHandler ItrAcadInfoButtonClicked;
        public event EventHandler StudAcadInfoButtonClicked;
        public event EventHandler ItrPersonalInfoButtonClicked;
        public event EventHandler StudPersonalInfoButtonClicked;

        private TaskCompletionSource<bool> CourseInfoButtonCreated       = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> ItrAcadInfoButtonCreated      = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> StudAcadInfoButtonCreated     = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> ItrPersonalInfoButtonCreated  = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> StudPersonalInfoButtonCreated = new TaskCompletionSource<bool>();
    }
}
