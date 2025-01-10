using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DataModels.Instructor
{
    public class PInstructorAcademicInfoModel<TModel>
    {
        public string ItrCode           { get; set; }
        public string Course            { get; set; }
        public string Program           { get; set; }
        public string Section           { get; set; }
        public string Semester          { get; set; }
        public string YearLevel         { get; set; }
        public string AcademicYear      { get; set; }
        public TModel InstructorName    { get; set; }
    }
}
