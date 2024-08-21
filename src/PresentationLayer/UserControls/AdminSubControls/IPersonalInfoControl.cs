
using System;


namespace PresentationLayer.UserControls.AdminSubControls
{
    public interface IPersonalInfoControl
    {
        void ShowAddButton();
        void DestroyControl();
        void ShowUpdateButton();

        string PageIndicatorLabelText      { set; }
        string UserCodeIndicatorLabelText  { set; }
        string BasicInfoIndicatorLabelText { set; }
        string LastNameTextboxText              { get; set; }
        string FirstNameTextboxText             { get; set; }
        string MiddleNameTextboxText            { get; set; }
        string MonthComboBoxText                { get; set; }
        string DayComboBoxText                  { get; set; }
        string YearComboBoxText                 { get; set; }
        string GenderComboBoxText               { get; set; }
        string ZipCodeTextboxText               { get; set; }
        string BarangayTextboxText              { get; set; }
        string MunicipalityTextboxText          { get; set; }
        string ProvinceTextboxText              { get; set; }
        string ContactNumberTextboxText         { get; set; }
        string EmailAddresTextboxText           { get; set; }
        string DefaultPasswordTextboxText       { get; set; }
        string GuardianLastNameTextboxText      { get; set; }
        string GuardianFirstNameTextboxText     { get; set; }
        string GuardianMiddleNameTextboxText    { get; set; }
        string GuardianZipCodeTextboxText       { get; set; }
        string GuardianBarangayTextboxText      { get; set; }
        string GuardianMunicipalityTextboxText  { get; set; }
        string GuardianProvinceTextboxText      { get; set; }
        string GuardianContactNumberTextboxText { get; set; }


        event EventHandler TopCloseButtonClicked;
        event EventHandler BotCancelButtonClicked;
        event EventHandler AddNewStudentInfoSubmit;
        event EventHandler UpdateStudentInfoSubmit;
    }
}
