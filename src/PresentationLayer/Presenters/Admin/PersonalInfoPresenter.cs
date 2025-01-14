﻿
using DomainLayer.DataModels;
using DomainLayer.DataModels.Instructor;
using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.UserControls.AdminSubControls;
using ServiceLayer.Database;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;


namespace PresentationLayer.Presenters.Admin
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
            PersonalInfoControl_OnLoad();
        }


        #region Event Subscribers
        private void PersonalInfoControl_OnLoad()
        {
            IList<string> yearsCollection = new List<string>();
            SetYearOptions(ref yearsCollection);

            _personalInfoControl.YearComboBoxDataSource = yearsCollection;
            _personalInfoControl.YearComboBoxText = null;

            SetPageHeaders();
        }

        private void CloseCancelButton_Clicked(object sender, EventArgs e)
        {
            _personalInfoControl.DestroyControl();
        }
 
        private async void SubmitAddNewInfoButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (_personalInfoControl.ModifyUser == AccessType.STUDENT)
                    await HandleStudentSubmitAdd();
                else if (_personalInfoControl.ModifyUser == AccessType.INSTRUCTOR)
                    await HandleInstructorSubmitAdd();
                else
                    throw new Exception(message: "Invalid user type!");
            }
            catch (TargetParameterCountException ex) { DisplayError(ex.Message, "Add"); }
            catch (HttpRequestException ex) { DisplayError(ex.Message, "Add"); }
            catch (Exception ex) { DisplayError(ex.Message, "Add"); }
        }

        private async void SubmitUpdateInfoButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (_personalInfoControl.ModifyUser == AccessType.STUDENT)
                    await HandleStudentSubmitUpdate();
                else if (_personalInfoControl.ModifyUser == AccessType.INSTRUCTOR)
                    await HandleInstructorSubmitUpdate();
                else
                    throw new Exception(message: "Invalid user type!");
            }
            catch (TargetInvocationException ex) { Console.WriteLine(ex.Message); }
            catch (TargetParameterCountException ex) { DisplayError(ex.Message, "Update"); }
            catch (HttpRequestException ex) { DisplayError(ex.Message, "Update"); }
            catch (Exception ex) { DisplayError(ex.Message, "Update"); }
        }
        #endregion


        #region Helper Methods
        private async Task HandleStudentSubmitUpdate()
        {
            RStudentPersonalInfoModel studentPersonalInfoModel = new RStudentPersonalInfoModel();
            PStudentPersonalInfoModel<RStudentPersonalInfoModel> model = new PStudentPersonalInfoModel<RStudentPersonalInfoModel>();

            AddValuesToPersonalInfoModel(ref studentPersonalInfoModel);
            AddValuesToPersonalInfoModel(studentPersonalInfoModel, ref model);

            ParameterAuthentication authentication = new ParameterAuthentication();
            StudentPersonalInfoServices services = new StudentPersonalInfoServices();

            Task completed = await authentication.ValidateParameter(model, "UPDATE");
            bool response = await services.Update(model);

            ConfirmMessage(response, studentPersonalInfoModel.SrCode, 1);
            _personalInfoControl.TriggerInfoTableReload();
            ClearTextBoxes();
        }

        private async Task HandleInstructorSubmitUpdate()
        {
            RInstructorPersonalInfoModel instructorPersonalInfoModel = new RInstructorPersonalInfoModel();
            PInstructorPersonalInfoModel<RInstructorPersonalInfoModel> model = new PInstructorPersonalInfoModel<RInstructorPersonalInfoModel>();

            AddValuesToPersonalInfoModel(ref instructorPersonalInfoModel);
            AddValuesToPersonalInfoModel(instructorPersonalInfoModel, ref model);

            ParameterAuthentication authentication = new ParameterAuthentication();
            InstructorPersonalInfoServices services = new InstructorPersonalInfoServices();

            Task completed = await authentication.ValidateParameter(model, "UPDATE");
            bool response = await services.Update(model);

            ConfirmMessage(response, instructorPersonalInfoModel.ItrCode, 1);
            _personalInfoControl.TriggerInfoTableReload();
            ClearTextBoxes();
        }

        private async Task HandleStudentSubmitAdd()
        {
            RStudentPersonalInfoModel studentPersonalInfoModel = new RStudentPersonalInfoModel();
            PStudentPersonalInfoModel<RStudentPersonalInfoModel> model = new PStudentPersonalInfoModel<RStudentPersonalInfoModel>();

            AddValuesToPersonalInfoModel(ref studentPersonalInfoModel);
            AddValuesToPersonalInfoModel(studentPersonalInfoModel, ref model);

            ParameterAuthentication authentication = new ParameterAuthentication();
            StudentPersonalInfoServices services = new StudentPersonalInfoServices();

            Task completed = await authentication.ValidateParameter(model, "ADD");
            bool response = await services.InsertNew(model);

            ConfirmMessage(response, studentPersonalInfoModel.SrCode, 0);
            _personalInfoControl.TriggerInfoTableReload();
            ClearTextBoxes();
        }

        private async Task HandleInstructorSubmitAdd()
        {
            RInstructorPersonalInfoModel instructorPersonalInfoModel = new RInstructorPersonalInfoModel();
            PInstructorPersonalInfoModel<RInstructorPersonalInfoModel> model = new PInstructorPersonalInfoModel<RInstructorPersonalInfoModel>();

            AddValuesToPersonalInfoModel(ref instructorPersonalInfoModel);
            AddValuesToPersonalInfoModel(instructorPersonalInfoModel, ref model);

            ParameterAuthentication authentication = new ParameterAuthentication();
            InstructorPersonalInfoServices services = new InstructorPersonalInfoServices();

            Task completed = await authentication.ValidateParameter(model, "ADD");
            bool response = await services.InsertNew(model);

            ConfirmMessage(response, instructorPersonalInfoModel.ItrCode, 0);
            _personalInfoControl.TriggerInfoTableReload();
            ClearTextBoxes();
        }

        private void SetPageHeaders()
        {
            if (AccessType.INSTRUCTOR != _personalInfoControl.ModifyUser)
                return;

            _personalInfoControl.PageIndicatorLabelText = "Instructor Personal Information Form";
            _personalInfoControl.BasicInfoIndicatorLabelText = "Instructor Basic Information";
            _personalInfoControl.UserCodeIndicatorLabelText = "Instructor Code";
        }

        private void SetYearOptions(ref IList<string> years)
        {
            int currentYear = DateTime.Now.Year;
           
            for (int idx = currentYear; idx >= 1950; idx--)
            {
                years.Add(idx.ToString());
            }
        }

        private void DisplayError(string message, string commandName)
        {
            MessageBox.Show(message, $"{_personalInfoControl.ModifyUser.ToString()} PERSONAL INFORMATION - {commandName}",
                            MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void ConfirmMessage(bool response, string srcode, int modification)
        {
            if (!response) return;

            string mod     = modification == 0 ? "Add"   : "Update";
            string message = modification == 0 ? "added" : "updated";
            
            MessageBox.Show($"Successfully {message} {_personalInfoControl.ModifyUser.ToString().ToLower()} with Code {srcode}.",
                            $"{_personalInfoControl.ModifyUser} PERSONAL INFORMATION - {mod}",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information); 
        }
        
        private void AddValuesToPersonalInfoModel(RStudentPersonalInfoModel student,
                             ref PStudentPersonalInfoModel<RStudentPersonalInfoModel> model)
        {
            model.InfoModel = student;
            model.DefaultPassword = string.IsNullOrEmpty(_personalInfoControl.DefaultPasswordTextboxText)?
                                                "null" : _personalInfoControl.DefaultPasswordTextboxText;
            model.Position = "STUDENT";
            model.UserId = student.SrCode + "-STU";
            model.GuardianCode = student.SrCode + "-GUA";
        }

        private void AddValuesToPersonalInfoModel(RInstructorPersonalInfoModel instrcutor,
                             ref PInstructorPersonalInfoModel<RInstructorPersonalInfoModel> model)
        {
            model.InfoModel = instrcutor;
            model.DefaultPassword = string.IsNullOrEmpty(_personalInfoControl.DefaultPasswordTextboxText) ?
                                                "null" : _personalInfoControl.DefaultPasswordTextboxText;
            model.Position = "INSTRUCTOR";
            model.UserId = instrcutor.ItrCode + "-ITR";
            model.GuardianCode = instrcutor.ItrCode + "-GUA";
        }

        private void AddValuesToPersonalInfoModel(ref RStudentPersonalInfoModel student)
        {
            student.BirthDate = _personalInfoControl.YearComboBoxText + "-"
                              + _personalInfoControl.MonthComboBoxText + "-"
                              + _personalInfoControl.DayComboBoxText;

            student.SrCode                = _personalInfoControl.UserCodeTextboxText;
            student.LastName              = _personalInfoControl.LastNameTextboxText;
            student.Gender                = _personalInfoControl.GenderComboBoxText;
            student.HouseNumber           = _personalInfoControl.ZipCodeTextboxText;
            student.Barangay              = _personalInfoControl.BarangayTextboxText;
            student.Province              = _personalInfoControl.ProvinceTextboxText;
            student.FirstName             = _personalInfoControl.FirstNameTextboxText;
            student.MiddleName            = _personalInfoControl.MiddleNameTextboxText;
            student.EmailAddress          = _personalInfoControl.EmailAddresTextboxText;
            student.Municipality          = _personalInfoControl.MunicipalityTextboxText;
            student.ContactNumber         = _personalInfoControl.ContactNumberTextboxText;
            student.GuardianHouseNumber   = _personalInfoControl.GuardianZipCodeTextboxText;
            student.GuardianBarangay      = _personalInfoControl.GuardianBarangayTextboxText;
            student.GuardianLastName      = _personalInfoControl.GuardianLastNameTextboxText;
            student.GuardianProvince      = _personalInfoControl.GuardianProvinceTextboxText;
            student.GuardianFirstName     = _personalInfoControl.GuardianFirstNameTextboxText;
            student.GuardianMiddleName    = _personalInfoControl.GuardianMiddleNameTextboxText;
            student.GuardianMunicipality  = _personalInfoControl.GuardianMunicipalityTextboxText;
            student.GuardianContactNumber = _personalInfoControl.GuardianContactNumberTextboxText;
        }

        private void AddValuesToPersonalInfoModel(ref RInstructorPersonalInfoModel instructor)
        {
            instructor.BirthDate = _personalInfoControl.YearComboBoxText + "-"
                              + _personalInfoControl.MonthComboBoxText + "-"
                              + _personalInfoControl.DayComboBoxText;

            instructor.ItrCode = _personalInfoControl.UserCodeTextboxText;
            instructor.LastName = _personalInfoControl.LastNameTextboxText;
            instructor.Gender = _personalInfoControl.GenderComboBoxText;
            instructor.HouseNumber = _personalInfoControl.ZipCodeTextboxText;
            instructor.Barangay = _personalInfoControl.BarangayTextboxText;
            instructor.Province = _personalInfoControl.ProvinceTextboxText;
            instructor.FirstName = _personalInfoControl.FirstNameTextboxText;
            instructor.MiddleName = _personalInfoControl.MiddleNameTextboxText;
            instructor.EmailAddress = _personalInfoControl.EmailAddresTextboxText;
            instructor.Municipality = _personalInfoControl.MunicipalityTextboxText;
            instructor.ContactNumber = _personalInfoControl.ContactNumberTextboxText;
            instructor.GuardianHouseNumber = _personalInfoControl.GuardianZipCodeTextboxText;
            instructor.GuardianBarangay = _personalInfoControl.GuardianBarangayTextboxText;
            instructor.GuardianLastName = _personalInfoControl.GuardianLastNameTextboxText;
            instructor.GuardianProvince = _personalInfoControl.GuardianProvinceTextboxText;
            instructor.GuardianFirstName = _personalInfoControl.GuardianFirstNameTextboxText;
            instructor.GuardianMiddleName = _personalInfoControl.GuardianMiddleNameTextboxText;
            instructor.GuardianMunicipality = _personalInfoControl.GuardianMunicipalityTextboxText;
            instructor.GuardianContactNumber = _personalInfoControl.GuardianContactNumberTextboxText;
        }

        private void ClearTextBoxes()
        {
            _personalInfoControl.DayComboBoxText    = null;
            _personalInfoControl.YearComboBoxText   = null;
            _personalInfoControl.MonthComboBoxText  = null;
            _personalInfoControl.GenderComboBoxText = null;

            _personalInfoControl.UserCodeTextboxText = string.Empty;
            _personalInfoControl.LastNameTextboxText = string.Empty;
            _personalInfoControl.ZipCodeTextboxText  = string.Empty;
            _personalInfoControl.BarangayTextboxText = string.Empty;
            _personalInfoControl.ProvinceTextboxText = string.Empty;
            _personalInfoControl.FirstNameTextboxText     = string.Empty;
            _personalInfoControl.MiddleNameTextboxText    = string.Empty;
            _personalInfoControl.EmailAddresTextboxText   = string.Empty;
            _personalInfoControl.MunicipalityTextboxText  = string.Empty;
            _personalInfoControl.ContactNumberTextboxText = string.Empty;
            _personalInfoControl.DefaultPasswordTextboxText  = string.Empty;
            _personalInfoControl.GuardianZipCodeTextboxText  = string.Empty;
            _personalInfoControl.GuardianBarangayTextboxText = string.Empty;
            _personalInfoControl.GuardianLastNameTextboxText = string.Empty;
            _personalInfoControl.GuardianProvinceTextboxText      = string.Empty;
            _personalInfoControl.GuardianFirstNameTextboxText     = string.Empty;
            _personalInfoControl.GuardianMiddleNameTextboxText    = string.Empty;
            _personalInfoControl.GuardianMunicipalityTextboxText  = string.Empty;
            _personalInfoControl.GuardianContactNumberTextboxText = string.Empty;
        }
        #endregion

        private readonly Dictionary<string, string> ButtonType = new Dictionary<string, string>
        {
            { "ADD", "FontAwesome.Sharp.IconButton, Text: ADD" },
            { "UPDATE", "FontAwesome.Sharp.IconButton, Text: UPDATE" }
        };
        private IPersonalInfoControl _personalInfoControl;
    }
}
