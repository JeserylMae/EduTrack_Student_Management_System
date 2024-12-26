using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters
{
    internal class StudentModifyAcadInfoPresenter
    {
        StudentModifyAcadInfoPresenter(IStudentModifyAcadInfoControl studentAcadInfoControl)
        {
            _studentAcadInfoControl = studentAcadInfoControl;

            _studentAcadInfoControl.ControlLoad += StudentAcadControl_Load;
        }

        public void StudentAcadControl_Load(object sender, EventArgs e)
        {

        }


        IStudentModifyAcadInfoControl _studentAcadInfoControl;
    }
}
