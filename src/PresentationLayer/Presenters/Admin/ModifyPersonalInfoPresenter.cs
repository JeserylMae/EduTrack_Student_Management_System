
using System;
using System.Windows.Forms;
using PresentationLayer.UserControls.MainControls;
using PresentationLayer.UserControls.AdminSubControls;
using System.Collections.Generic;
using DomainLayer.DataModels;
using ServiceLayer.Database;
using System.Reflection;
using PresentationLayer.UserControls.HomeSubControls;
using PresentationLayer.Views;
using PresentationLayer.Presenters.General;
using PresentationLayer.Presenters.Enumerations;
using System.Threading.Tasks;
using DomainLayer.DataModels.Instructor;
using System.Runtime.CompilerServices;


namespace PresentationLayer.Presenters.Admin
{
    public class ModifyPersonalInfoPresenter
    {
        public ModifyPersonalInfoPresenter(IModifyPersonalInfoControl adminModifyInfoControl)
        {
            _adminModifyInfoControl = adminModifyInfoControl;

            _adminModifyInfoControl.ControlLoad       += InfoTable_OnLoadAsync;
            _adminModifyInfoControl.ViewAddForm       += OpenAddFormButton_Clicked;
            _adminModifyInfoControl.ViewUpdateForm    += OpenModifyFormButton_Clicked;
            _adminModifyInfoControl.DeleteSelectedRow    += DeleteSelectedRowButton_Clicked;
            _adminModifyInfoControl.SearchButtonClicked  += SearchButton_Clicked;
            _adminModifyInfoControl.SearchTextBoxKeyDown += SearchTextBox_KeyDown;

            _adminModifyInfoControl.ExitButtonClicked             += GeneralPresenter.TriggerAppExit;
            _adminModifyInfoControl.FileDropDownButtonClicked     += FileDropDownButton_Clicked;
            _adminModifyInfoControl.CloseEditorButtonClicked      += CloseEditorButton_Clicked;
            _adminModifyInfoControl.StudAcadInfoButtonClicked     += StudAcadInfoButton_Clicked;
            _adminModifyInfoControl.ItrAcadInfoButtonClicked      += ItrAcadInfoButton_Clicked;
            _adminModifyInfoControl.ItrPersonalInfoButtonClicked  += ItrPersonalInfoButton_Clicked;
            _adminModifyInfoControl.StudPersonalInfoButtonClicked += StudPersonalInfoButton_Clicked;
        }

        private void StudPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            if (_adminModifyInfoControl.ModifyUser != AccessType.INSTRUCTOR)
                return;

            IModifyPersonalInfoControl userControl = new ModifyPersonalInfoControl();
            userControl.ModifyUser = AccessType.STUDENT;

            new ModifyPersonalInfoPresenter(userControl);

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, EventArgs.Empty);

