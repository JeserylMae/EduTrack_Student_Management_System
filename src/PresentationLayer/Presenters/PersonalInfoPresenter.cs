
using PresentationLayer.UserControls.AdminSubControls;
using System;


namespace PresentationLayer.Presenters
{
    public class PersonalInfoPresenter
    {
        public PersonalInfoPresenter(IPersonalInfoControl personalInfoControl)
        {
            _personalInfoControl = personalInfoControl;

            _personalInfoControl.TopCloseButtonClicked   += CloseCancelButton_Clicked;
            _personalInfoControl.BotCancelButtonClicked  += CloseCancelButton_Clicked;
            _personalInfoControl.AddNewStudentInfoSubmit += SubmitAddNewInfoButton_Clicked;
            _personalInfoControl.UpdateStudentInfoSubmit += SubmitUpdateInfoButton_Clicked;
        }

        private void CloseCancelButton_Clicked(object sender, EventArgs e)
        {
            _personalInfoControl.DestroyControl();
        }
                
        private void SubmitAddNewInfoButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SubmitUpdateInfoButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private IPersonalInfoControl _personalInfoControl;
    }
}
