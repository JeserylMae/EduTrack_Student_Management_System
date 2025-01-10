using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DataModels.Instructor
{
    public class PRInstructorAcademicParams
    {
        public string ItrCode       { get; set; } 
        public string Course        { get; set; }
        public string Section       { get; set; }
        public string Semester      { get; set; }    
        public string YearLevel     { get; set; }
        public string AcademicYear  { get; set; }
    }
}
