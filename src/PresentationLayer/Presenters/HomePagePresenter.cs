using PresentationLayer.UserControls.MainControls;
using PresentationLayer.Views;
using System;


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
            _homePage.DestroyControl();
            _edutrackMainForm.UserControlPage = new LogInPage(_edutrackMainForm);
        }


        private IHomePage _homePage;
        private IEdutrackMainForm _edutrackMainForm;
    }
}
