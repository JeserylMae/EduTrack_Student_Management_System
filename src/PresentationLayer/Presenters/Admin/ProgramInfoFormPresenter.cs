using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters.Admin
{
    internal class ProgramInfoFormPresenter
    {
        public ProgramInfoFormPresenter(IProgramInfoFormControl programControl)
        {
            _programControl = programControl;

            _programControl.OnControlLoad += OnProgramControl_Load;
            _programControl.CloseButtonClicked += CloseButton_Clicked;
            _programControl.SubmitAddButtonClicked += SubmitAddButton_Clicked;
            _programControl.SubmitUpdateButtonClicked += SubmitUpdateButton_Clicked;
            _programControl.CancelSubmitButtonClicked += CancelSubmitButton_Clicked;
        }


        private void CancelSubmitButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SubmitUpdateButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SubmitAddButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CloseButton_Clicked(object sender, EventArgs e)
        {
            _programControl.DisposeControl();
        }

        private void OnProgramControl_Load(object sender, EventArgs e)
        {
            if (_programControl.AccessFormRequestType == FormRequestType.UPDATE)
                _programControl.AccessSubmitAddButton.Dispose();
            else if (_programControl.AccessFormRequestType != FormRequestType.ADD)
                _programControl.AccessSubmitUpdateButton.Dispose();
        }

        private IProgramInfoFormControl _programControl;
    }
}
