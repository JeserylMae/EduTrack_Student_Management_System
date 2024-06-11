/// 
/// <summary>
/// Code description here.
/// 
/// Please note to add code desription in every file where such documentation
/// is necessary.
/// </summary>
/// 

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;


namespace ServiceLayer.Test
{
    [Trait("Category", "Model Validation")]
    public class ServiceLayerValidationTest : IClassFixture<ServiceLayerTestFixture>
    {
        public ServiceLayerValidationTest(ServiceLayerTestFixture serviceLayerTestFixture, ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _serviceLayerTestFixture = serviceLayerTestFixture;

            SetValidSamplesInstructorAcademicInfoModel();
            SetValidSamplesInstructorPersonalInfoModel();
            SetValidSamplesStudentAcademicInfoModel();
            SetValidSamplesStudentPersonalInfoModel();
        }


        #region Validation Tests
        
        [Fact]
        public void ShouldNotThrowExceptionsForDefaultInstructorAcademicInfoModel()
        {
            Exception exception = Record.Exception(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.InstructorAcademicInfoModel));
            Assert.Null(exception);

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.InstructorAcademicInfoModel);
        }

        [Fact]
        public void ShouldNotThrowExceptionsForDefaultInstructorPersonalInfoModel()
        {
            Exception exception = Record.Exception(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.InstructorPersonalInfoModel));
            Assert.Null(exception);

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.InstructorPersonalInfoModel);
        }

        [Fact]
        public void ShouldNotThrowExceptionsForDefaultStudentAcademicInfoModel()
        {
            Exception exception = Record.Exception(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.StudentAcademicInfoModel));
            Assert.Null(exception);

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.StudentAcademicInfoModel);
        }

        [Fact]
        public void ShouldNotThrowExceptionsForDefaultStudentPersonalInfoModel()
        {
            Exception exception = Record.Exception(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.StudentPesonalInfoModel));
            Assert.Null(exception);

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.StudentPesonalInfoModel);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidInstructorIDInAcademicInfoModel()
        {
            _serviceLayerTestFixture.InstructorAcademicInfoModel.InstructorPropertyModel.InstructorID = "2356";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.InstructorAcademicInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.InstructorAcademicInfoModel);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidDataInAcademicInfoModel()
        {
            _serviceLayerTestFixture.InstructorAcademicInfoModel.Program = "";
            _serviceLayerTestFixture.InstructorAcademicInfoModel.Year = "";
            _serviceLayerTestFixture.InstructorAcademicInfoModel.Section = "";
            _serviceLayerTestFixture.InstructorAcademicInfoModel.Semester = "";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.InstructorAcademicInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.InstructorAcademicInfoModel);
        }

        #endregion


        #region Samples of Valid Data for Given Models
        private void SetValidSamplesInstructorAcademicInfoModel()
        {
            _serviceLayerTestFixture.InstructorAcademicInfoModel.InstructorPropertyModel.InstructorID = "20-33-24356";
            _serviceLayerTestFixture.InstructorAcademicInfoModel.Program = "Bachelor of Science in Computer Science";
            _serviceLayerTestFixture.InstructorAcademicInfoModel.Year = "2";
            _serviceLayerTestFixture.InstructorAcademicInfoModel.Section = "CS 2202";
            _serviceLayerTestFixture.InstructorAcademicInfoModel.Semester = "2";
            _serviceLayerTestFixture.InstructorAcademicInfoModel.InstructorPropertyModel.SpecializedDegree = "Bachelor of Science in Computer Science";
        }

        private void SetValidSamplesInstructorPersonalInfoModel()
        {
            _serviceLayerTestFixture.InstructorPersonalInfoModel.InstructorID = "20-23-23423";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.LastName = "Montefalco";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.FirstName = "Knoxx Gideon";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.MiddleName = "Navarro";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.BirthDate = DateTime.Parse("2004-12-31");
            _serviceLayerTestFixture.InstructorPersonalInfoModel.Gender = "Male";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.HomeAddress = "Alegria, Cagayan De Oro, Philippines";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.Email = "20-23-23423@edutrack.com";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.ContactNumber = "09289084832";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.EmergencyContactName = "Claudine Montefalco";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.EmergencyContactNumber = "09234563452";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.SpecializedDegree = "Bachelor of Science in Computer Science";
        }

        private void SetValidSamplesStudentAcademicInfoModel()
        {
            _serviceLayerTestFixture.StudentAcademicInfoModel.StudentPropertyModel.SrCode = "22-9567";
            _serviceLayerTestFixture.StudentAcademicInfoModel.Section = "CS 2202";
            _serviceLayerTestFixture.StudentAcademicInfoModel.Year = "2";
            _serviceLayerTestFixture.StudentAcademicInfoModel.Program = "Bachelor of Science in Computer Science";
            _serviceLayerTestFixture.StudentAcademicInfoModel.Semester = "2";
        }

        private void SetValidSamplesStudentPersonalInfoModel()
        {
            _serviceLayerTestFixture.StudentPesonalInfoModel.SrCode = "22-34563";
            _serviceLayerTestFixture.StudentPesonalInfoModel.LastName = "Montefalco";
            _serviceLayerTestFixture.StudentPesonalInfoModel.FirstName = "Azrael Ian";
            _serviceLayerTestFixture.StudentPesonalInfoModel.MiddleName = "Navarro";
            _serviceLayerTestFixture.StudentPesonalInfoModel.BirthDate = DateTime.Parse("2004-12-13");
            _serviceLayerTestFixture.StudentPesonalInfoModel.Gender = "Female";
            _serviceLayerTestFixture.StudentPesonalInfoModel.HomeAddress = "Alegria, Cagayan De Oro";
            _serviceLayerTestFixture.StudentPesonalInfoModel.Email = "22-34563@edutrack.com";
            _serviceLayerTestFixture.StudentPesonalInfoModel.ContactNumber = "09234563423";
            _serviceLayerTestFixture.StudentPesonalInfoModel.EmergencyContactName = "Claudine Montefalco";
            _serviceLayerTestFixture.StudentPesonalInfoModel.EmergencyContactNumber = "09345678945";
        }
        #endregion


        private void WriteExceptionTestResult<TDomainModel>(Exception exception, TDomainModel model)
        {
            if (exception != null) 
            {
                _outputHelper.WriteLine(exception.ToString());
            }
            else
            {
                StringBuilder customErrorMessage = new StringBuilder();
                JObject ModelPropertyList = JObject.FromObject(model);

                customErrorMessage.AppendLine("***** No Error Was Thrown *****");
                foreach (JProperty Property in ModelPropertyList.Properties()) 
                { 
                    customErrorMessage.Append(Property.Name);
                    customErrorMessage.Append(" ---> ");
                    customErrorMessage.AppendLine(Property.Value.ToString());
                }

                _outputHelper.WriteLine(customErrorMessage.ToString());
            }
        }


        private readonly ITestOutputHelper _outputHelper;
        private ServiceLayerTestFixture _serviceLayerTestFixture;
    }
}
