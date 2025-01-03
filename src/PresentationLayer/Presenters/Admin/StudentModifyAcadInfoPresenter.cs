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

namespace PresentationLayer.Presenters.Admin
{
    internal class StudentModifyAcadInfoPresenter
    {
        public StudentModifyAcadInfoPresenter(IStudentModifyAcadInfoControl studentAcadInfoControl)
        {
            _studentAcadInfoControl = studentAcadInfoControl;
            _studentControlReady    = new TaskCompletionSource<bool>();

            _studentAcadInfoControl.ControlLoad                         += StudentAcadControl_Load;
            _studentAcadInfoControl.CloseEditorButtonClicked            += CloseEditorButton_Clicked;
            _studentAcadInfoControl.ExitButtonClicked                   += GeneralPresenter.TriggerAppExit;
            _studentAcadInfoControl.FileDropDownButtonClicked           += FileDropDownButton_Clicked;
            _studentAcadInfoControl.OpenAddFormButtonClicked            += OpenAddFormButton_Clicked;
            _studentAcadInfoControl.OpenDropFormButtonClicked           += OpenDropFormButton_Clicked;
            _studentAcadInfoControl.OpenModifyFormButtonClicked         += OpenModifyFormButton_Clicked;
            _studentAcadInfoControl.InstructorAcadInfoButtonClicked     += InstructorAcadInfoButton_Clicked;
            _studentAcadInfoControl.StudentPersonalInfoButtonClicked    += StudentPersonalInfoButton_Clicked;
            _studentAcadInfoControl.InstructorPersonalInfoButtonClicked += InstructorPersonalInfoButton_Clicked;
            _studentAcadInfoControl.SearchSrCodeButtonClicked           += SeachSrCodeButton_Clicked;
            _studentAcadInfoControl.SearchSrCodeTextboxPressed          += SearchSrCodeTextBox_Pressed;
            _studentAcadInfoControl.InfoTableSelectionChanged           += InfoTableSelection_Changed;
            _studentAcadInfoControl.FilterEditorButtonClicked           += FilterEditorButton_Clicked;
        }

        private async void InfoTableSelection_Changed(object sender, EventArgs e)
        {
            if (await _studentControlReady.Task)
            {
                var selectedRowList = _studentAcadInfoControl.AccessInfoTable.SelectedRows;

                if (selectedRowList == null || selectedRowList.Count == 0) return;

                var selectedRows = selectedRowList[0];

                PNameModel nameModel = new PNameModel();
                _studentModel = new PStudentAcademicInfoModel<PNameModel>();

                DisplayValuesToUserControl(selectedRows);
            }
        }

        private void SearchSrCodeTextBox_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            SeachSrCodeButton_Clicked(sender, e);
        }

        private void SeachSrCodeButton_Clicked(object sender, EventArgs e)
        {
            string SrCode = _studentAcadInfoControl.AccessSearchSrCodeTextbox.Text;
            var infoTableRowList = _studentAcadInfoControl.AccessInfoTable.Rows;

            if (SrCode == null || infoTableRowList.Count == 0) return;

            for (int i = 0; i < infoTableRowList.Count; i++)
            {
                string SrCodeCell = infoTableRowList[i].Cells["SrCode"].Value.ToString();

                if (SrCodeCell == SrCode)
                    _studentAcadInfoControl.AccessInfoTable.Rows[i].Selected = true;
                else
                    _studentAcadInfoControl.AccessInfoTable.Rows[i].Selected = false;
            }
        }

        private void OpenModifyFormButton_Clicked(object sender, EventArgs e)
        {
            IStudentAcadInfoControl studentControl = new StudentAcadInfoControl();
            studentControl.StudentControl = _studentAcadInfoControl;
            studentControl.CurrentRequestType = FormRequestType.UPDATE;
            studentControl.AccessInfoTable = _studentAcadInfoControl.AccessInfoTable;

            new AcadInfoPresenter(studentControl);

            if (_studentAcadInfoControl.CurrentUserControl != null)
                _studentAcadInfoControl.CurrentUserControl.DisposeControl();

            _studentAcadInfoControl.CurrentUserControl = studentControl;
            SetSubmitButtonVisibility(studentControl, "UPDATE");

            _studentControlReady.TrySetResult(true);
        }

        private async void OpenDropFormButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                StudentAcademicInfoServices services = new StudentAcademicInfoServices();
                PRStudentAcademicInfoParams parameters = AddValuesToObject();

                bool result = await services.Delete(parameters);

