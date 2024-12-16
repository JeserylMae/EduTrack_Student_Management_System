using PresentationLayer.UserControls.MainControls;
using PresentationLayer.Views;
using System;
using System.Windows.Forms;


namespace PresentationLayer.Presenters
{
    internal class HomePagePresenter
    {
        internal HomePagePresenter(IHomePage homePage) 
        {
            _homePage = homePage;
            _edutrackMainForm = EdutrackMainForm.GetInstance();

            _homePage.LoggedOut += LogoutButton_Clicked;
        }

        internal void LogoutButton_Clicked(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log-out?", "Edutrack", 
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _homePage.DestroyControl();
                     
                ILogInPage logInPage = new LogInPage();
                new LogInPagePresenter(logInPage);
                    
                GeneralPresenter.NewWindowControl = (UserControl) logInPage;
                GeneralPresenter.TriggerWindowControlChange(sender, e);

                _edutrackMainForm.SetWindowToMaximized();
            }
        }


        private IHomePage _homePage;
        private IEdutrackMainForm _edutrackMainForm;
    }
}

