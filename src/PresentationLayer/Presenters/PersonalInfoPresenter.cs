
using DomainLayer.DataModels;
using PresentationLayer.UserControls.AdminSubControls;
using ServiceLayer.Database;
using ServiceLayer.Services;
using System;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
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
            try
            {
                StudentPersonalInfoModel studentPersonalInfoModel = new StudentPersonalInfoModel();
                PersonalInfoModel<StudentPersonalInfoModel> model = new PersonalInfoModel<StudentPersonalInfoModel>();

                AddValuesToStudentPersonalInfoModel(ref studentPersonalInfoModel);
                AddValuesToPersonalInfoModel(studentPersonalInfoModel, ref model);

                StudentPersonalInfoServices services = new StudentPersonalInfoServices();
                ParameterAuthentication authentication = new ParameterAuthentication();

                Task completed = await authentication.ValidateParameter(model);

                if (completed == Task.CompletedTask)
                {
                    bool response = await services.InsertNew(model);
                    ConfirmAdd(response, studentPersonalInfoModel.SrCode);
                    _personalInfoControl.ReloadInfoTable();
                }
            }
            catch (TargetParameterCountException ex) { DisplayError(ex.Message, "Add"); }
            catch (HttpRequestException ex) { DisplayError(ex.Message, "Add"); }
            catch (Exception ex) { DisplayError(ex.Message, "Add"); }
        }

        private void SubmitUpdateInfoButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #region Helper Methods
        private void DisplayError(string message, string commandName)
        {
            MessageBox.Show(message, $"Student Peronal Information - {commandName}",
                            MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void ConfirmAdd(bool response, string srcode)
        {
            if (!response) return;
            
            MessageBox.Show($"Successfully added student with SR Code {srcode}.",
                            "Student Personal Information - Add",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information); 
        }
        
        private void AddValuesToPersonalInfoModel(StudentPersonalInfoModel student,
                             ref PersonalInfoModel<StudentPersonalInfoModel> model)
        {
            model.InfoModel = student;
            model.DefaultPassword = _personalInfoControl.DefaultPasswordTextboxText;
            model.Position = "STUDENT";
            model.StudentCode = student.SrCode + "-STU";
            model.GuardianCode = student.SrCode + "-GUA";
        }

        private void AddValuesToStudentPersonalInfoModel(ref StudentPersonalInfoModel student)
        {
            student.BirthDate = _personalInfoControl.YearComboBoxText + "-"
                              + _personalInfoControl.MonthComboBoxText + "-"
                              + _personalInfoControl.DayComboBoxText;

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
