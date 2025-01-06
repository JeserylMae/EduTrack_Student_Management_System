
using System;
using System.Collections.Generic;


namespace PresentationLayer.UserControls.AdminSubControls
{
    public interface IStudentPersonalInfoControl
    {
        void ShowAddButton();
        void DestroyControl();
        void ShowUpdateButton();
        void TriggerInfoTableReload();
        void DisableDefaultPasswordTextBox();

        event EventHandler OnControlLoad;
        event EventHandler TopCloseButtonClicked;
        event EventHandler BotCancelButtonClicked;
        event EventHandler AddNewStudentInfoSubmit;
        event EventHandler UpdateStudentInfoSubmit;
        event EventHandler InfoTableReloadTriggered;

        string PageIndicatorLabelText        { set; }
        string UserCodeIndicatorLabelText    { set; }
        string BasicInfoIndicatorLabelText   { set; }
        IList<string> YearComboBoxDataSource { set; }

        string UserCodeTextboxText              { get; set; }
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
    }
}