            _adminModifyInfoControl.DisposeControl();
        }

        private void ItrPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            if (_adminModifyInfoControl.ModifyUser != AccessType.STUDENT)
                return;

            IModifyPersonalInfoControl userControl = new ModifyPersonalInfoControl();
            userControl.ModifyUser = AccessType.INSTRUCTOR;

            new ModifyPersonalInfoPresenter(userControl);

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, EventArgs.Empty);

            _adminModifyInfoControl.DisposeControl();
        }

        private void ItrAcadInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyAcadInfoControl userControl = new ModifyAcadInfoControl();
            userControl.ModifyUser = AccessType.INSTRUCTOR;

            new ModifyAcadInfoPresenter(userControl);

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _adminModifyInfoControl.DisposeControl();
        }

        private void StudAcadInfoButton_Clicked(object sender, EventArgs e)
        {
            IModifyAcadInfoControl userControl = new ModifyAcadInfoControl();
            userControl.ModifyUser = AccessType.STUDENT;

            new ModifyAcadInfoPresenter(userControl);

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, EventArgs.Empty);

            _adminModifyInfoControl.DisposeControl();
        }

        private void CloseEditorButton_Clicked(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            new HomePagePresenter(homePage);

            IAdminHomeRightControl adminHomeRightControl = new AdminHomeRightControl();
            new AdminHomeRightPresenter(adminHomeRightControl);

            homePage.RightUserControlPage = (UserControl)adminHomeRightControl;

            GeneralPresenter.NewWindowControl = (UserControl)homePage;
            GeneralPresenter.TriggerWindowControlChange(sender, e);
        }

        private void InfoTable_OnLoadAsync(object sender, EventArgs e)
        {
            try
            {
                if (_adminModifyInfoControl.ModifyUser == AccessType.STUDENT)
                {
                    if (_adminModifyInfoControl.AccessInfoTable.Columns.Contains("InstructorCode"))
                        _adminModifyInfoControl.AccessInfoTable.Columns.Remove("InstructorCode");
                    _ = LoadStudentInfoTable();
                }
                else if (_adminModifyInfoControl.ModifyUser == AccessType.INSTRUCTOR)
                {
                    if (_adminModifyInfoControl.AccessInfoTable.Columns.Contains("SrCode"))
                        _adminModifyInfoControl.AccessInfoTable.Columns.Remove("SrCode");

                    _adminModifyInfoControl.AccessSearchUsrCodeButton.Text = "Search Itr-Code";
                    _adminModifyInfoControl.AccessPageLabel.Text = "Instructor Personal Information";
                    _ = LoadInstructorInfoTable();
                }
            }
            catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
        }

        private async void InfoTable_SelectionChanged(object sender, EventArgs e)
        {
            if (_adminModifyInfoControl.SelectedRowCollection.Count <= 0)
                return;

            DataGridViewRow selectedRow = _adminModifyInfoControl.SelectedRowCollection[0];
            
            if (_adminModifyInfoControl.ModifyUser == AccessType.STUDENT)
                await HandleStudentSelectionChanged(selectedRow);
            else if (_adminModifyInfoControl.ModifyUser == AccessType.INSTRUCTOR)
                await HandleInstructorSelectionChanged(selectedRow);
        }

        private void OpenAddFormButton_Clicked(object sender, EventArgs e)
        {
            IPersonalInfoControl personalInfoControl = new PersonalInfoControl();
            personalInfoControl.InfoTableReloadTriggered += InfoTable_OnLoadAsync;
            personalInfoControl.ModifyUser = _adminModifyInfoControl.ModifyUser;

            new PersonalInfoPresenter(personalInfoControl);
            personalInfoControl.ShowAddButton();

            if (_openUserControl != null) _openUserControl.Dispose();

            _openUserControl = (UserControl)personalInfoControl;
            _adminModifyInfoControl.MainControlHolderControl = (UserControl)personalInfoControl;
        }

        private void OpenModifyFormButton_Clicked(object sender, EventArgs e)
        {
            IPersonalInfoControl personalInfoControl = new PersonalInfoControl();
            personalInfoControl.InfoTableReloadTriggered += InfoTable_OnLoadAsync;
            personalInfoControl.ModifyUser = _adminModifyInfoControl.ModifyUser;

            new PersonalInfoPresenter (personalInfoControl);
            personalInfoControl.ShowUpdateButton();

            if (_openUserControl != null) _openUserControl.Dispose();
            _openUserControl = (UserControl)personalInfoControl;

            _adminModifyInfoControl.SelectedRowChanged += InfoTable_SelectionChanged;
            _adminModifyInfoControl.PersonalInfoControl = personalInfoControl;
            _adminModifyInfoControl.MainControlHolderControl = (UserControl)personalInfoControl;            
        }

        private async void DeleteSelectedRowButton_Clicked(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = _adminModifyInfoControl.SelectedRowCollection[0];
            
            if (AccessType.STUDENT ==_adminModifyInfoControl.ModifyUser)
                await HandleStudentDeleteRequest(selectedRow);
            else if (AccessType.INSTRUCTOR == _adminModifyInfoControl.ModifyUser)
                await HandleInstructorDeleteRequest(selectedRow);
        }

        private void SearchButton_Clicked(object sender, EventArgs e)
        {
            string usrCode = _adminModifyInfoControl.SearchUsrCodeText;

            if (String.IsNullOrEmpty(usrCode)) return;

            HighlightSearchRow(usrCode);
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            
            SearchButton_Clicked((object)sender, e);
        }

        private void FileDropDownButton_Clicked(object sender, EventArgs e)
        {
            if (_adminModifyInfoControl.AccessFileDropDownLayout.Visible)
                 _adminModifyInfoControl.AccessFileDropDownLayout.Visible = false;
            else _adminModifyInfoControl.AccessFileDropDownLayout.Visible = true;
        }


        #region Helper methods
        private async Task HandleStudentDeleteRequest(DataGridViewRow selectedRow)
        {
            PStudentPersonalInfoParams codes = new PStudentPersonalInfoParams();

            string srCode = selectedRow.Cells["SrCode"].Value.ToString();

            DialogResult result = ConfirmDelete(srCode);

            if (result == DialogResult.Yes)
            {
                AssignValuesToObject(ref codes, srCode);
                StudentPersonalInfoServices services = new StudentPersonalInfoServices();

                bool response = await services.Delete(codes);

                DisplayDeleteConfirmationMessage(response, srCode);
                _adminModifyInfoControl.TriggerInfoTableReload();
            }
        }

        private async Task HandleInstructorDeleteRequest(DataGridViewRow selectedRow)
        {
            PInstructorPersonalInfoParams codes = new PInstructorPersonalInfoParams();

            string itrCode = selectedRow.Cells["InstructorCode"].Value.ToString();

            DialogResult result = ConfirmDelete(itrCode);

            if (result == DialogResult.Yes)
            {
                AssignValuesToObject(ref codes, itrCode);
                InstructorPersonalInfoServices services = new InstructorPersonalInfoServices();

                bool response = await services.Delete(codes);

                DisplayDeleteConfirmationMessage(response, itrCode);
                _adminModifyInfoControl.TriggerInfoTableReload();
            }
        }

        private async Task HandleInstructorSelectionChanged(DataGridViewRow selectedRow)
        {
            string UserId = selectedRow.Cells["InstructorCode"].Value.ToString();

            RInstructorPersonalInfoModel student = new RInstructorPersonalInfoModel();
            InstructorPersonalInfoServices services = new InstructorPersonalInfoServices();

            student = await services.GetById(UserId);

            _adminModifyInfoControl.PersonalInfoControl.DisableDefaultPasswordTextBox();
            DisplaySelectedToPersonalInfoControl(student);
        }

        private async Task HandleStudentSelectionChanged(DataGridViewRow selectedRow)
        {
            string UserId = selectedRow.Cells["SrCode"].Value.ToString();

            RStudentPersonalInfoModel student = new RStudentPersonalInfoModel();
            StudentPersonalInfoServices services = new StudentPersonalInfoServices();

            student = await services.GetById(UserId);

            _adminModifyInfoControl.PersonalInfoControl.DisableDefaultPasswordTextBox();
            DisplaySelectedToPersonalInfoControl(student);
        }

        private void HighlightSearchRow(string usrCode)
        {
            for (int i = 0; i < _adminModifyInfoControl.InfoTableRows.Count; i++)
            {
                string columnName = (_adminModifyInfoControl.ModifyUser == AccessType.STUDENT)
                                  ? "SrCode" : "InstructorCode";

                string tempSrCode = _adminModifyInfoControl.InfoTableRows[i].Cells[columnName].Value.ToString();

                if (tempSrCode == usrCode)
                    _adminModifyInfoControl.InfoTableRows [i].Selected = true;
                else
                    _adminModifyInfoControl.InfoTableRows[i].Selected = false;
            }
        }

        private DialogResult ConfirmDelete(string usrCode)
        {
            string message = "";
            string header = "";
            MessageBoxButtons buttons;

            if (_adminModifyInfoControl.ModifyUser == AccessType.STUDENT)
            {
                message = $"Are you sure you want to delete informations about student with Sr-Code {usrCode}?";
                header = "Student Personal Information - Delete";
                buttons = MessageBoxButtons.YesNo;
            }
            else if (_adminModifyInfoControl.ModifyUser == AccessType.INSTRUCTOR)
            {
                message = $"Are you sure you want to delete informations about instructor with code {usrCode}?";
                header = "Instructor Personal Information - Delete";
                buttons = MessageBoxButtons.YesNo;
            }
            else
            {
                message = $"Cannot modify current user type.";
                header = $"{_adminModifyInfoControl.ModifyUser.ToString()} Personal Information - Delete";
                buttons = MessageBoxButtons.OK;
            }

            return MessageBox.Show(message, header, buttons, MessageBoxIcon.Warning);
        }

        private void DisplayDeleteConfirmationMessage(bool deleteSuccessful, string usrCode)
        {
            string userType = (_adminModifyInfoControl.ModifyUser == AccessType.STUDENT)
                            ? "Student|Sr-Code" : "Instructor|code";

            string message = (deleteSuccessful)
                ? $"Successfully deleted {userType.Split('|')[0].ToLower()} with {userType.Split('|')[1]} {usrCode}."
                : $"Failed to delete {userType.Split('|')[0].ToLower()} with {userType.Split('|')[1]} {usrCode}.";

            string header = $"{userType.Split('|')[0]} Personal Information - Delete";

            MessageBox.Show(message, header,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void AssignValuesToObject(ref PStudentPersonalInfoParams codes, string srCode)
        {
            codes.SrCode              = srCode;
            codes.UserNameCode        = $"{srCode}-STU";
            codes.UserAddressCode     = $"{srCode}-STU";
            codes.GuardianNameCode    = $"{srCode}-GUA";
            codes.GuardianAddressCode = $"{srCode}-GUA";
        }

        private void AssignValuesToObject(ref PInstructorPersonalInfoParams codes, string itrCode)
        {
            codes.ItrCode = itrCode;
            codes.UserNameCode = $"{itrCode}-STU";
            codes.UserAddressCode = $"{itrCode}-STU";
            codes.GuardianNameCode = $"{itrCode}-GUA";
            codes.GuardianAddressCode = $"{itrCode}-GUA";
        }

        private void AddStudentPersonalInfoToObject(ref object[] studentInfo,
                                            RStudentPersonalInfoModel student)
        {
            string address = $"{student.GuardianBarangay}, "
                           + $"{student.GuardianMunicipality}, "
                           + $"{student.GuardianProvince}";

            studentInfo[0] = student.SrCode;
            studentInfo[1] = student.LastName;
            studentInfo[2] = student.FirstName;
            studentInfo[3] = student.MiddleName;
            studentInfo[4] = student.BirthDate;
            studentInfo[5] = student.Gender;
            studentInfo[6] = student.ContactNumber;
            studentInfo[7] = student.EmailAddress;
            studentInfo[8] = student.HouseNumber;
            studentInfo[9] = student.Barangay;
            studentInfo[10] = student.Municipality;
            studentInfo[11] = student.Province;
            studentInfo[12] = $"{student.GuardianFirstName} "
                            + $"{student.GuardianMiddleName[0]}. "
                            + $"{student.GuardianLastName}";
            studentInfo[13] = student.GuardianHouseNumber!= string.Empty?
                              $"{student.GuardianHouseNumber} {address}"
                              : address;          
            studentInfo[14] = student.GuardianContactNumber;
        }

        private void AddStudentPersonalInfoToObject(ref object[] instructorInfo,
                                            RInstructorPersonalInfoModel instructor)
        {
            string address = $"{instructor.GuardianBarangay}, "
                           + $"{instructor.GuardianMunicipality}, "
                           + $"{instructor.GuardianProvince}";

            instructorInfo[0] = instructor.ItrCode;
            instructorInfo[1] = instructor.LastName;
            instructorInfo[2] = instructor.FirstName;
            instructorInfo[3] = instructor.MiddleName;
            instructorInfo[4] = instructor.BirthDate;
            instructorInfo[5] = instructor.Gender;
            instructorInfo[6] = instructor.ContactNumber;
            instructorInfo[7] = instructor.EmailAddress;
            instructorInfo[8] = instructor.HouseNumber;
            instructorInfo[9] = instructor.Barangay;
            instructorInfo[10] = instructor.Municipality;
            instructorInfo[11] = instructor.Province;
            instructorInfo[12] = $"{instructor.GuardianFirstName} "
                            + $"{instructor.GuardianMiddleName[0]}. "
                            + $"{instructor.GuardianLastName}";
            instructorInfo[13] = instructor.GuardianHouseNumber != string.Empty ?
                              $"{instructor.GuardianHouseNumber} {address}"
                              : address;
            instructorInfo[14] = instructor.GuardianContactNumber;
        }

        private void DisplaySelectedToPersonalInfoControl(RStudentPersonalInfoModel student)
        {
            _adminModifyInfoControl.PersonalInfoControl.UserCodeTextboxText   = student.SrCode;
            _adminModifyInfoControl.PersonalInfoControl.LastNameTextboxText   = student.LastName;
            _adminModifyInfoControl.PersonalInfoControl.FirstNameTextboxText  = student.FirstName;
            _adminModifyInfoControl.PersonalInfoControl.MiddleNameTextboxText = student.MiddleName;

            _adminModifyInfoControl.PersonalInfoControl.GenderComboBoxText         = student.Gender;
            _adminModifyInfoControl.PersonalInfoControl.ContactNumberTextboxText   = student.ContactNumber;
            _adminModifyInfoControl.PersonalInfoControl.EmailAddresTextboxText     = student.EmailAddress;
            _adminModifyInfoControl.PersonalInfoControl.DefaultPasswordTextboxText = "•••";

            _adminModifyInfoControl.PersonalInfoControl.MonthComboBoxText = student.BirthDate.Split(' ')[0].ToUpper();
            _adminModifyInfoControl.PersonalInfoControl.DayComboBoxText   = student.BirthDate.Split(' ')[1].TrimEnd(',');
            _adminModifyInfoControl.PersonalInfoControl.YearComboBoxText  = student.BirthDate.Split(' ')[2];

            _adminModifyInfoControl.PersonalInfoControl.ZipCodeTextboxText      = student.HouseNumber;
            _adminModifyInfoControl.PersonalInfoControl.BarangayTextboxText     = student.Barangay;
            _adminModifyInfoControl.PersonalInfoControl.MunicipalityTextboxText = student.Municipality;
            _adminModifyInfoControl.PersonalInfoControl.ProvinceTextboxText     = student.Province;

            _adminModifyInfoControl.PersonalInfoControl.GuardianLastNameTextboxText      = student.GuardianLastName;
            _adminModifyInfoControl.PersonalInfoControl.GuardianFirstNameTextboxText     = student.GuardianFirstName;
            _adminModifyInfoControl.PersonalInfoControl.GuardianMiddleNameTextboxText    = student.MiddleName;
            _adminModifyInfoControl.PersonalInfoControl.GuardianContactNumberTextboxText = student.GuardianContactNumber;

            _adminModifyInfoControl.PersonalInfoControl.GuardianZipCodeTextboxText      = student.GuardianHouseNumber;
            _adminModifyInfoControl.PersonalInfoControl.GuardianBarangayTextboxText     = student.GuardianBarangay;
            _adminModifyInfoControl.PersonalInfoControl.GuardianMunicipalityTextboxText = student.GuardianMunicipality;
            _adminModifyInfoControl.PersonalInfoControl.GuardianProvinceTextboxText     = student.GuardianProvince;
        }

        private void DisplaySelectedToPersonalInfoControl(RInstructorPersonalInfoModel instructor)
        {
            _adminModifyInfoControl.PersonalInfoControl.UserCodeTextboxText   = instructor.ItrCode;
            _adminModifyInfoControl.PersonalInfoControl.LastNameTextboxText   = instructor.LastName;
            _adminModifyInfoControl.PersonalInfoControl.FirstNameTextboxText  = instructor.FirstName;
            _adminModifyInfoControl.PersonalInfoControl.MiddleNameTextboxText = instructor.MiddleName;

            _adminModifyInfoControl.PersonalInfoControl.GenderComboBoxText         = instructor.Gender;
            _adminModifyInfoControl.PersonalInfoControl.ContactNumberTextboxText   = instructor.ContactNumber;
            _adminModifyInfoControl.PersonalInfoControl.EmailAddresTextboxText     = instructor.EmailAddress;
            _adminModifyInfoControl.PersonalInfoControl.DefaultPasswordTextboxText = "•••";

            _adminModifyInfoControl.PersonalInfoControl.MonthComboBoxText = instructor.BirthDate.Split(' ')[0].ToUpper();
            _adminModifyInfoControl.PersonalInfoControl.DayComboBoxText   = instructor.BirthDate.Split(' ')[1].TrimEnd(',');
            _adminModifyInfoControl.PersonalInfoControl.YearComboBoxText  = instructor.BirthDate.Split(' ')[2];

            _adminModifyInfoControl.PersonalInfoControl.ZipCodeTextboxText      = instructor.HouseNumber;
            _adminModifyInfoControl.PersonalInfoControl.BarangayTextboxText     = instructor.Barangay;
            _adminModifyInfoControl.PersonalInfoControl.MunicipalityTextboxText = instructor.Municipality;
            _adminModifyInfoControl.PersonalInfoControl.ProvinceTextboxText         = instructor.Province;

            _adminModifyInfoControl.PersonalInfoControl.GuardianLastNameTextboxText      = instructor.GuardianLastName;
            _adminModifyInfoControl.PersonalInfoControl.GuardianFirstNameTextboxText     = instructor.GuardianFirstName;
            _adminModifyInfoControl.PersonalInfoControl.GuardianMiddleNameTextboxText    = instructor.MiddleName;
            _adminModifyInfoControl.PersonalInfoControl.GuardianContactNumberTextboxText = instructor.GuardianContactNumber;

            _adminModifyInfoControl.PersonalInfoControl.GuardianZipCodeTextboxText      = instructor.GuardianHouseNumber;
            _adminModifyInfoControl.PersonalInfoControl.GuardianBarangayTextboxText     = instructor.GuardianBarangay;
            _adminModifyInfoControl.PersonalInfoControl.GuardianMunicipalityTextboxText = instructor.GuardianMunicipality;
            _adminModifyInfoControl.PersonalInfoControl.GuardianProvinceTextboxText     = instructor.GuardianProvince;
        }

        private async Task LoadStudentInfoTable()
        {
            StudentPersonalInfoServices services = new StudentPersonalInfoServices();
            List<RStudentPersonalInfoModel> list = await services.GetAll();

            _adminModifyInfoControl.ClearInfoTable();

            foreach (RStudentPersonalInfoModel student in list)
            {
                object[] studentInfo = new object[15];

                AddStudentPersonalInfoToObject(ref studentInfo, student);
                _adminModifyInfoControl.InfoTableRowData = studentInfo;
            }
        }

        private async Task LoadInstructorInfoTable()
        {
            InstructorPersonalInfoServices services = new InstructorPersonalInfoServices();
            List<RInstructorPersonalInfoModel> list = await services.GetAll();

            _adminModifyInfoControl.ClearInfoTable();

            foreach(RInstructorPersonalInfoModel instructor in list)
            {
                object[] instructorInfo = new object[15];
                AddStudentPersonalInfoToObject(ref instructorInfo, instructor);
                _adminModifyInfoControl.InfoTableRowData = instructorInfo;
            }
        }
        #endregion


        private UserControl _openUserControl;
        private IModifyPersonalInfoControl _adminModifyInfoControl;
    }
}
