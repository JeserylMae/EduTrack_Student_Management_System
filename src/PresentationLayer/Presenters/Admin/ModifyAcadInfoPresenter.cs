using DomainLayer.DataModels;
using ServiceLayer.Database;
using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Presenters.General;
using PresentationLayer.UserControls.HomeSubControls;
using PresentationLayer.UserControls.MainControls;
using System.Activities;
using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.UserControls.General;
using DomainLayer.DataModels.Instructor;
using System.Windows.Controls.Primitives;
using System.Xml.Serialization;

namespace PresentationLayer.Presenters.Admin
{
    internal class ModifyAcadInfoPresenter
    {
        public ModifyAcadInfoPresenter(IModifyAcadInfoControl studentAcadInfoControl)
        {
            _acadInfoControl = studentAcadInfoControl;
            _studentControlReady    = new TaskCompletionSource<bool>();

            _acadInfoControl.ControlLoad                         += StudentAcadControl_Load;
            _acadInfoControl.CloseEditorButtonClicked            += CloseEditorButton_Clicked;
            _acadInfoControl.ExitButtonClicked                   += GeneralPresenter.TriggerAppExit;
            _acadInfoControl.ProgramInfoButtonClicked            += ProgramInfoButton_Clicked;
            _acadInfoControl.OpenAddFormButtonClicked            += OpenAddFormButton_Clicked;
            _acadInfoControl.OpenDropFormButtonClicked           += OpenDropFormButton_Clicked;
            _acadInfoControl.FileDropDownButtonClicked           += FileDropDownButton_Clicked;
            _acadInfoControl.SearchUsrCodeButtonClicked          += SeachUsrCodeButton_Clicked;
            _acadInfoControl.FilterEditorButtonClicked           += FilterEditorButton_Clicked;
            _acadInfoControl.InfoTableSelectionChanged           += InfoTableSelection_Changed;
            _acadInfoControl.SearchUsrCodeTextboxPressed         += SearchUsrCodeTextBox_Pressed;
            _acadInfoControl.OpenModifyFormButtonClicked         += OpenModifyFormButton_Clicked;
            _acadInfoControl.InstructorAcadInfoButtonClicked     += InstructorAcadInfoButton_Clicked;
            _acadInfoControl.StudentPersonalInfoButtonClicked    += StudentPersonalInfoButton_Clicked;
            _acadInfoControl.StudentAcademicInfoButtonClicked    += StudentAcademicInfoControl_Clicked;
            _acadInfoControl.InstructorPersonalInfoButtonClicked += InstructorPersonalInfoButton_Clicked;
        }

        private async void InfoTableSelection_Changed(object sender, EventArgs e)
        {
            if (await _studentControlReady.Task)
            {
                var selectedRowList = _acadInfoControl.AccessInfoTable.SelectedRows;

                if (selectedRowList == null || selectedRowList.Count == 0) return;

                var selectedRows = selectedRowList[0];

                DisplayValuesToUserControl(selectedRows);
            }
        }

        private void SearchUsrCodeTextBox_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            SeachUsrCodeButton_Clicked(sender, e);
        }

        private void SeachUsrCodeButton_Clicked(object sender, EventArgs e)
        {
            string usrCode = _acadInfoControl.AccessSearchUsrCodeTextbox.Text;
            string columnName = (_acadInfoControl.ModifyUser == AccessType.STUDENT)
                             ? "SrCode" : "InstructorCode";


            var infoTableRowList = _acadInfoControl.AccessInfoTable.Rows;

            if (usrCode == null || infoTableRowList.Count == 0) return;

            for (int i = 0; i < infoTableRowList.Count; i++)
            {
                string usrCodeCell = infoTableRowList[i].Cells[columnName].Value.ToString();

                if (usrCodeCell == usrCode)
                    _acadInfoControl.AccessInfoTable.Rows[i].Selected = true;
                else
                    _acadInfoControl.AccessInfoTable.Rows[i].Selected = false;
            }
        }

        private void OpenModifyFormButton_Clicked(object sender, EventArgs e)
        {
            IAcademicInfoControl userControl = new AcademicInfoControl();

            userControl.StudentControl = _acadInfoControl;
            userControl.ModifyUser = _acadInfoControl.ModifyUser;
            userControl.CurrentRequestType = FormRequestType.UPDATE;
            userControl.AccessInfoTable = _acadInfoControl.AccessInfoTable;

            new AcademicInfoPresenter(userControl);

            if (_acadInfoControl.CurrentUserControl != null)
                _acadInfoControl.CurrentUserControl.DisposeControl();

            _acadInfoControl.CurrentUserControl = userControl;
            SetSubmitButtonVisibility(userControl, "UPDATE");

            _studentControlReady.TrySetResult(true);
        }

