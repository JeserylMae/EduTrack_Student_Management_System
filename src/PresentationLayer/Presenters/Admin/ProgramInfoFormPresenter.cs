using DomainLayer.DataModels;
using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.UserControls.AdminSubControls;
using ServiceLayer.Database;
using System;
using System.Windows.Forms;

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
            ClearTextBoxes();
        }

        private async void SubmitUpdateButton_Clicked(object sender, EventArgs e)
        {
            PRProgramModel program = new PRProgramModel();
            AssignValuesToModel(ref program);

            ProgramServices service = new ProgramServices();
            bool response = await service.Update(program);

            if (response)
            {
                DisplayConfirmation("Successfully updated program.", FormRequestType.UPDATE, RequestStatus.SUCCESS);
                _programControl.ProgramControl.TriggerInfoTableReload();
            }
            else DisplayConfirmation("Failed to update program.", FormRequestType.UPDATE, RequestStatus.ERROR);
        }

        private async void SubmitAddButton_Clicked(object sender, EventArgs e)
        {
            PRProgramModel program = new PRProgramModel();
            AssignValuesToModel(ref program);

            ProgramServices service = new ProgramServices();
            bool response = await service.InsertNew(program);

            if (response)
            {
                DisplayConfirmation("Successfully added new program.", FormRequestType.ADD, RequestStatus.SUCCESS);
                _programControl.ProgramControl.TriggerInfoTableReload();
            }
            else DisplayConfirmation("Failed to add program.", FormRequestType.ADD, RequestStatus.ERROR);
        }

        private void CloseButton_Clicked(object sender, EventArgs e)
        {
            _programControl.DisposeControl();
        }

        private void OnProgramControl_Load(object sender, EventArgs e)
        {
            if (_programControl.AccessFormRequestType == FormRequestType.UPDATE)
                _programControl.AccessSubmitAddButton.Visible = false;

            else if (_programControl.AccessFormRequestType == FormRequestType.ADD)
                _programControl.AccessSubmitUpdateButton.Visible = false;
        }


        #region Helpers
        private void DisplayConfirmation(string message, 
                                         FormRequestType request, 
                                         RequestStatus status)
        {
            MessageBoxIcon icon = (status == RequestStatus.SUCCESS)
                                ? MessageBoxIcon.Information
                                : MessageBoxIcon.Error;

            MessageBox.Show(
                message,
                $"PROGRAM INFORMATION - {request.ToString().ToUpper()}",
                MessageBoxButtons.OK,
                icon
            );
        }

        private void AssignValuesToModel(ref PRProgramModel model)
        {
            model.ProgramId = _programControl.AccessProgramId.Text;
            model.ProgramName = _programControl.AccessProgramName.Text;
            model.DepartmentId = _programControl.AccessDepartmentId.Text;
            model.DepartmentName = _programControl.AccessDepartmentName.Text;
        }

        private void ClearTextBoxes()
        {
            _programControl.AccessProgramId.Text = string.Empty;
            _programControl.AccessProgramName.Text = string.Empty;
            _programControl.AccessDepartmentId.Text = string.Empty;
            _programControl.AccessDepartmentName.Text = string.Empty;
        }
        #endregion


        private IProgramInfoFormControl _programControl;
    }
}
