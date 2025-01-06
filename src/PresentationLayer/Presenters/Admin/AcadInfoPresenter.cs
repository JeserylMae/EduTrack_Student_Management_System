using DomainLayer.DataModels;
using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.Presenters.General;
using PresentationLayer.UserControls.AdminSubControls;
using PresentationLayer.UserControls.MainControls;
using ServiceLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Presenters.Admin
{
    internal class AcadInfoPresenter
    {
        public AcadInfoPresenter(IAcademicInfoControl studentAcadInfoControl)
        {
            _studentAcadInfoControl = studentAcadInfoControl;

            _studentAcadInfoControl.ControlLoad               += StudentAcadInfoControl_Load;
            _studentAcadInfoControl.CloseButtonClicked        += CloseButton_Clicked;
            _studentAcadInfoControl.SubmitAddButtonClicked    += SubmitAddButton_Clicked;
            _studentAcadInfoControl.SubmitUpdateButtonClicked += SubmitUpdateButton_Clicked;
            _studentAcadInfoControl.CancelSubmitButtonClicked += CancelSubmitButton_Clicked;
        }

        private void CancelSubmitButton_Clicked(object sender, EventArgs e)
        {
            DialogResult result = DisplayWarning(
                "Are you sure you want to discard changes?",
                FormRequestType.CANCEL    
            );

            if (result == DialogResult.Yes) ClearTexboxes();
        }

        private DialogResult DisplayWarning(string message, FormRequestType requestType)
        {
             return MessageBox.Show(message,
                $"Student Academic Information - {requestType}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
        }

        private async void SubmitUpdateButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                PRStudentAcademicInfoParams parameters = new PRStudentAcademicInfoParams();
                StudentAcademicInfoServices services = new StudentAcademicInfoServices();
                PStudentAcademicInfoModel<string> student = new PStudentAcademicInfoModel<string>();

                AddValuesToObject(ref parameters);
                int recordId = await services.GetRecordId(parameters);

                if (recordId == -1) 
                    throw new Exception(message: $"Cannot find student with Sr-Code {parameters.SrCode}.");

                AddValuesToObject(ref student);
                bool response = await services.Update(student, recordId);

                if (response)
                {
                    DisplayConfimation(
                        $"Successfully updated student with Sr-Code {student.SrCode}.",
                        FormRequestType.UPDATE,
                        RequestStatus.SUCCESS
                    );
                    _studentAcadInfoControl.StudentControl.TriggerInfoTableReload();
                }
                else throw new Exception(message: $"Failed to update student with Sr-Code {student.SrCode}.");
            }
            catch (Exception ex) 
            { 
                DisplayConfimation(ex.StackTrace, 
                    FormRequestType.UPDATE,
                    RequestStatus.ERROR
                ); 
            }
        }

        private async void SubmitAddButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                StudentAcademicInfoServices services = new StudentAcademicInfoServices();
                PStudentAcademicInfoModel<string> student = new PStudentAcademicInfoModel<string>();

                AddValuesToObject(ref student);

                bool response = await services.InsertNew(student);

                if (response)
                {
                    DisplayConfimation(
                        $"Successfully to inserted student with Sr-Code {student.SrCode}.",
                        FormRequestType.ADD,
                        RequestStatus.SUCCESS
                    );
                    _studentAcadInfoControl.StudentControl.TriggerInfoTableReload();
                }
                else throw new Exception(message: $"Failed to insert student with Sr-Code {student.SrCode}.");
            }
            catch (Exception ex)
            {
                DisplayConfimation( ex.Message,
                    FormRequestType.ADD,
                    RequestStatus.ERROR
                );
            }
        }

        private void CloseButton_Clicked(object sender, EventArgs e)
        {
            _studentAcadInfoControl.CurrentControl.Dispose();
        }

        private void StudentAcadInfoControl_Load(object sender, EventArgs e)
        {
            if (_studentAcadInfoControl.CurrentRequestType == FormRequestType.UPDATE)
                SetNameTextBoxToReadOnly();

            LoadComboBoxOptions();
        }


        #region Helpers
        private void DisplayConfimation(string message, FormRequestType requestType, 
                                        RequestStatus status)
        {
            MessageBoxIcon messageBoxIcon = (status == RequestStatus.SUCCESS)
                                ? MessageBoxIcon.Information
                                : MessageBoxIcon.Error;

            MessageBox.Show(message,
                $"Student Academic Information - {requestType}.",
                MessageBoxButtons.OK,
                messageBoxIcon
            );
        }

        private void AddValuesToObject(ref PRStudentAcademicInfoParams parameters)
        {
            var selectedRows = _studentAcadInfoControl.AccessInfoTable.SelectedRows[0];

            parameters.SrCode = selectedRows.Cells["SrCode"].Value.ToString();
            parameters.Semester = selectedRows.Cells["Semester"].Value.ToString();
            parameters.YearLevel = selectedRows.Cells["YearLevel"].Value.ToString();
            parameters.AcademicYear = selectedRows.Cells["AcademicYear"].Value.ToString();
        }

        private void AddValuesToObject(ref PStudentAcademicInfoModel<string> model)
        {
            model.SrCode = _studentAcadInfoControl.AccessSrCodeTextBox.Text;
            model.Program = _studentAcadInfoControl.AccessProgramComboBox.Text;
            model.YearLevel = _studentAcadInfoControl.AccessYearComboBox.Text;
            model.Section = _studentAcadInfoControl.AccessSectionTextBox.Text;
            model.Semester = _studentAcadInfoControl.AccessSemesterComboBox.Text;
            model.AcademicYear = _studentAcadInfoControl.AccessAcademicYearComboBox.Text;
            model.StudentName = model.SrCode + "-STU";
        }

        private void ClearTexboxes()
        {
            _studentAcadInfoControl.AccessSrCodeTextBox.Clear();
            _studentAcadInfoControl.AccessSectionTextBox.Clear();
            _studentAcadInfoControl.AccessLastNameTextBox.Clear();
            _studentAcadInfoControl.AccessFirstNameTextBox.Clear();
            _studentAcadInfoControl.AccessMiddleNameTextBox.Clear();
            _studentAcadInfoControl.AccessYearComboBox.Text = string.Empty;
            _studentAcadInfoControl.AccessProgramComboBox.Text = string.Empty;
            _studentAcadInfoControl.AccessSemesterComboBox.Text = string.Empty;
            _studentAcadInfoControl.AccessAcademicYearComboBox.Text = string.Empty;
        }

        private async void LoadComboBoxOptions()
        {
            string[] yearOptions = { "FIRST", "SECOND", "THIRD", "FOURTH", "FIFTH"};
            _studentAcadInfoControl.AccessYearComboBox.Items.AddRange(yearOptions);

            string[] semesterOptions = { "FISRT", "SECOND", "SUMMER" };
            _studentAcadInfoControl.AccessSemesterComboBox.Items.AddRange(semesterOptions);

            int startingYear = DateTime.Now.Year + 1;
            string[] acadYearOptions = Enumerable.Range(0, 9)
                .Select(i => $"A.Y. {startingYear - (i + 1)}-{startingYear - i}")
                .ToArray();
            _studentAcadInfoControl.AccessAcademicYearComboBox.Items.AddRange(acadYearOptions);

            ProrgamServices services = new ProrgamServices();
            Dictionary<string, string> programList = await services.GetAllProgram();
            string[] programOptions = programList.Values.ToArray();
            _studentAcadInfoControl.AccessProgramComboBox.Items.AddRange(programOptions);
        }

        private void SetNameTextBoxToReadOnly()
        {
            _studentAcadInfoControl.AccessLastNameTextBox.ReadOnly = true;
            _studentAcadInfoControl.AccessFirstNameTextBox.ReadOnly = true;
            _studentAcadInfoControl.AccessMiddleNameTextBox.ReadOnly = true;
        }
        #endregion


        private IAcademicInfoControl _studentAcadInfoControl;
    }
}