        private void OpenDropFormButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (_acadInfoControl.ModifyUser == AccessType.STUDENT)
                    _ = HandleStudentDelete();
                else if (_acadInfoControl.ModifyUser == AccessType.INSTRUCTOR)
                    _ = HandleInstructorDelete();
                else
                    throw new Exception("Cannot modify curreny user type.");
            }
            catch (Exception ex)
            {
                DisplayConfirmation(ex.Message, "DELETE");
            }
        }

        private void OpenAddFormButton_Clicked(object sender, EventArgs e)
        {
            IAcademicInfoControl userControl = new AcademicInfoControl();

            userControl.StudentControl = _acadInfoControl;
            userControl.CurrentRequestType = FormRequestType.ADD;
            userControl.ModifyUser = _acadInfoControl.ModifyUser;

            new AcademicInfoPresenter(userControl);

            if (_acadInfoControl.CurrentUserControl != null)
                _acadInfoControl.CurrentUserControl.DisposeControl();

            _acadInfoControl.CurrentUserControl = userControl;
            SetSubmitButtonVisibility(userControl, "ADD");

            _studentControlReady.TrySetResult(true);
        }

        private void CloseEditorButton_Clicked(object sender, EventArgs e)
        {
            IHomePage homePage = new HomePage();
            new HomePagePresenter(homePage);

            IAdminHomeRightControl adminControl = new AdminHomeRightControl();
            homePage.RightUserControlPage = (UserControl)adminControl;
            new AdminHomeRightPresenter(adminControl);

            GeneralPresenter.NewWindowControl = (UserControl)homePage;
            GeneralPresenter.TriggerWindowControlChange(_acadInfoControl, e);

            _acadInfoControl.DisposeControl();
        }

        private void ProgramInfoButton_Clicked(object sender, EventArgs e)
        {
            IProgramInfoControl userControl = new ProgramInfoControl();
            new ProgramInfoPresenter(userControl);

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _acadInfoControl.DisposeControl();
        }

        private void StudentPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyPersonalInfoControl studentControl = new ModifyPersonalInfoControl();
            studentControl.ModifyUser = AccessType.STUDENT;
            
            new ModifyPersonalInfoPresenter(studentControl);

            GeneralPresenter.NewWindowControl = (UserControl)studentControl;
            GeneralPresenter.TriggerWindowControlChange(_acadInfoControl, e);

            _acadInfoControl.DisposeControl();
        }

        private void StudentAcademicInfoControl_Clicked(object sender, EventArgs e)
        {
            if (_acadInfoControl.ModifyUser != AccessType.INSTRUCTOR) return;


            IModifyAcadInfoControl userControl = new ModifyAcadInfoControl();
            userControl.ModifyUser = AccessType.STUDENT;

            new ModifyAcadInfoPresenter(userControl);

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _acadInfoControl.DisposeControl();
        }

        private void InstructorPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyPersonalInfoControl userControl = new ModifyPersonalInfoControl();
            userControl.ModifyUser = AccessType.INSTRUCTOR;

            new ModifyPersonalInfoPresenter(userControl);

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, EventArgs.Empty);

            _acadInfoControl.DisposeControl();
        }

        private void InstructorAcadInfoButton_Clicked(object sender, EventArgs e)
        {
            if (_acadInfoControl.ModifyUser != AccessType.STUDENT) return;


            IModifyAcadInfoControl userControl = new ModifyAcadInfoControl();
            userControl.ModifyUser = AccessType.INSTRUCTOR;

            new ModifyAcadInfoPresenter(userControl);

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _acadInfoControl.DisposeControl();
        }

        private void FileDropDownButton_Clicked(object sender, EventArgs e)
        {
            if (_acadInfoControl.AccessFileDropDownLayout.Visible)
                _acadInfoControl.AccessFileDropDownLayout.Visible = false;
            else
                _acadInfoControl.AccessFileDropDownLayout.Visible = true;
        }

        private void FilterEditorButton_Clicked(object sender, EventArgs e)
        {
            if (_acadInfoControl.AccessFilterEditor == null)
            {
                IFilterControl filterControl = new FilterControl();
                filterControl.AccessStudentControl = _acadInfoControl;

                new FilterPresenter(filterControl);
                FileDropDownButton_Clicked(sender, e);

                _acadInfoControl.AccessFilterEditor = (UserControl)filterControl;
            }
            else
            {
                _acadInfoControl.AccessFilterEditor.Dispose();
                _acadInfoControl.AccessFilterEditor = null;
            }
        }

        public void StudentAcadControl_Load(object sender, EventArgs e)
        {
            try
            {
                if (_acadInfoControl.ModifyUser == AccessType.STUDENT)
                    _ = HandleStudentControlLoad();
                else if (_acadInfoControl.ModifyUser == AccessType.INSTRUCTOR)
                    _ = HandleInstructorControlLoad();
                else
                    throw new Exception(message: "Cannot modify chosen user type.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"{_acadInfoControl.ModifyUser.ToString()} ACADEMIC INFORMATION",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region Helpers
        private async Task HandleStudentDelete()
        {
            StudentAcademicInfoServices services = new StudentAcademicInfoServices();
            PRStudentAcademicInfoParams parameters = new PRStudentAcademicInfoParams(); 
            
            AddValuesToObject(ref parameters);

            bool result = await services.Delete(parameters);

            DisplayConfirmation($"Successfully deleted student with Sr-Code {parameters.SrCode}.", "ADD");
            _acadInfoControl.TriggerInfoTableReload();
        }

        private async Task HandleInstructorDelete()
        {
            InstructorAcademicInfoServices services = new InstructorAcademicInfoServices();
            PRInstructorAcademicParams parameters = new PRInstructorAcademicParams();

            AddValuesToObject(ref parameters);

            bool result = await services.Delete(parameters);

            DisplayConfirmation($"Successfully deleted instructor with Itr-Code {parameters.ItrCode}.", "ADD");
            _acadInfoControl.TriggerInfoTableReload();
        }

        private async Task HandleStudentControlLoad()
        {
            if (_acadInfoControl.AccessInfoTable.Columns.Contains("InstructorCode"))
                _acadInfoControl.AccessInfoTable.Columns.Remove("InstructorCode");

            if (_acadInfoControl.AccessInfoTable.Columns.Contains("Course"))
                _acadInfoControl.AccessInfoTable.Columns.Remove("Course");


            StudentAcademicInfoServices services = new StudentAcademicInfoServices();
            List<PStudentAcademicInfoModel<PNameModel>> studentList = await services.GetAll();

            _acadInfoControl.ClearInfoTable();

            foreach (var student in studentList)
            {
                object[] studentInfo = new object[9];

                AddStudentAcademicInfoToObject(ref studentInfo, student);
                _acadInfoControl.InfoTableRowData = studentInfo;
            }
        }

        private async Task HandleInstructorControlLoad()
        {
            if (_acadInfoControl.AccessInfoTable.Columns.Contains("SrCode"))
                _acadInfoControl.AccessInfoTable.Columns.Remove("SrCode");


            InstructorAcademicInfoServices services = new InstructorAcademicInfoServices();
            List<PInstructorAcademicInfoModel<PNameModel>> studentList = await services.GetAll();

            _acadInfoControl.ClearInfoTable();

            foreach (var student in studentList)
            {
                object[] studentInfo = new object[10];

                AddStudentAcademicInfoToObject(ref studentInfo, student);
                _acadInfoControl.InfoTableRowData = studentInfo;
            }
        }

        private void DisplayConfirmation(string message, string action)
        {
            MessageBoxIcon messageBoxIcon = (action.ToUpper() == "DELETE") 
                                          ? MessageBoxIcon.Error 
                                          : MessageBoxIcon.Information;

            MessageBox.Show(message, $"Student Academic Information - {action.ToUpper()}",
                MessageBoxButtons.OK, messageBoxIcon);
        }

        private void DisplayValuesToUserControl(DataGridViewRow selectedRows)
        {
            if (selectedRows == null) return;

            _acadInfoControl.CurrentUserControl.AccessLastNameTextBox.Text   = selectedRows.Cells["LastName"].Value.ToString();
            _acadInfoControl.CurrentUserControl.AccessFirstNameTextBox.Text  = selectedRows.Cells["FirstName"].Value.ToString();
            _acadInfoControl.CurrentUserControl.AccessMiddleNameTextBox.Text = selectedRows.Cells["MiddleName"].Value.ToString();

            
            if (_acadInfoControl.ModifyUser == AccessType.STUDENT)
                _acadInfoControl.CurrentUserControl.AccessUsrCodeTextBox.Text = selectedRows.Cells["SrCode"].Value.ToString();
            else if (_acadInfoControl.ModifyUser == AccessType.INSTRUCTOR)
                _acadInfoControl.CurrentUserControl.AccessUsrCodeTextBox.Text = selectedRows.Cells["InstructorCode"].Value.ToString();
            

            if (_acadInfoControl.CurrentUserControl.CurrentRequestType == FormRequestType.UPDATE)
            {
                _acadInfoControl.CurrentUserControl.AccessSectionTextBox.Text       = selectedRows.Cells["Section"].Value.ToString();
                _acadInfoControl.CurrentUserControl.AccessYearComboBox.Text         = selectedRows.Cells["YearLevel"].Value.ToString();
                _acadInfoControl.CurrentUserControl.AccessProgramComboBox.Text      = selectedRows.Cells["Program"].Value.ToString();
                _acadInfoControl.CurrentUserControl.AccessSemesterComboBox.Text     = selectedRows.Cells["Semester"].Value.ToString();
                _acadInfoControl.CurrentUserControl.AccessAcademicYearComboBox.Text = selectedRows.Cells["AcademicYear"].Value.ToString();
                
                if (_acadInfoControl.ModifyUser == AccessType.INSTRUCTOR)
                    _acadInfoControl.CurrentUserControl.AccessCourseTextBox.Text = selectedRows.Cells["Course"].Value.ToString();                
            }
        }

        private void AddStudentAcademicInfoToObject(ref object[] studentObj, 
                        PStudentAcademicInfoModel<PNameModel> studentInfo)
        {
            studentObj[0] = studentInfo.SrCode;
            studentObj[1] = studentInfo.StudentName.LastName;
            studentObj[2] = studentInfo.StudentName.FirstName;
            studentObj[3] = studentInfo.StudentName.MiddleName;
            studentObj[4] = studentInfo.Section;
            studentObj[5] = studentInfo.Semester;
            studentObj[6] = studentInfo.YearLevel;
            studentObj[7] = studentInfo.AcademicYear;
            studentObj[8] = studentInfo.Program;
        }

        private void AddStudentAcademicInfoToObject(ref object[] instructorObj,
                        PInstructorAcademicInfoModel<PNameModel> instructorInfo)
        {
            instructorObj[0] = instructorInfo.ItrCode;
            instructorObj[1] = instructorInfo.InstructorName.LastName;
            instructorObj[2] = instructorInfo.InstructorName.FirstName;
            instructorObj[3] = instructorInfo.InstructorName.MiddleName;
            instructorObj[4] = instructorInfo.Course ?? "-";
            instructorObj[5] = instructorInfo.Section ?? "-";
            instructorObj[6] = instructorInfo.Semester ?? "-";
            instructorObj[7] = instructorInfo.YearLevel ?? "-";
            instructorObj[8] = instructorInfo.AcademicYear ?? "-";
            instructorObj[9] = instructorInfo.Program ?? "-";
        }

        private void SetSubmitButtonVisibility(IAcademicInfoControl studentControl, string button)
        {
            studentControl.AccessSubmitAddButton.Visible = false;
            studentControl.AccessSubmitUpdateButton.Visible = false;

            if (button == "ADD")
                studentControl.AccessSubmitAddButton.Visible = true;
            else
                studentControl.AccessSubmitUpdateButton.Visible= true;
        }

        private void AddValuesToObject(ref PRStudentAcademicInfoParams parameters)
        {
            var selectedRows = _acadInfoControl.AccessInfoTable.SelectedRows[0];

            parameters.SrCode = selectedRows.Cells["SrCode"].Value.ToString();
            parameters.Section = selectedRows.Cells["Section"].Value.ToString();
            parameters.Semester = selectedRows.Cells["Semester"].Value.ToString();
            parameters.YearLevel = selectedRows.Cells["YearLevel"].Value.ToString();
            parameters.AcademicYear = selectedRows.Cells["AcademicYear"].Value.ToString();
        }

        private void AddValuesToObject(ref PRInstructorAcademicParams parameters)
        {
            var selectedRows = _acadInfoControl.AccessInfoTable.SelectedRows[0];

            parameters.ItrCode = selectedRows.Cells["InstructorCode"].Value.ToString();
            parameters.Course = selectedRows.Cells["Course"].Value.ToString();
            parameters.Section = selectedRows.Cells["Section"].Value.ToString();
            parameters.Semester = selectedRows.Cells["Semester"].Value.ToString();
            parameters.YearLevel = selectedRows.Cells["YearLevel"].Value.ToString();
            parameters.AcademicYear = selectedRows.Cells["AcademicYear"].Value.ToString();
        }
        #endregion


        private IModifyAcadInfoControl _acadInfoControl;
        private TaskCompletionSource<bool> _studentControlReady;
    }
}
