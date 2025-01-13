
using PresentationLayer.UserControls.HomeSubControls;
using PresentationLayer.UserControls.MainControls;
using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Windows.Forms;
using PresentationLayer.Presenters.General;
using PresentationLayer.Presenters.Enumerations;

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
            IProgramInfoControl userControl = new ProgramInfoControl();

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _adminHomeRightControl.DestroyControl();
        }

        private void ItrAcadInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyAcadInfoControl instructorModifyAcadInfoControl = new ModifyAcadInfoControl();
            instructorModifyAcadInfoControl.ModifyUser = AccessType.INSTRUCTOR;

            new ModifyAcadInfoPresenter(instructorModifyAcadInfoControl);

            GeneralPresenter.NewWindowControl = (UserControl)instructorModifyAcadInfoControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _adminHomeRightControl.DestroyControl();
        }

        private void StudAcadInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyAcadInfoControl studentModifyAcadInfoControl = new ModifyAcadInfoControl();
            studentModifyAcadInfoControl.ModifyUser = AccessType.STUDENT;

            new ModifyAcadInfoPresenter(studentModifyAcadInfoControl);

            GeneralPresenter.NewWindowControl = (UserControl)studentModifyAcadInfoControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _adminHomeRightControl.DestroyControl();
        }

        private void ItrPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyPersonalInfoControl ModifyInfoControl = new ModifyPersonalInfoControl();
            ModifyInfoControl.ModifyUser = AccessType.INSTRUCTOR;

            new ModifyPersonalInfoPresenter(ModifyInfoControl);

            GeneralPresenter.NewWindowControl = (UserControl)ModifyInfoControl;
            GeneralPresenter.TriggerWindowControlChange(sender, EventArgs.Empty);

            _adminHomeRightControl.DestroyControl();
        }

        private void StudPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyPersonalInfoControl studentModifyInfoControl = new ModifyPersonalInfoControl();
            studentModifyInfoControl.ModifyUser = AccessType.STUDENT;

            new ModifyPersonalInfoPresenter(studentModifyInfoControl);

            GeneralPresenter.NewWindowControl = (UserControl) studentModifyInfoControl;
            GeneralPresenter.TriggerWindowControlChange(sender, EventArgs.Empty);

            _adminHomeRightControl.DestroyControl();
        }

        private IAdminHomeRightControl _adminHomeRightControl;
    }
}
