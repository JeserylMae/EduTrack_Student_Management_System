
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.UserControls.AdminSubControls
{
    public partial class PersonalInfoControl : UserControl, IPersonalInfoControl
    {
        public PersonalInfoControl()
        {
            InitializeComponent();
            SetYearOptions();
            InitializeButtonsAsHidden();
        }

        public void ShowAddButton()    { SubmitAddButton.Show();    }
        public void ShowUpdateButton() { SubmitUpdateButton.Show(); }

        public event EventHandler AddNewStudentInfoSubmit;
        public event EventHandler UpdateStudentInfoSubmit;

        private TaskCompletionSource<bool> SubmitAddInfoButtonCreated = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> SubmitUpdateInfoButtonCreated = new TaskCompletionSource<bool>();
    }
}
