using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DataModels
{
    public class RStudentAcademicInfoModel
    {
        public string SrCode          { get; set; }
        public string LastName        { get; set; }
        public string FirstName       { get; set; } 
        public string MiddleName      { get; set; }
        public string YearLevel       { get; set; }
        public string Semester        { get; set; }    
        public string Section         { get; set; }
        public string AcademicYear    { get; set; }    
        public string Program         { get; set; } 
    }
}
