using DomainLayer.DataModels;
using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.Presenters.General;
using PresentationLayer.UserControls.AdminSubControls;
using PresentationLayer.UserControls.HomeSubControls;
using PresentationLayer.UserControls.MainControls;
using ServiceLayer.Database;
using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Presenters.Admin
{
    internal class ProgramInfoPresenter
    {
        public ProgramInfoPresenter(IProgramInfoControl programControl)
        {
            _programControl = programControl;

            _programControl.ExitButtonClicked                   += GeneralPresenter.TriggerAppExit;
            _programControl.OnControlLoad                       += OnProgramInfoControl_Load;
            _programControl.OpenAddFormButtonClicked            += OpenAddFormButton_Clicked;
            _programControl.CloseEditorButtonClicked            += CloseEditorButton_Clicked;
            _programControl.FileDropDownButtonClicked           += FileDropDownButton_Clicked;
            _programControl.OpenDropFormButtonClicked           += OpenDropFormButton_Clicked;
            _programControl.OpenModifyFormButtonClicked         += OpenModifyFormButton_Clicked;
            _programControl.SearchProgramIdButtonClicked        += SearchProgramIdButton_Clicked;
            _programControl.SearchProgramIdTextboxPressed       += SearchProgramIdTextBox_Pressed;
            _programControl.InstructorAcadInfoButtonClicked     += InstructorAcademicInfoButton_Clicked;
            _programControl.StudentAcademicInfoButtonClicked    += StudentAcademicInfoButton_Clicked;
            _programControl.StudentPersonalInfoButtonClicked    += StudentPersonalInfoButton_Clicked;
            _programControl.InstructorPersonalInfoButtonClicked += InstructorPersonalInfoButton_Clicked;
        }

        private void CloseEditorButton_Clicked(object sender, EventArgs e)
        {
            _programControl.DisposeControl();

            HomePage homePage = new HomePage();
            new HomePagePresenter(homePage);

            IAdminHomeRightControl adminHomeRightControl = new AdminHomeRightControl();
            new AdminHomeRightPresenter(adminHomeRightControl);

            homePage.RightUserControlPage = (UserControl)adminHomeRightControl;

            GeneralPresenter.NewWindowControl = (UserControl)homePage;
            GeneralPresenter.TriggerWindowControlChange(sender, e);
        }

        private void InstructorPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyPersonalInfoControl userControl = new ModifyPersonalInfoControl();
            userControl.ModifyUser = AccessType.INSTRUCTOR;

            new ModifyPersonalInfoPresenter(userControl);

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _programControl.DisposeControl();
        }

        private void InstructorAcademicInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyAcadInfoControl userControl = new ModifyAcadInfoControl();
            userControl.ModifyUser = AccessType.INSTRUCTOR;

            new ModifyAcadInfoPresenter(userControl);

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _programControl.DisposeControl();
        }

        private void StudentPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyPersonalInfoControl userControl = new ModifyPersonalInfoControl();
            userControl.ModifyUser = AccessType.STUDENT;

            new ModifyPersonalInfoPresenter(userControl);

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _programControl.DisposeControl();   
        }

        private void StudentAcademicInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyAcadInfoControl userControl = new ModifyAcadInfoControl();
            userControl.ModifyUser = AccessType.STUDENT;

            new ModifyAcadInfoPresenter(userControl);

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _programControl.DisposeControl();
        }

        private void SearchProgramIdTextBox_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            SearchProgramIdButton_Clicked(sender, e);
        }

        private void SearchProgramIdButton_Clicked(object sender, EventArgs e)
        {
            string programId = _programControl.AccessSearchProgramIdTextbox.Text;

            if (string.IsNullOrEmpty(programId)) return;

            DataGridViewRowCollection infoTableRows = _programControl.AccessInfoTable.Rows;

            for (int i = 0; i < infoTableRows.Count; i++)
            {
                string tempProgramId = infoTableRows[i].Cells["ProgramId"].Value.ToString();

                if (tempProgramId == programId)
                    infoTableRows[i].Selected = true;
                else
                    infoTableRows[i].Selected = false;
            }
        }

        private void OpenModifyFormButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void OpenDropFormButton_Clicked(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = _programControl.AccessInfoTable.SelectedRows[0];
            string programId = selectedRow.Cells["ProgramId"].Value.ToString();

            DialogResult deletionConfirmed = DisplayWarning($"Are you sure you want to delete informations about program {programId}?");

            if (deletionConfirmed == DialogResult.No) return;

            ProgramServices services = new ProgramServices();
            bool response = await services.Delete(programId);

            if (response)
                DisplayConfirmation($"Successfully deleted program with ID {programId}.", FormRequestType.DELETE, RequestStatus.SUCCESS);
            else 
                DisplayConfirmation($"Failed to delete program with ID {programId}.", FormRequestType.DELETE, RequestStatus.ERROR);

        }

        private void OpenAddFormButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FileDropDownButton_Clicked(object sender, EventArgs e)
        {
            if (!_programControl.AccessFileDropDownLayout.Visible)
                _programControl.AccessFileDropDownLayout.Visible = true;
            else
                _programControl.AccessFileDropDownLayout.Visible = false;
        }

        private async void OnProgramInfoControl_Load(object sender, EventArgs e)
        {
            ProgramServices services = new ProgramServices();
            List<PRProgramModel> programList = await services.GetAll();

            foreach (PRProgramModel program in programList)
            {
                object[] programObject = new object[4];
                AddValuesToObject(ref programObject, program);

                _programControl.AccessInfoTableRowData = programObject;
            }
        }


        #region Helpers
        private void AddValuesToObject(ref object[] obj, PRProgramModel program)
        {
            if (obj == null || obj.Length <= 0) return;
            
            obj[0] = program.ProgramId;
            obj[1] = program.ProgramName;
            obj[2] = program.DepartmentId;
            obj[3] = program.DepartmentName;
        }

        private DialogResult DisplayWarning(string message)
        {
            return MessageBox.Show(message,
                "PROGRAM INFORMATION - DELETE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
        }

        private void DisplayConfirmation(string message, FormRequestType requestType, RequestStatus status)
        {
            MessageBoxIcon icon = (status == RequestStatus.SUCCESS)
                                ? MessageBoxIcon. Information : MessageBoxIcon.Error;

            MessageBox.Show(
                message,
                $"PROGRAM INFORMATION - {requestType.ToString().ToUpper()}",
                MessageBoxButtons.OK,
                icon
            );
        }
        #endregion


        IProgramInfoControl _programControl;
    }
}
