using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DataModels
{
    public class PStudentAcadInfoParams
    {
        public string SrCode {  get; set; }
        public string AcademicYear { get; set; }
        public string YearLevel { get; set; }
        public string Semester {  get; set; }
    }
}
