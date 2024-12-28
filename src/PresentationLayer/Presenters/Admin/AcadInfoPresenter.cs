using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters.Admin
{
    internal class AcadInfoPresenter
    {
        public AcadInfoPresenter(IStudentAcadInfoControl studentAcadInfoControl)
        {
            _studentAcadInfoControl = studentAcadInfoControl;
        }

        private IStudentAcadInfoControl _studentAcadInfoControl;
    }
}
