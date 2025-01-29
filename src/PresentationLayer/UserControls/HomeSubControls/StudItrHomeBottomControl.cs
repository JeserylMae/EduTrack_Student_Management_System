
using PresentationLayer.Presenters.Enumerations;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.HomeSubControls
{
    public partial class StudItrHomeBottomControl : UserControl, IStudItrHomeBottomControl
    {
        public StudItrHomeBottomControl()
        {
            GradeButtonCreated       = new TaskCompletionSource<bool>();
            AttendanceButtonCreated  = new TaskCompletionSource<bool>();
            StudentInfoButtonCreated = new TaskCompletionSource<bool>();

            InitializeComponent();
            InitializeElementsCreated();
            _ = InitializeEventSubscriber();
        }

        public AccessType AccessCurrentUser { get; set; }

        public event EventHandler GradeButtonClicked;
        public event EventHandler AttendanceButtonClicked;
        public event EventHandler StudentInfoButtonClicked;

        public void DestroyControl() { this.Dispose(); }


        private TaskCompletionSource<bool> GradeButtonCreated;
        private TaskCompletionSource<bool> AttendanceButtonCreated;
        private TaskCompletionSource<bool> StudentInfoButtonCreated;
    }
}
