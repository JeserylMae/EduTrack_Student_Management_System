using DomainLayer.DataModels;
using DomainLayer.DataModels.Instructor;
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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace PresentationLayer.Presenters.Admin
{
    internal class AcademicInfoPresenter
    {
        public AcademicInfoPresenter(IAcademicInfoControl studentAcadInfoControl)
        {
            _acadInfoControl = studentAcadInfoControl;

            _acadInfoControl.ControlLoad               += StudentAcadInfoControl_Load;
            _acadInfoControl.CloseButtonClicked        += CloseButton_Clicked;
            _acadInfoControl.SubmitAddButtonClicked    += SubmitAddButton_Clicked;
            _acadInfoControl.SubmitUpdateButtonClicked += SubmitUpdateButton_Clicked;
            _acadInfoControl.CancelSubmitButtonClicked += CancelSubmitButton_Clicked;
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
                $"{_acadInfoControl.ModifyUser.ToString()} ACADEMIC INFORMATION - {requestType}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
        }

        private void SubmitUpdateButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (_acadInfoControl.ModifyUser == AccessType.STUDENT)
                    _ = HandleStudentUpdate();
                else if (_acadInfoControl.ModifyUser == AccessType.INSTRUCTOR)
                    _ = HandleInstructorUpdate();
                else
                    throw new Exception("Cannot modify current user.");
            }
            catch (Exception ex) 
            { 
                DisplayConfimation(ex.StackTrace, 
                    FormRequestType.UPDATE,
                    RequestStatus.ERROR
                ); 
            }
        }

        private void SubmitAddButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (_acadInfoControl.ModifyUser == AccessType.STUDENT)
                    _ = HandleStudentInsert();
                else if (_acadInfoControl.ModifyUser == AccessType.INSTRUCTOR)
                    _ = HandleInstructorInsert();
                else
                    throw new Exception("Cannot modify current user.");
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
            _acadInfoControl.CurrentControl.Dispose();
        }

        private void StudentAcadInfoControl_Load(object sender, EventArgs e)
        {
            if (_acadInfoControl.CurrentRequestType == FormRequestType.UPDATE)
                SetNameTextBoxToReadOnly();

            ModifyDisplayedElements();

            LoadYearComboBoxOptions();
            LoadSemesterComboBoxOptions();
            LoadAcademicYearComboBoxOptions();
            LoadProgramComboBoxOptions();
        }


        #region Helpers
        private async Task HandleStudentInsert()
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
                _acadInfoControl.StudentControl.TriggerInfoTableReload();
            }
            else throw new Exception(message: $"Failed to insert student with Sr-Code {student.SrCode}.");
        }

        private async Task HandleInstructorInsert()
        {
            InstructorAcademicInfoServices services = new InstructorAcademicInfoServices();
            PInstructorAcademicInfoModel<string> instructor = new PInstructorAcademicInfoModel<string>();

            AddValuesToObject(ref instructor);

            bool response = await services.InsertNew(instructor);

            if (response)
            {
                DisplayConfimation(
                    $"Successfully to inserted instructor with Itr-Code {instructor.ItrCode}.",
                    FormRequestType.ADD,
                    RequestStatus.SUCCESS
                );
                _acadInfoControl.StudentControl.TriggerInfoTableReload();
            }
            else throw new Exception(message: $"Failed to insert instructor with Itr-Code {instructor.ItrCode}.");
        }

        private async Task HandleStudentUpdate()
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
                _acadInfoControl.StudentControl.TriggerInfoTableReload();
            }
            else throw new Exception(message: $"Failed to update student with Sr-Code {student.SrCode}.");
        }

        private async Task HandleInstructorUpdate()
        {
            PRInstructorAcademicParams parameters = new PRInstructorAcademicParams();
            InstructorAcademicInfoServices services = new InstructorAcademicInfoServices();
            PInstructorAcademicInfoModel<string> instructor = new PInstructorAcademicInfoModel<string>();

            AddValuesToObject(ref parameters);
            int recordId = await services.GetRecordId(parameters);

            if (recordId == -1)
                throw new Exception(message: $"Cannot find instructor with Itr-Code {parameters.ItrCode}.");

            AddValuesToObject(ref instructor);
            bool response = await services.Update(recordId, instructor);

            if (response)
            {
                DisplayConfimation(
                    $"Successfully updated instructor with Itr-Code {instructor.ItrCode}.",
                    FormRequestType.UPDATE,
                    RequestStatus.SUCCESS
                );
                _acadInfoControl.StudentControl.TriggerInfoTableReload();
            }
            else throw new Exception(message: $"Failed to update instructor with Itr-Code {instructor.ItrCode}.");
        }

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
            var selectedRows = _acadInfoControl.AccessInfoTable.SelectedRows[0];

            parameters.SrCode       = selectedRows.Cells["SrCode"].Value.ToString();
            parameters.Section      = selectedRows.Cells["Section"].Value.ToString();
            parameters.Semester     = selectedRows.Cells["Semester"].Value.ToString();
            parameters.YearLevel    = selectedRows.Cells["YearLevel"].Value.ToString();
            parameters.AcademicYear = selectedRows.Cells["AcademicYear"].Value.ToString();
        }

        private void AddValuesToObject(ref PRInstructorAcademicParams parameters)
        {
            var selectedRows = _acadInfoControl.AccessInfoTable.SelectedRows[0];

            parameters.Course       = (selectedRows.Cells["Course"].Value.ToString() == "-")
                                    ? "" : selectedRows.Cells["Course"].Value.ToString();

            parameters.ItrCode      = selectedRows.Cells["InstructorCode"].Value.ToString();

            parameters.Section      = (selectedRows.Cells["Section"].Value.ToString() == "-")
                                    ? "" : selectedRows.Cells["Section"].Value.ToString();

            parameters.Semester     = (selectedRows.Cells["Semester"].Value.ToString() == "-")
                ? "" : selectedRows.Cells["Semester"].Value.ToString();

            parameters.YearLevel    = (selectedRows.Cells["YearLevel"].Value.ToString() == "-") 
                                    ? "" : selectedRows.Cells["YearLevel"].Value.ToString();

            parameters.AcademicYear = (selectedRows.Cells["AcademicYear"].Value.ToString() == "-") 
                                    ? "" : selectedRows.Cells["AcademicYear"].Value.ToString();
        }

        private void AddValuesToObject(ref PStudentAcademicInfoModel<string> model)
        {
            model.SrCode        = _acadInfoControl.AccessUsrCodeTextBox.Text;
            model.Program       = _acadInfoControl.AccessProgramComboBox.Text;
            model.YearLevel     = _acadInfoControl.AccessYearComboBox.Text;
            model.Section       = _acadInfoControl.AccessSectionTextBox.Text;
            model.Semester      = _acadInfoControl.AccessSemesterComboBox.Text;
            model.AcademicYear  = _acadInfoControl.AccessAcademicYearComboBox.Text;
            model.StudentName   = model.SrCode + "-STU";
        }

        private void AddValuesToObject(ref PInstructorAcademicInfoModel<string> model)
        {
            model.ItrCode           = _acadInfoControl.AccessUsrCodeTextBox.Text;
            model.Course            = _acadInfoControl.AccessCourseTextBox.Text;
            model.Program           = _acadInfoControl.AccessProgramComboBox.Text;
            model.YearLevel         = _acadInfoControl.AccessYearComboBox.Text;
            model.Section           = _acadInfoControl.AccessSectionTextBox.Text;
            model.Semester          = _acadInfoControl.AccessSemesterComboBox.Text;
            model.AcademicYear      = _acadInfoControl.AccessAcademicYearComboBox.Text;
            model.InstructorName    = model.ItrCode + "-ITR";
        }

        private void ClearTexboxes()
        {
            _acadInfoControl.AccessUsrCodeTextBox.Clear();
            _acadInfoControl.AccessSectionTextBox.Clear();
            _acadInfoControl.AccessLastNameTextBox.Clear();
            _acadInfoControl.AccessFirstNameTextBox.Clear();
            _acadInfoControl.AccessMiddleNameTextBox.Clear();
            _acadInfoControl.AccessYearComboBox.Text = string.Empty;
            _acadInfoControl.AccessProgramComboBox.Text = string.Empty;
            _acadInfoControl.AccessSemesterComboBox.Text = string.Empty;
            _acadInfoControl.AccessAcademicYearComboBox.Text = string.Empty;
        }

        private void LoadYearComboBoxOptions()
        {
            string[] yearOptions = { "FIRST", "SECOND", "THIRD", "FOURTH", "FIFTH"};
            _acadInfoControl.AccessYearComboBox.Items.AddRange(yearOptions);
        }

        private void LoadSemesterComboBoxOptions()
        {
            string[] semesterOptions = { "FIRST", "SECOND", "SUMMER" };
            _acadInfoControl.AccessSemesterComboBox.Items.AddRange(semesterOptions);
        }

        private void LoadAcademicYearComboBoxOptions()
        {
            int startingYear = DateTime.Now.Year + 1;
            string[] acadYearOptions = Enumerable.Range(0, 9)
                .Select(i => $"A.Y. {startingYear - (i + 1)}-{startingYear - i}")
                .ToArray();
            _acadInfoControl.AccessAcademicYearComboBox.Items.AddRange(acadYearOptions);
        }

        private async void LoadProgramComboBoxOptions()
        {
            ProrgamServices services = new ProrgamServices();
            Dictionary<string, string> programList = await services.GetAllProgram();
            string[] programOptions = programList.Values.ToArray();
            _acadInfoControl.AccessProgramComboBox.Items.AddRange(programOptions);
        }

        private void SetNameTextBoxToReadOnly()
        {
            _acadInfoControl.AccessLastNameTextBox.ReadOnly = true;
            _acadInfoControl.AccessFirstNameTextBox.ReadOnly = true;
            _acadInfoControl.AccessMiddleNameTextBox.ReadOnly = true;
        }

        private void ModifyDisplayedElements()
        {
            if (_acadInfoControl.ModifyUser == AccessType.STUDENT)
            {
                _acadInfoControl.AccessCoursePanel.Dispose();
            }
            else if (_acadInfoControl.ModifyUser == AccessType.INSTRUCTOR)
            {
                _acadInfoControl.AccessPageLabel.Text = "Instructor Academic Information Form";
                _acadInfoControl.AccessUsrCodeLabel.Text = "ITR-CODE:";
                _acadInfoControl.AccessFullNameLabel.Text = "INSTRUCTOR FULL NAME";
            }
        }
        #endregion


        private IAcademicInfoControl _acadInfoControl;
    }
}
