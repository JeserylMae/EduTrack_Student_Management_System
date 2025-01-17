using DomainLayer.DataModels;
using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.UserControls.HomeSubControls;
using ServiceLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        private void OnHomeRightControl_Load(object sender, EventArgs e)
        {
            try
            {
                if (_rightControl.CurrentUserType == AccessType.STUDENT)
                    HandleStudentInformation();
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

        private void HandleInstructorInformation()
        {
            throw new NotImplementedException();
        }

        private async void HandleStudentInformation()
        {
            _rightControl.AccessInstructorInfoMainPanel.Dispose();

            StudentAcademicInfoServices services = new StudentAcademicInfoServices();
            List<PStudentAcademicInfoModel<PNameModel>> student = new List<PStudentAcademicInfoModel<PNameModel>>();

            student = await services.GetAll();


        }

        IStudItrHomeRightControl _rightControl;
    }
}
