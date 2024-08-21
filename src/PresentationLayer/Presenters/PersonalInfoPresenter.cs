
using DomainLayer.DataModels;
using PresentationLayer.UserControls.AdminSubControls;
using ServiceLayer.Database;
using System;
using System.Windows;


namespace PresentationLayer.Presenters
{
    public class PersonalInfoPresenter
    {
        public PersonalInfoPresenter(IPersonalInfoControl personalInfoControl)
        {
            _personalInfoControl = personalInfoControl;

            _personalInfoControl.TopCloseButtonClicked   += CloseCancelButton_Clicked;
            _personalInfoControl.BotCancelButtonClicked  += CloseCancelButton_Clicked;
            _personalInfoControl.AddNewStudentInfoSubmit += SubmitAddNewInfoButton_Clicked;
            _personalInfoControl.UpdateStudentInfoSubmit += SubmitUpdateInfoButton_Clicked;
        }

        private void CloseCancelButton_Clicked(object sender, EventArgs e)
        {
            _personalInfoControl.DestroyControl();
        }
                
        private async void SubmitAddNewInfoButton_Clicked(object sender, EventArgs e)
        {
            StudentPersonalInfoModel studentPersonalInfoModel = new StudentPersonalInfoModel();
            PersonalInfoModel<StudentPersonalInfoModel> model = new PersonalInfoModel<StudentPersonalInfoModel>();

            AddValuesToStudentPersonalInfoModel(ref studentPersonalInfoModel);
            AddValuesToPersonalInfoModel(ref model, studentPersonalInfoModel);

            StudentPersonalInfoServices services = new StudentPersonalInfoServices();
            bool response = await services.InsertNew(model);

            EvaluateResponse(response, studentPersonalInfoModel.SrCode);
        }

        private void SubmitUpdateInfoButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #region Helper Methods
        private void EvaluateResponse(bool response, string srcode)
        {
            string MessageBoxTitle = "Student Personal Information - Add";

            if (response) 
            {
                MessageBox.Show($"Successfully added student with SR Code {srcode}.",
                                MessageBoxTitle,
                                MessageBoxButton.OK,
                                MessageBoxImage.Information); 
            }
            else
            {
                MessageBox.Show($"Failed to add student with SR Code {srcode}.",
                                MessageBoxTitle,
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }
        
        private void AddValuesToPersonalInfoModel(ref PersonalInfoModel<StudentPersonalInfoModel> model,
                                                  StudentPersonalInfoModel student)
        {
            model.InfoModel = student;
            model.DefaultPassword = _personalInfoControl.DefaultPasswordTextboxText;
            model.Position = "STUDENT";
            model.StudentCode = student.SrCode + "-STU";
            model.GuardianCode = student.SrCode + "-GUA";
        }

        private void AddValuesToStudentPersonalInfoModel(ref StudentPersonalInfoModel student)
        {
            student.BirthDate = _personalInfoControl.MonthComboBoxText + "-"
                              + _personalInfoControl.DayComboBoxText + "-"
                              + _personalInfoControl.YearComboBoxText;

            student.SrCode                = _personalInfoControl.UserCodeTextboxText;
            student.LastName              = _personalInfoControl.LastNameTextboxText;
            student.Gender                = _personalInfoControl.GenderComboBoxText;
            student.ZipCode               = _personalInfoControl.ZipCodeTextboxText;
            student.Barangay              = _personalInfoControl.BarangayTextboxText;
            student.Province              = _personalInfoControl.ProvinceTextboxText;
            student.FirstName             = _personalInfoControl.FirstNameTextboxText;
            student.MiddleName            = _personalInfoControl.MiddleNameTextboxText;
            student.EmailAddress          = _personalInfoControl.EmailAddresTextboxText;
            student.Municipality          = _personalInfoControl.MunicipalityTextboxText;
            student.ContactNumber         = _personalInfoControl.ContactNumberTextboxText;
            student.GuardianZipCode       = _personalInfoControl.GuardianZipCodeTextboxText;
            student.GuardianBarangay      = _personalInfoControl.GuardianBarangayTextboxText;
            student.GuardianLastName      = _personalInfoControl.GuardianLastNameTextboxText;
            student.GuardianProvince      = _personalInfoControl.GuardianProvinceTextboxText;
            student.GuardianFirstName     = _personalInfoControl.GuardianFirstNameTextboxText;
            student.GuardianMiddleName    = _personalInfoControl.GuardianMiddleNameTextboxText;
            student.GuardianMunicipality  = _personalInfoControl.GuardianMiddleNameTextboxText;
            student.GuardianContactNumber = _personalInfoControl.GuardianContactNumberTextboxText;
        }
        #endregion

        private IPersonalInfoControl _personalInfoControl;
    }
}
