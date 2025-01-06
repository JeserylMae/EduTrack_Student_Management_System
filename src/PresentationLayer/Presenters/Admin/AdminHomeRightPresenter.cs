
using PresentationLayer.UserControls.HomeSubControls;
using PresentationLayer.UserControls.MainControls;
using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Windows.Forms;
using PresentationLayer.Presenters.General;

namespace PresentationLayer.Presenters.Admin
{
    internal class AdminHomeRightPresenter
    {
        internal AdminHomeRightPresenter(IAdminHomeRightControl adminHomeRightControl)
        {
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
            IModifyAcadInfoControl studentModifyAcadInfoControl = new ModifyAcadInfoControl();
            new StudentModifyAcadInfoPresenter(studentModifyAcadInfoControl);

            GeneralPresenter.NewWindowControl = (UserControl)studentModifyAcadInfoControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _adminHomeRightControl.DestroyControl();
        }

        private void ItrPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StudPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyPersonalInfoControl studentModifyInfoControl = new ModifyPersonalInfoControl();
            new StudentModifyPersonalInfoPresenter(studentModifyInfoControl);

            GeneralPresenter.NewWindowControl = (UserControl) studentModifyInfoControl;
            GeneralPresenter.TriggerWindowControlChange(sender, EventArgs.Empty);

            _adminHomeRightControl.DestroyControl();
        }

        private IAdminHomeRightControl _adminHomeRightControl;
    }
}
