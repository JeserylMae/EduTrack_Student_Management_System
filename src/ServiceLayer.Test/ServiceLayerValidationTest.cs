/// 
/// <summary>
/// 
/// The class `ServiceLayerValidationTest` contains methods for unit testing 
/// of the models in the Domain Layer and the method `ValidateModelDataAnnotation`
/// defined in the Service Layer. This class specifically contains the following
/// methods/parts:
///     1. Class Constructor.
///     2. Region Validation Tests
///     3. Region samples of Valid Data for Given Models.
///     4. Method WriteExceptionTestResult.
/// 
/// Also, in order to perform unit testing, some visual studio packages are 
/// required to be installed in the project/solution file `ServiceLayer.Test`.
/// This project specifically used the following packages:
///     1. xunit
///     2. xunit.runner.visualstudio
///     3. Newtonsoft.Json
///     
/// 1. Class Constructor
///     This method has parameters ServiceLayerTestFixture and ITestOutputHelper
/// which will be automatically assigned a value once the test begin. This
/// constructor defines the models in the `ServiceLayerTestFixture` class
/// by calling the methods in charge for setting the value of the properties 
/// inside. 
/// 
/// 2. Region Validation Tests
///     This part contains the methods which has the test cases about the properties
/// of each classes in the Domain Layer. This part is essential in ensuring that
/// the Data Annotations and Validations for each properties are working as it was
/// expected to.
/// 
/// 3. Region Samples of Valid Data for Given Models.
///     The methods in this region was called in the class constructor once the test
/// begin. This is also used to avoid re-definition of the properties of the models
/// in each Validation Test Methods.
/// 
/// 4. Method WriteExceptionTestResult
///     This method's main function is to display the exceptions (if there are any)
/// and the test results (whether passed or failed) on each test cases in the Test
/// Explorer.
/// 
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
                                                    (_serviceLayerTestFixture.StudentPersonalInfoModel));
            Assert.Null(exception);

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.StudentPersonalInfoModel);
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

        [Fact]
        public void ShouldThrowExceptionForInvalidSpecializedDegreeInAcademicInfoModel()
        {
            _serviceLayerTestFixture.InstructorAcademicInfoModel.InstructorPropertyModel.SpecializedDegree = "BSCS";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.InstructorAcademicInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.InstructorAcademicInfoModel);
        }

        [Fact]
        public void ShouldThrowAnExcpetionForInvalidNameInInstructorPersonalInfoModel()
        {
            _serviceLayerTestFixture.InstructorPersonalInfoModel.LastName = "M0ntefalco_";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.FirstName = "t";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.MiddleName = "8";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.InstructorPersonalInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.InstructorPersonalInfoModel);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidBDateInInstructorPersonalInfoModel()
        {
            _serviceLayerTestFixture.InstructorPersonalInfoModel.BirthDate = null;

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.InstructorPersonalInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.InstructorPersonalInfoModel);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidGenderInInstructorPersonalInfoModel()
        {
            _serviceLayerTestFixture.InstructorPersonalInfoModel.Gender = "F";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.InstructorPersonalInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.InstructorPersonalInfoModel);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidHomeAddressInInstructoPersonalInfoModel()
        {
            _serviceLayerTestFixture.InstructorPersonalInfoModel.HomeAddress = "+09 Street Luzon";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.InstructorPersonalInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.InstructorPersonalInfoModel);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidContactInfoInInstructorPersonalInfoModel()
        {
            _serviceLayerTestFixture.InstructorPersonalInfoModel.ContactNumber = "45 565 24";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.Email = "sefjkehre@email";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.InstructorPersonalInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.InstructorPersonalInfoModel);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidEmergencyContantInfoInInstructorPersonalInfoModel()
        {
            _serviceLayerTestFixture.InstructorPersonalInfoModel.EmergencyContactName = "Mother";
            _serviceLayerTestFixture.InstructorPersonalInfoModel.EmergencyContactNumber = "12345";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.InstructorPersonalInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.InstructorPersonalInfoModel);
        }

        [Fact]
        public void ShouldTrhowExceptionForInvalidSrCodeInStudentAcademicInfoModel()
        {
            _serviceLayerTestFixture.StudentAcademicInfoModel.StudentPropertyModel.SrCode = "2345-67";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.StudentAcademicInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.StudentAcademicInfoModel);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidStudentRecordInStudentAcademicInfoModel()
        {
            _serviceLayerTestFixture.StudentAcademicInfoModel.Year = "";
            _serviceLayerTestFixture.StudentAcademicInfoModel.Semester = "";
            _serviceLayerTestFixture.StudentAcademicInfoModel.Section = "";
            _serviceLayerTestFixture.StudentAcademicInfoModel.Program = "";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.StudentAcademicInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.StudentAcademicInfoModel);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidNameInStudentPersonalInfoModel()
        {
            _serviceLayerTestFixture.StudentPersonalInfoModel.LastName = "kl";
            _serviceLayerTestFixture.StudentPersonalInfoModel.FirstName = "The8";
            _serviceLayerTestFixture.StudentPersonalInfoModel.MiddleName = "";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.StudentPersonalInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidBDateInStudentPersonalInfoModel()
        {
            _serviceLayerTestFixture.StudentPersonalInfoModel.BirthDate = null;

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.StudentPersonalInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.StudentPersonalInfoModel);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidGenderInStudentPersonalInfoModel()
        {
            _serviceLayerTestFixture.StudentPersonalInfoModel.Gender = "M4le";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.StudentPersonalInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.StudentPersonalInfoModel);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidHomeAddressInStudentPersonalInfoModel()
        {
            _serviceLayerTestFixture.StudentPersonalInfoModel.HomeAddress = "San Pascual, Batangas +{}mff, Philippines";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.StudentPersonalInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.StudentPersonalInfoModel);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidContactInfoInStudentInfoModel()
        {
            _serviceLayerTestFixture.StudentPersonalInfoModel.Email = "dhafl;;.com";
            _serviceLayerTestFixture.StudentPersonalInfoModel.ContactNumber = "";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.StudentPersonalInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.StudentPersonalInfoModel);
        }

        [Fact]
        public void ShouldExceptionForInvalidEmergencyInfoInStudentPersonalInfoModel()
        {
            _serviceLayerTestFixture.StudentPersonalInfoModel.EmergencyContactName = "Cl4udine N. Montefalco";
            _serviceLayerTestFixture.StudentPersonalInfoModel.EmergencyContactNumber = "-=327493228347432";

            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _serviceLayerTestFixture.ModelDataAnnotationCheck.ValidateModelDataAnnotation
                                                    (_serviceLayerTestFixture.StudentPersonalInfoModel));

            WriteExceptionTestResult(exception, _serviceLayerTestFixture.StudentPersonalInfoModel);
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
            _serviceLayerTestFixture.InstructorAcademicInfoModel.AcademicYear = "2023-2024";
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
            _serviceLayerTestFixture.StudentAcademicInfoModel.StudentPropertyModel.SrCode = "22-95367";
            _serviceLayerTestFixture.StudentAcademicInfoModel.Section = "CS 2202";
            _serviceLayerTestFixture.StudentAcademicInfoModel.Year = "2";
            _serviceLayerTestFixture.StudentAcademicInfoModel.Program = "Bachelor of Science in Computer Science";
            _serviceLayerTestFixture.StudentAcademicInfoModel.Semester = "2";
            _serviceLayerTestFixture.StudentAcademicInfoModel.AcademicYear = "2023-2024";
        }

        private void SetValidSamplesStudentPersonalInfoModel()
        {
            _serviceLayerTestFixture.StudentPersonalInfoModel.StudentPropertyModel.SrCode = "22-34563";
            _serviceLayerTestFixture.StudentPersonalInfoModel.LastName = "Montefalco";
            _serviceLayerTestFixture.StudentPersonalInfoModel.FirstName = "Azrael Ian";
            _serviceLayerTestFixture.StudentPersonalInfoModel.MiddleName = "Navarro";
            _serviceLayerTestFixture.StudentPersonalInfoModel.BirthDate = DateTime.Parse("2004-12-13");
            _serviceLayerTestFixture.StudentPersonalInfoModel.Gender = "Female";
            _serviceLayerTestFixture.StudentPersonalInfoModel.HomeAddress = "Alegria, Cagayan De Oro";
            _serviceLayerTestFixture.StudentPersonalInfoModel.Email = "22-34563@edutrack.com";
            _serviceLayerTestFixture.StudentPersonalInfoModel.ContactNumber = "09234563423";
            _serviceLayerTestFixture.StudentPersonalInfoModel.EmergencyContactName = "Claudine N. Montefalco";
            _serviceLayerTestFixture.StudentPersonalInfoModel.EmergencyContactNumber = "09345678945";
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
