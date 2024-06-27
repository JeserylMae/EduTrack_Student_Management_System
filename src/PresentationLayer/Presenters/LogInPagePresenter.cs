using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PresentationLayer.Presenters
{
    public class LogInPagePresenter
    {
        public LogInPagePresenter(ILogInPage logInPage, IEdutrackMainForm edutrackMainForm)
        {
            _logInPage = logInPage;
            _edutrackMainForm = edutrackMainForm;

            _logInPage.LoggedIn += LogInButton_Clicked;
        }

        private void LogInButton_Clicked(object sender, EventArgs e) 
        {
            try
            {
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
