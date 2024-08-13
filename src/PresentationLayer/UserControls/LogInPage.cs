
using PresentationLayer.Presenters;
using PresentationLayer.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class LogInPage : UserControl, ILogInPage
    {
        public LogInPage(IEdutrackMainForm edutrackMainForm)
        {
            InitializeComponent();
            OnLogInButtonCreated(LogInButton);

            _ = InitializeButtonSubscriber();
            _edutrackMainForm = edutrackMainForm;

            new LogInPagePresenter(this, _edutrackMainForm);
        }

        public void DisposeForm() { this.Dispose(); }

        public string GetUserId       { get => UserIdTextbox.Text;       }
        public string GetPassword     { get => PasswordTextbox.Text;     }
        public string GetEmailAddress { get => EmailAddressTextbox.Text; }

        public event EventHandler LoggedIn;
        private IEdutrackMainForm _edutrackMainForm;
        private TaskCompletionSource<bool> LogInButtonCreated = new TaskCompletionSource<bool>();










        // Events
        // public event EventHandler LoggedIn;
        // Please remember that the definition or the method to be invoked by this 
        // event should be placed in the presenters forlder.
        // file name should be `LogInPagePresenter`.





        //  private void LogInButton_Click(object sender, EventArgs e)
        //  {


        // Declare a bool: UserExisting = false.
        // Declare a string: UserPosition = string.Empty;

        // if user exists change the UserExisting to True in the methos VerifyUserExistence.
        ////////// VerifyUserExistence(EmailAddressTextbox.Text, PasswordTextbox.Text);

        ////////// InitializeUserHomePage();
        // Contains if - else statements and the functions which invokes the method
        // that initializes the home page for each positions.

        // if user does not exist.
        // instanciate new CustomMessageBox() form and display the error.
        // }
    }
}
