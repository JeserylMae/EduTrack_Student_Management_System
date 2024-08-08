using System;
using System.Windows;
using PresentationLayer.Views;
using PresentationLayer.UserControls;


namespace PresentationLayer.Presenters
{
    public class LogInPagePresenter
    {
        public LogInPagePresenter(ILogInPage logInPage, IEdutrackMainForm edutrackMainForm)
        {
            _logInPage = logInPage;
            _edutrackMainForm = edutrackMainForm;
            _logInPage.LoggedIn += LogInButton_Clicked;
            _edutrackMainForm.EnableMaximizeAppButton = false;
        }

        private void LogInButton_Clicked(object sender, EventArgs e) 
        {
            try
            {
                string e_UserId          = _logInPage.GetUserId;
                string e_EmailAddress    = _logInPage.GetEmailAddress;
                string e_AccountPassword = _logInPage.GetPassword;

                Console.WriteLine($"User ID: {e_UserId}");
                Console.WriteLine($"Email Address: {e_EmailAddress}");
                Console.WriteLine($"Password: {e_AccountPassword}");
                
                // position must be obtained from the db, if returned null then user is not yet registered.

                // IUserModel user = new UserModel();

                _edutrackMainForm.EnableMaximizeAppButton = true;
                //EdutrackUserServices edutrackUserServices = new EdutrackUserServices();
                //IEnumerable<string> UserCredentials = edutrackUserServices.GetByID(_logInPage.GetEmailAddress);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButton.OK);
            }

            // Check user existence.
            // EXISTING: get user credentials.
            // NOT: throw error.

            // Verify password.
            // MATCH: Get user position.
            // NOT: throw error.

            // Redirect user to home page.
            // ADMIN: initialize admin home page.
            // STUDENT: initialize student home page.
            // INSTRUCTOR: initialize instructor home page.
        }

        ILogInPage _logInPage;
        private IEdutrackMainForm _edutrackMainForm;
    }
}
