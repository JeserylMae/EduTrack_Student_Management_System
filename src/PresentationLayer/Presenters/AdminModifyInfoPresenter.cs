
using System;
using System.Windows.Forms;
using PresentationLayer.UserControls.MainControls;
using PresentationLayer.UserControls.AdminSubControls;
using System.Collections.Generic;
using DomainLayer.DataModels;
using ServiceLayer.Database;


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
            throw new NotImplementedException();
        }


        #region Helper methods
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
            studentInfo[8] = student.ZipCode;
            studentInfo[9] = student.Barangay;
            studentInfo[10] = student.Municipality;
            studentInfo[11] = student.Province;
            studentInfo[12] = $"{student.GuardianFirstName} "
                            + $"{student.GuardianMiddleName[0]}. "
                            + $"{student.GuardianLastName}";
            studentInfo[13] = student.GuardianZipCode != string.Empty?
                              $"{student.GuardianZipCode} {address}"
                              : address;          
            studentInfo[14] = student.GuardianContactNumber;
        }
        #endregion


        private IAdminModifyInfoControl _adminModifyInfoControl;
    }
}
