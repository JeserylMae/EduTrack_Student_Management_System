using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DataModels
{
    public class PStudentAcademicInfoModel<TModel>
    {
        public string SrCode        { get; set; }  
        public string YearLevel     { get; set; }
        public string Semester      { get; set; }
        public string Section       { get; set; }
        public string AcademicYear  { get; set; }
        public string Program       { get; set; }
        public TModel StudentName   { get; set; }
    }
}
