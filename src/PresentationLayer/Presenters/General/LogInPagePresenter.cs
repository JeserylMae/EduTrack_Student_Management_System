
using System;
using PresentationLayer.Views;
using PresentationLayer.UserControls.MainControls;
using DomainLayer.DataModels;
using ServiceLayer.Database;
using PresentationLayer.UserControls.HomeSubControls;
using System.Windows.Forms;
using PresentationLayer.Presenters.Admin;
using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.Presenters.StudItr;


namespace PresentationLayer.Presenters.General
{
    public class LogInPagePresenter
    {
        public LogInPagePresenter(ILogInPage logInPage)
        {
            _logInPage          =  logInPage;
            _edutrackMainForm   =  EdutrackMainForm.GetInstance();

            _logInPage.LoggedIn += LogInButton_Clicked;
        }

        private async void LogInButton_Clicked(object sender, EventArgs e) 
        {
            try
            { 
                PRUserModel e_User       = new PRUserModel();
                e_User.UserID          = _logInPage.GetUserId;
                e_User.EmailAddress    = _logInPage.GetEmailAddress;
                e_User.AccountPassword = _logInPage.GetPassword;

                UserServices services = new UserServices();
                PRUserModel User = await services.GetUserByID(e_User.UserID);

                ValidateUser(ref User, ref e_User);

                _edutrackMainForm.EnableMaximizeAppButton = true;
                _edutrackMainForm.SetWindowToMaximized();

                RedirectToUserPage(ref User);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(
                    ex.Message, 
                    "LOGIN - ERROR", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
        }

        private void RedirectToUserPage(ref PRUserModel User)
        {
            HomePage homePage = new HomePage();
            new HomePagePresenter(homePage);

            if (User.Position == "ADMIN")
            {
                IAdminHomeRightControl adminHomeRightControl = new AdminHomeRightControl();
                new AdminHomeRightPresenter(adminHomeRightControl);

                homePage.RightUserControlPage = (UserControl)adminHomeRightControl;
            }
            else if (User.Position == "INSTRUCTOR" || User.Position == "STUDENT")
            {
                IStudItrHomeRightControl rightControl   = new StudItrHomeRightControl();
                StudItrHomeBottomControl bottomControl = new StudItrHomeBottomControl();

                SetHomeRightControlProperties(User, ref rightControl);

                new StudItrHomeRightPresenter(rightControl);

                homePage.RightUserControlPage = (UserControl)rightControl;
                homePage.BottomUserControlPage = (UserControl)bottomControl;
            }

            _logInPage.DisposeForm();
            GeneralPresenter.NewWindowControl = homePage;
            GeneralPresenter.TriggerWindowControlChange(null, EventArgs.Empty);
        }


        #region Helpers
        private void ValidateUser(ref PRUserModel User, ref PRUserModel e_User)
        {
            if (User == null)
                throw new Exception($"No user with id {e_User.UserID} found.");

            if (User.AccountPassword != e_User.AccountPassword)
            {
                throw new Exception("Password is incorrect.");
            }

            if (User.EmailAddress != e_User.EmailAddress)
                throw new Exception("Email address is incorrect.");
        }
        
        private void SetHomeRightControlProperties(PRUserModel user, 
                        ref IStudItrHomeRightControl rightControl)
        {
            rightControl.CurrentUserId = user.UserID;
            rightControl.CurrentUserType = (user.Position == "STUDENT")
                                         ? AccessType.STUDENT
                                         : AccessType.INSTRUCTOR;
        }
        #endregion


        ILogInPage _logInPage;
        private IEdutrackMainForm _edutrackMainForm;
    }
}
