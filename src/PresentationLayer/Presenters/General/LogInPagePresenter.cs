﻿
using System;
using PresentationLayer.Views;
using PresentationLayer.UserControls.MainControls;
using DomainLayer.DataModels;
using ServiceLayer.Database;
using PresentationLayer.UserControls.HomeSubControls;
using System.Windows.Forms;
using PresentationLayer.Presenters.Admin;


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
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(
                    "Ensure all credentials are correct.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                homePage.RightUserControlPage = new StudItrHomeRightControl();
                homePage.BottomUserControlPage = new StudItrHomeBottomControl();
            }

            _logInPage.DisposeForm();
            GeneralPresenter.NewWindowControl = homePage;
            GeneralPresenter.TriggerWindowControlChange(null, EventArgs.Empty);
        }

        private void ValidateUser(ref PRUserModel User, ref PRUserModel e_User)
        {
            if (User == null)
                throw new Exception($"No user with id {e_User.UserID} found.");

            if (User.AccountPassword != e_User.AccountPassword)
            {
                Console.WriteLine("User: " + User.AccountPassword);
                Console.WriteLine("e_User: " + e_User.AccountPassword);
                throw new Exception("Incorrect password.");
            }

            if (User.EmailAddress != e_User.EmailAddress)
                throw new Exception("Incorrect email address.");
        }

        ILogInPage _logInPage;
        private IEdutrackMainForm _edutrackMainForm;
    }
}
