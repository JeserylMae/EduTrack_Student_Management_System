using DomainLayer.DataModels;
using DomainLayer.DataModels.Instructor;
using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.UserControls.HomeSubControls;
using ServiceLayer.Database;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace PresentationLayer.Presenters.StudItr
{
    internal class StudItrHomeRightPresenter
    {
        public StudItrHomeRightPresenter(IStudItrHomeRightControl rightControl)
        {
            _rightControl = rightControl;

            _rightControl.OnControlLoad += OnHomeRightControl_Load;
        }


        private async void OnHomeRightControl_Load(object sender, EventArgs e)
        {
            try
            {
                if (_rightControl.CurrentUserType == AccessType.STUDENT)
                    await HandleStudentInformation();
                else if (_rightControl.CurrentUserType == AccessType.INSTRUCTOR)
                    HandleInstructorInformation();
                else
                    throw new Exception("Cannot view information about the current user type.");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,
                    $"{_rightControl.CurrentUserType.ToString()} HOME",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private async void HandleInstructorInformation()
        {
            RemovePanel();

            var academicInfo = await GetInstructorAcademicInformation();
            var personalInfo = await GetInstructorPersonalInformation();

            DisplayValuesToPanel(ref personalInfo, ref academicInfo);
        }

        private async Task HandleStudentInformation()
        {
            RemovePanel();

            var academicInfo = await GetStudentAcademicInformation();
            var personalInfo = await GetStudentPersonalInformation();

            DisplayValuesToPanel( ref personalInfo, ref academicInfo);
        }


        #region Helpers
        private async Task<RInstructorPersonalInfoModel> GetInstructorPersonalInformation()
        {
            InstructorPersonalInfoServices services = new InstructorPersonalInfoServices();

            return await services.GetById(_rightControl.CurrentUserId);
        }

        private async Task<PInstructorAcademicInfoModel<PNameModel>> GetInstructorAcademicInformation()
        {
            InstructorAcademicInfoServices services = new InstructorAcademicInfoServices();
            PRInstructorAcademicParams parameters = new PRInstructorAcademicParams();
            List<PInstructorAcademicInfoModel<PNameModel>> instructor = new List<PInstructorAcademicInfoModel<PNameModel>>();

            parameters.ItrCode = _rightControl.CurrentUserId;

            instructor = await services.GetById(parameters);

            instructor = instructor.Select(row => row)
                .OrderByDescending(row => row.AcademicYear)
                .ThenByDescending(row => row.Section)
                .ToList();

            return instructor[0];
        }

        private async Task<RStudentPersonalInfoModel> GetStudentPersonalInformation()
        {
            StudentPersonalInfoServices services = new StudentPersonalInfoServices();

            return await services.GetById(_rightControl.CurrentUserId);
        }

        private async Task<PStudentAcademicInfoModel<PNameModel>> GetStudentAcademicInformation()
        {
            StudentAcademicInfoServices services                = new StudentAcademicInfoServices();
            PRStudentAcademicInfoParams parameters              = new PRStudentAcademicInfoParams();
            List<PStudentAcademicInfoModel<PNameModel>> student = new List<PStudentAcademicInfoModel<PNameModel>>();

            parameters.SrCode = _rightControl.CurrentUserId;

            student = await services.GetByParams(parameters);

            student = student.Select(row => row)
                .OrderByDescending(row => row.AcademicYear)
                .ThenByDescending(row => row.Section)
                .ToList();

            return student[0];
        }

        private void DisplayValuesToPanel(ref RStudentPersonalInfoModel personalInfo, 
                              ref PStudentAcademicInfoModel<PNameModel> academicInfo)
        {
            _rightControl.AccessFullNameLabel.Text = personalInfo.FirstName + " " 
                                                   + personalInfo.MiddleName + " "       
                                                   + personalInfo.LastName;

            _rightControl.AccessSrCodeText.Text             = academicInfo.SrCode;
            _rightControl.AccessYearText.Text               = academicInfo.YearLevel;
            _rightControl.AccessSemesterText.Text           = academicInfo.Semester;
            _rightControl.AccessSectionText.Text            = academicInfo.Section;
            _rightControl.AccessProgramText.Text            = academicInfo.Program;
            _rightControl.AccessStudEmailText.Text          = personalInfo.EmailAddress;
            _rightControl.AccessStudContactNumberText.Text  = personalInfo.ContactNumber;
        }

        private void RemovePanel()
        {
            if (_rightControl.CurrentUserType == AccessType.STUDENT)
            {
                _rightControl.AccessMainInfoPanel.Controls.Remove(_rightControl.AccessInstructorInfoMainPanel);
                _rightControl.AccessInstructorInfoMainPanel.Dispose();
            }
            else if (_rightControl.CurrentUserType == AccessType.INSTRUCTOR)
            {
                _rightControl.AccessMainInfoPanel.Controls.Remove(_rightControl.AccessStudentInfoMainPanel);
                _rightControl.AccessStudentInfoMainPanel.Dispose();
            }
        }
        #endregion


        IStudItrHomeRightControl _rightControl;
    }
}
