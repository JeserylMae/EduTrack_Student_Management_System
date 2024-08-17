using PresentationLayer.UserControls.MainControls;
using PresentationLayer.Views;
using System;
using System.Windows.Forms;


namespace PresentationLayer.Presenters
{
    internal class HomePagePresenter
    {
        internal HomePagePresenter(IHomePage homePage, IEdutrackMainForm edutrackMainForm) 
        {
            _homePage = homePage;
            _edutrackMainForm = edutrackMainForm;
            _homePage.LoggedOut += LogoutButton_Clicked;
        }

        internal void LogoutButton_Clicked(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log-out?", "Edutrack", 
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _homePage.DestroyControl();
                _edutrackMainForm.UserControlPage = new LogInPage(_edutrackMainForm);
            }
        }


        private IHomePage _homePage;
        private IEdutrackMainForm _edutrackMainForm;
    }
}
