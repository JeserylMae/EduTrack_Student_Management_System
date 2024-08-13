
using PresentationLayer.UserControls.HomeSubControls;
using PresentationLayer.Views;
using System;

namespace PresentationLayer.Presenters
{
    internal class AdminHomeRightPresenter
    {
        internal AdminHomeRightPresenter(IAdminHomeRightControl adminHomeRightControl,
                                         IEdutrackMainForm edutrackMainForm)
        {
            _edutrackMainForm = edutrackMainForm;
            _adminHomeRightControl = adminHomeRightControl;

            _adminHomeRightControl.CourseInfoButtonClicked       += CourseInfoButton_Clicked;
            _adminHomeRightControl.ItrAcadInfoButtonClicked      += ItrAcadInfoButton_Clicked;
            _adminHomeRightControl.StudAcadInfoButtonClicked     += StudAcadInfoButton_Clicked;
            _adminHomeRightControl.ItrPersonalInfoButtonClicked  += ItrPersonalInfoButton_Clicked;
            _adminHomeRightControl.StudPersonalInfoButtonClicked += StudPersonalInfoButton_Clicked;
        }

        private void CourseInfoButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ItrAcadInfoButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StudAcadInfoButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ItrPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StudPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private IEdutrackMainForm _edutrackMainForm;
        private IAdminHomeRightControl _adminHomeRightControl;
    }
}
