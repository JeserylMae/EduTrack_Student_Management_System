using DomainLayer.DataModels;
using ServiceLayer.Database;
using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Presenters.Admin
{
    internal class StudentModifyAcadInfoPresenter
    {
        public StudentModifyAcadInfoPresenter(IStudentModifyAcadInfoControl studentAcadInfoControl)
        {
            _studentAcadInfoControl = studentAcadInfoControl;

            _studentAcadInfoControl.ControlLoad += StudentAcadControl_Load;
        }

        public void StudentAcadControl_Load(object sender, EventArgs e)
        {
            try
            {
                StudentAcademicInfoServices services = new StudentAcademicInfoServices();
                List<RStudentAcademicInfoModel> studentList = services.GetAll();

                _studentAcadInfoControl.ClearInfoTable();

                foreach (var student in studentList)
                {
                    object[] studentInfo = new object[9];

                    AddStudentAcademicInfoToObject(ref studentInfo, student);
                    _studentAcadInfoControl.InfoTableRowData = studentInfo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Student Academic Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region Helpers
        private void AddStudentAcademicInfoToObject(ref object[] studentObj, 
                                    RStudentAcademicInfoModel studentInfo)
        {
            studentObj[0] = studentInfo.SrCode;
            studentObj[1] = studentInfo.LastName;
            studentObj[2] = studentInfo.FirstName;
            studentObj[3] = studentInfo.MiddleName;
            studentObj[4] = studentInfo.Program;
            studentObj[5] = studentInfo.YearLevel;
            studentObj[6] = studentInfo.Semester;
            studentObj[7] = studentInfo.Section;
            studentObj[8] = studentInfo.AcademicYear;
        }
        #endregion


        IStudentModifyAcadInfoControl _studentAcadInfoControl;
    }
}
