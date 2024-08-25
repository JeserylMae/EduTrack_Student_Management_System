
using System;
using System.Windows.Forms;
using PresentationLayer.UserControls.MainControls;
using PresentationLayer.UserControls.AdminSubControls;
using System.Collections.Generic;
using DomainLayer.DataModels;
using ServiceLayer.Database;
using System.Threading.Tasks;


namespace PresentationLayer.Presenters
{
    public class AdminModifyInfoPresenter
    {
        public AdminModifyInfoPresenter(IAdminModifyInfoControl adminModifyInfoControl)
        {
            _adminModifyInfoControl = adminModifyInfoControl;

            _adminModifyInfoControl.ControlLoad    += InfoTable_OnLoadAsync;
            _adminModifyInfoControl.ViewAddForm    += OpenAddFormButton_Clicked;
            _adminModifyInfoControl.ViewUpdateForm += OpenModifyFormButton_Clicked;
        }

        private async void InfoTable_OnLoadAsync(object sender, EventArgs e)
        {
            StudentPersonalInfoServices services = new StudentPersonalInfoServices();
            List<StudentPersonalInfoModel> list = await services.GetAll();

            _adminModifyInfoControl.ClearInfoTable();
            
            foreach(StudentPersonalInfoModel student in list)
            {
                object[] studentInfo = new object[15];
                AddStudentPersonalInfoToObject(ref studentInfo, student);
               
                _adminModifyInfoControl.InfoTableRowData = studentInfo;
            }
        }

        private async void InfoTable_SelectionChanged(object sender, EventArgs e)
        {
            if (_adminModifyInfoControl.SelectedRowCollection.Count < 0)
                return;

            DataGridViewRow selectedRow = _adminModifyInfoControl.SelectedRowCollection[0];
            string UserId               = selectedRow.Cells["SrCode"].Value.ToString();

            StudentPersonalInfoModel student     = new StudentPersonalInfoModel();
            StudentPersonalInfoServices services = new StudentPersonalInfoServices();

            student = await services.GetById(UserId);

            DisplaySelectedToPersonalInfoControl(student);
        }

        private void OpenAddFormButton_Clicked(object sender, EventArgs e)
        {
            IPersonalInfoControl personalInfoControl = new PersonalInfoControl();
            personalInfoControl.InfoTableReloadTriggered += InfoTable_OnLoadAsync;

            new PersonalInfoPresenter(personalInfoControl);
            personalInfoControl.ShowAddButton();

            _adminModifyInfoControl.MainControlHolderControl = (UserControl)personalInfoControl;
        }

        private void OpenModifyFormButton_Clicked(object sender, EventArgs e)
        {
            IPersonalInfoControl personalInfoControl = new PersonalInfoControl();
            new PersonalInfoPresenter (personalInfoControl);
            personalInfoControl.ShowUpdateButton();

            _adminModifyInfoControl.SelectedRowChanged += InfoTable_SelectionChanged;
            _adminModifyInfoControl.PersonalInfoControl = personalInfoControl;
            _adminModifyInfoControl.MainControlHolderControl = (UserControl)personalInfoControl;            
        }


        #region Helper methods
        private void DisplaySelectedToPersonalInfoControl(StudentPersonalInfoModel student)
        {
            /*
             Create an update stored procedure.
            Make sure that it only include the fields in StudentPersonalInfoModel.
            Also display only the fields inside StudentPersonalInfoModel.
            Also default password and srcode textboxes should be disabled.
            for default password show only ***. Do not get the default password from the db.
             */

            _adminModifyInfoControl.PersonalInfoControl.UserCodeTextboxText = student.SrCode;

            _adminModifyInfoControl.PersonalInfoControl.LastNameTextboxText = student.LastName;
            _adminModifyInfoControl.PersonalInfoControl.FirstNameTextboxText = student.FirstName;
            _adminModifyInfoControl.PersonalInfoControl.MiddleNameTextboxText =student.MiddleName;

            _adminModifyInfoControl.PersonalInfoControl.GenderComboBoxText = student.Gender;
            _adminModifyInfoControl.PersonalInfoControl.UserCodeTextboxText = student.ContactNumber;

            _adminModifyInfoControl.PersonalInfoControl.ZipCodeTextboxText = selectedRow.Cells["HouseNumber"].Value?.ToString();
            _adminModifyInfoControl.PersonalInfoControl.BarangayTextboxText = selectedRow.Cells["Barangay"]?.Value.ToString();
            _adminModifyInfoControl.PersonalInfoControl.MunicipalityTextboxText = selectedRow.Cells["Municipality"]?.Value.ToString();
            _adminModifyInfoControl.PersonalInfoControl.ProvinceTextboxText = selectedRow.Cells["Province"]?.Value.ToString();

            _adminModifyInfoControl.PersonalInfoControl.GuardianLastNameTextboxText = selectedRow.Cells["EmergencyContactPerson"].Value.ToString().Split(' ')[0];
            _adminModifyInfoControl.PersonalInfoControl.GuardianFirstNameTextboxText = selectedRow.Cells["EmergencyContactPerson"].Value.ToString().Split(' ')[1];
            _adminModifyInfoControl.PersonalInfoControl.GuardianMiddleNameTextboxText = selectedRow.Cells["EmergencyContactPerson"].Value.ToString().Split(' ')[2];
        }

        private void AddStudentPersonalInfoToObject(ref object[] studentInfo,
                                            StudentPersonalInfoModel student)
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
        #endregion


        private IAdminModifyInfoControl _adminModifyInfoControl;
    }
}
