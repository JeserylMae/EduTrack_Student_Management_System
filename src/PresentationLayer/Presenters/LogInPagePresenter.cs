using System;
using System.Windows;
using PresentationLayer.Views;
using PresentationLayer.UserControls;
using DomainLayer.DataModels;
using ServiceLayer.Database;
using PresentationLayer.UserControls.HomeSubControls;


namespace PresentationLayer.Presenters
{
    public class LogInPagePresenter
    {
        public LogInPagePresenter(ILogInPage logInPage, IEdutrackMainForm edutrackMainForm)
        {
            _logInPage          =  logInPage;
            _edutrackMainForm   =  edutrackMainForm;
            _logInPage.LoggedIn += LogInButton_Clicked;
        }

        private async void LogInButton_Clicked(object sender, EventArgs e) 
        {
            try
            {
                UserModel e_User = new UserModel();
                e_User.UserID          = _logInPage.GetUserId;
                e_User.EmailAddress    = _logInPage.GetEmailAddress;
                e_User.AccountPassword = _logInPage.GetPassword;

                UserServices services = new UserServices();
                UserModel User = await services.GetUserByID(e_User.UserID);

                ValidateUser(ref User, ref e_User);
                
                _edutrackMainForm.EnableMaximizeAppButton = true;
                RedirectToUserPage(ref User);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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

        private void RedirectToUserPage(ref UserModel User)
        {
            HomePage homePage = new HomePage();

            if (User.Position == "ADMIN")
            {
                homePage.RightUserControlPage = new AdminHomeRightControl();
            }
            else if (User.Position == "INSTRUCTOR" || User.Position == "STUDENT")
            {
                homePage.RightUserControlPage = new StudItrHomeRightControl();
                homePage.BottomUserControlPage = new StudItrHomeBottomControl();
            }

            _logInPage.DisposeForm();
            _edutrackMainForm.UserControlPage = homePage;
        }

        private void ValidateUser(ref UserModel User, ref UserModel e_User)
        {
            if (User == null)
                throw new Exception($"No user with id {e_User.UserID} found.");
            
            if (User.AccountPassword != e_User.AccountPassword)
                throw new Exception("Incorrect password.");

            if (User.EmailAddress != e_User.EmailAddress)
                throw new Exception("Incorrect email address.");
        }

        ILogInPage _logInPage;
        private IEdutrackMainForm _edutrackMainForm;
    }
}
