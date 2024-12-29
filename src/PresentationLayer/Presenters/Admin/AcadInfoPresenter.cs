using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.Presenters.General;
using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters.Admin
{
    internal class AcadInfoPresenter
    {
        public AcadInfoPresenter(IStudentAcadInfoControl studentAcadInfoControl)
        {
            _studentAcadInfoControl = studentAcadInfoControl;

            _studentAcadInfoControl.ControlLoad += StudentAcadInfoControl_Load;
            _studentAcadInfoControl.CloseButtonClicked += CloseButton_Clicked;
        }

        private void CloseButton_Clicked(object sender, EventArgs e)
        {
            _studentAcadInfoControl.CurrentControl.Dispose();
        }

        private void StudentAcadInfoControl_Load(object sender, EventArgs e)
        {
            if (_studentAcadInfoControl.CurrentRequestType == FormRequestType.UPDATE)
                SetNameTextBoxToReadOnly();

        }


        #region Helpers
        private void SetNameTextBoxToReadOnly()
        {
            _studentAcadInfoControl.AccessLastNameTextBox.ReadOnly = true;
            _studentAcadInfoControl.AccessFirstNameTextBox.ReadOnly = true;
            _studentAcadInfoControl.AccessMiddleNameTextBox.ReadOnly = true;
        }
        #endregion

        private IStudentAcadInfoControl _studentAcadInfoControl;
    }
}