                DisplayConfirmation($"Successfully deleted student with Sr-Code {parameters.SrCode}.", "ADD");
                _studentAcadInfoControl.TriggerInfoTableReload();
            }
            catch (Exception ex)
            {
                DisplayConfirmation(ex.Message, "DELETE");
            }
        }

        private void OpenAddFormButton_Clicked(object sender, EventArgs e)
        {
            IStudentAcadInfoControl studentControl = new StudentAcadInfoControl();
            studentControl.CurrentRequestType = FormRequestType.ADD;
            studentControl.StudentControl = _studentAcadInfoControl;

            new AcadInfoPresenter(studentControl);

            if (_studentAcadInfoControl.CurrentUserControl != null)
                _studentAcadInfoControl.CurrentUserControl.DisposeControl();

            _studentAcadInfoControl.CurrentUserControl = studentControl;
            SetSubmitButtonVisibility(studentControl, "ADD");

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
            GeneralPresenter.TriggerWindowControlChange(_studentAcadInfoControl, e);

            _studentAcadInfoControl.DisposeControl();
        }

        private void StudentPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            IStudentModifyPersonalInfoControl studentControl = new StudentModifyPersonalInfoControl();
            new StudentModifyPersonalInfoPresenter(studentControl);

            GeneralPresenter.NewWindowControl = (UserControl)studentControl;
            GeneralPresenter.TriggerWindowControlChange(_studentAcadInfoControl, e);

            _studentAcadInfoControl.DisposeControl();
        }

        private void InstructorPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InstructorAcadInfoButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FileDropDownButton_Clicked(object sender, EventArgs e)
        {
            if (_studentAcadInfoControl.AccessFileDropDownLayout.Visible)
                _studentAcadInfoControl.AccessFileDropDownLayout.Visible = false;
            else
                _studentAcadInfoControl.AccessFileDropDownLayout.Visible = true;
        }

        private void FilterEditorButton_Clicked(object sender, EventArgs e)
        {
            if (_studentAcadInfoControl.AccessFilterEditor == null)
            {
                IFilterControl filterControl = new FilterControl();
                filterControl.AccessStudentControl = _studentAcadInfoControl;

                new FilterPresenter(filterControl);

                _studentAcadInfoControl.AccessFilterEditor = (UserControl)filterControl;
            }
            else
            {
                _studentAcadInfoControl.AccessFilterEditor.Dispose();
                _studentAcadInfoControl.AccessFilterEditor = null;
            }
        }

        public async void StudentAcadControl_Load(object sender, EventArgs e)
        {
            try
            {
                StudentAcademicInfoServices services = new StudentAcademicInfoServices();
                List<PStudentAcademicInfoModel<PNameModel>> studentList = await services.GetAll();

                _studentAcadInfoControl.ClearInfoTable();

                foreach (var student in studentList)
                {
                    object[] studentInfo = new object[9];

                    AddStudentAcademicInfoToObject(ref studentInfo, student);
                    _studentAcadInfoControl.InfoTableRowData = studentInfo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Student Academic Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region Helpers
        private void DisplayConfirmation(string message, string action)
        {
            MessageBoxIcon messageBoxIcon = (action.ToUpper() == "DELETE") 
                                          ? MessageBoxIcon.Error 
                                          : MessageBoxIcon.Information;

            MessageBox.Show(message, $"Student Academic Information - {action.ToUpper()}",
                MessageBoxButtons.OK, messageBoxIcon);
        }

        private PRStudentAcademicInfoParams AddValuesToObject()
        {
            PRStudentAcademicInfoParams parameters = new PRStudentAcademicInfoParams();

            var selectedRows = _studentAcadInfoControl.AccessInfoTable.SelectedRows[0];

            parameters.SrCode = selectedRows.Cells["SrCode"].Value.ToString();
            parameters.Semester = selectedRows.Cells["Semester"].Value.ToString();
            parameters.YearLevel = selectedRows.Cells["YearLevel"].Value.ToString();
            parameters.AcademicYear = selectedRows.Cells["AcademicYear"].Value.ToString();

            return parameters;
        }

        private void DisplayValuesToUserControl(DataGridViewRow selectedRows)
        {
            if (selectedRows == null) return;

            _studentAcadInfoControl.CurrentUserControl.AccessSrCodeTextBox.Text = selectedRows.Cells["SrCode"].Value.ToString();
            _studentAcadInfoControl.CurrentUserControl.AccessLastNameTextBox.Text = selectedRows.Cells["LastName"].Value.ToString();
            _studentAcadInfoControl.CurrentUserControl.AccessFirstNameTextBox.Text = selectedRows.Cells["FirstName"].Value.ToString();
            _studentAcadInfoControl.CurrentUserControl.AccessMiddleNameTextBox.Text = selectedRows.Cells["MiddleName"].Value.ToString();

            if (_studentAcadInfoControl.CurrentUserControl.CurrentRequestType == FormRequestType.UPDATE)
            {
                _studentAcadInfoControl.CurrentUserControl.AccessSectionTextBox.Text = selectedRows.Cells["Section"].Value.ToString();
                _studentAcadInfoControl.CurrentUserControl.AccessYearComboBox.Text = selectedRows.Cells["YearLevel"].Value.ToString();
                _studentAcadInfoControl.CurrentUserControl.AccessProgramComboBox.Text = selectedRows.Cells["Program"].Value.ToString();
                _studentAcadInfoControl.CurrentUserControl.AccessSemesterComboBox.Text = selectedRows.Cells["Semester"].Value.ToString();
                _studentAcadInfoControl.CurrentUserControl.AccessAcademicYearComboBox.Text = selectedRows.Cells["AcademicYear"].Value.ToString();
            }
        }

        private void AddStudentAcademicInfoToObject(ref object[] studentObj, 
                        PStudentAcademicInfoModel<PNameModel> studentInfo)
        {
            studentObj[0] = studentInfo.SrCode;
            studentObj[1] = studentInfo.StudentName.LastName;
            studentObj[2] = studentInfo.StudentName.FirstName;
            studentObj[3] = studentInfo.StudentName.MiddleName;
            studentObj[4] = studentInfo.Program;
            studentObj[5] = studentInfo.YearLevel;
            studentObj[6] = studentInfo.Semester;
            studentObj[7] = studentInfo.Section;
            studentObj[8] = studentInfo.AcademicYear;
        }

        private void SetSubmitButtonVisibility(IStudentAcadInfoControl studentControl, string button)
        {
            studentControl.AccessSubmitAddButton.Visible = false;
            studentControl.AccessSubmitUpdateButton.Visible = false;

            if (button == "ADD")
                studentControl.AccessSubmitAddButton.Visible = true;
            else
                studentControl.AccessSubmitUpdateButton.Visible= true;
        }
        #endregion


        private TaskCompletionSource<bool> _studentControlReady;
        private PStudentAcademicInfoModel<PNameModel> _studentModel;
        private IStudentModifyAcadInfoControl _studentAcadInfoControl;
    }
}
