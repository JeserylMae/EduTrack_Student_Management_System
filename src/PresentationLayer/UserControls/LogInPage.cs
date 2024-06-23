
using System;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class LogInPage : UserControl
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            // Declare a bool: UserExisting = false.
            // Declare a string: UserPosition = string.Empty;
            
            // if user exists change the UserExisting to True in the methos VerifyUserExistence.
            ////////// VerifyUserExistence(EmailAddressTextbox.Text, PasswordTextbox.Text);

            ////////// InitializeUserHomePage();
            // Contains if - else statements and the functions which invokes the method
            // that initializes the home page for each positions.

            // if user does not exist.
            // instanciate new CustomMessageBox() form and display the error.
        }
    }
}
