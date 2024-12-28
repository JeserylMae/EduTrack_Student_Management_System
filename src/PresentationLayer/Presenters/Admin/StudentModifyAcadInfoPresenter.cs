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

namespace PresentationLayer.Presenters.Admin
{
    internal class StudentModifyAcadInfoPresenter
    {
        public StudentModifyAcadInfoPresenter(IStudentModifyAcadInfoControl studentAcadInfoControl)
        {
            _studentAcadInfoControl = studentAcadInfoControl;

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
        }

        private void SearchSrCodeTextBox_Pressed(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SeachSrCodeButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OpenModifyFormButton_Clicked(object sender, EventArgs e)
        {
            IStudentAcadInfoControl studentControl = new StudentAcadInfoControl();
            new AcadInfoPresenter(studentControl);

            if (_studentAcadInfoControl.AddUserControlToMainControl != null)
                _studentAcadInfoControl.AddUserControlToMainControl.Dispose();

            _studentAcadInfoControl.AddUserControlToMainControl = (UserControl)studentControl;
            SetSubmitButtonVisibility(studentControl, "UPDATE");
        }

        private void OpenDropFormButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OpenAddFormButton_Clicked(object sender, EventArgs e)
        {
            IStudentAcadInfoControl studentControl = new StudentAcadInfoControl();
            new AcadInfoPresenter(studentControl);

            if (_studentAcadInfoControl.AddUserControlToMainControl != null)
                _studentAcadInfoControl.AddUserControlToMainControl.Dispose();

            _studentAcadInfoControl.AddUserControlToMainControl = (UserControl) studentControl;
            SetSubmitButtonVisibility(studentControl, "ADD");
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

        public void StudentAcadControl_Load(object sender, EventArgs e)
        {
            try
            {
                StudentAcademicInfoServices services = new StudentAcademicInfoServices();
                List<RStudentAcademicInfoModel> studentList = services.GetAll();

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
        private void AddStudentAcademicInfoToObject(ref object[] studentObj, 
                                    RStudentAcademicInfoModel studentInfo)
        {
            studentObj[0] = studentInfo.SrCode;
            studentObj[1] = studentInfo.LastName;
            studentObj[2] = studentInfo.FirstName;
            studentObj[3] = studentInfo.MiddleName;
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


        IStudentModifyAcadInfoControl _studentAcadInfoControl;
    }
}
