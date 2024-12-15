﻿
using System;
using System.Windows.Forms;
using PresentationLayer.UserControls.MainControls;
using PresentationLayer.UserControls.AdminSubControls;
using System.Collections.Generic;
using DomainLayer.DataModels;
using ServiceLayer.Database;
using System.Reflection;


namespace PresentationLayer.Presenters
{
    public class AdminModifyInfoPresenter
    {
        public AdminModifyInfoPresenter(IAdminModifyInfoControl adminModifyInfoControl)
        {
            _adminModifyInfoControl = adminModifyInfoControl;

            _adminModifyInfoControl.ControlLoad       += InfoTable_OnLoadAsync;
            _adminModifyInfoControl.ViewAddForm       += OpenAddFormButton_Clicked;
            _adminModifyInfoControl.ViewUpdateForm    += OpenModifyFormButton_Clicked;
            _adminModifyInfoControl.DeleteSelectedRow += DeleteSelectedRowButton_Clicked;
        }

        private async void InfoTable_OnLoadAsync(object sender, EventArgs e)
        {
            try
            {
                StudentPersonalInfoServices services = new StudentPersonalInfoServices();
                List<StudentPersonalInfoModel> list = await services.GetAll();

                _adminModifyInfoControl.ClearInfoTable();

                foreach (StudentPersonalInfoModel student in list)
                {
                    object[] studentInfo = new object[15];

                    AddStudentPersonalInfoToObject(ref studentInfo, student);
                    _adminModifyInfoControl.InfoTableRowData = studentInfo;
                }
            }
            catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
        }

        private async void InfoTable_SelectionChanged(object sender, EventArgs e)
        {
            if (_adminModifyInfoControl.SelectedRowCollection.Count <= 0)
                return;

            DataGridViewRow selectedRow = _adminModifyInfoControl.SelectedRowCollection[0];
            string UserId               = selectedRow.Cells["SrCode"].Value.ToString();

            StudentPersonalInfoModel student     = new StudentPersonalInfoModel();
            StudentPersonalInfoServices services = new StudentPersonalInfoServices();

            student = await services.GetById(UserId);

            _adminModifyInfoControl.PersonalInfoControl.DisableDefaultPasswordTextBox();
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
            personalInfoControl.InfoTableReloadTriggered += InfoTable_OnLoadAsync;

            new PersonalInfoPresenter (personalInfoControl);
            personalInfoControl.ShowUpdateButton();

            _adminModifyInfoControl.SelectedRowChanged += InfoTable_SelectionChanged;
            _adminModifyInfoControl.PersonalInfoControl = personalInfoControl;
            _adminModifyInfoControl.MainControlHolderControl = (UserControl)personalInfoControl;            
        }

        private async void DeleteSelectedRowButton_Clicked(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = _adminModifyInfoControl.SelectedRowCollection[0];
            StudentPersonalInfoCodeModel codes = new StudentPersonalInfoCodeModel();

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


        #region Helper methods
        private DialogResult ConfirmDelete(string srCode)
        {
            return MessageBox.Show(
                $"Are you sure you want to delete informations about student with Sr-Code {srCode}?",
                "Student Personal Info - Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
        }

        private void DisplayDeleteConfirmationMessage(bool deleteSuccessful, string srCode)
        {
            string confirmationMessage = deleteSuccessful ?
                    $"Successfully deleted student with SR-Code {srCode}." :
                    $"Failed to delete student with Sr-Code {srCode}.";

            MessageBox.Show(confirmationMessage,
                "Student Personal Info - Delete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void AssignValuesToObject(ref StudentPersonalInfoCodeModel codes, string srCode)
        {
            codes.SrCode              = srCode;
            codes.StudentNameCode     = $"{srCode}-STU";
            codes.StudentAddressCode  = $"{srCode}-STU";
            codes.GuardianNameCode    = $"{srCode}-GUA";
            codes.GuardianAddressCode = $"{srCode}-GUA";
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

        private void DisplaySelectedToPersonalInfoControl(StudentPersonalInfoModel student)
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
        #endregion


        private IAdminModifyInfoControl _adminModifyInfoControl;
    }
}
