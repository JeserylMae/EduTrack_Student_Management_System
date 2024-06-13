using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DomainLayer.Models.DerivedModel
{ 
    public class StudentGradeInfoModel : StudentSharedInfoModel, IStudentGradeInfoModel
    { 
        [Required]
        [Range(1.00, 5.00, ErrorMessage = "Grade must be from 1.00 to 5.00 only!")]
        public decimal Grade { get; set; }

        #region Properties Inherited From StudentSharedInfoModel
        // SrCode
        // Section 
        // CourseCode
        // AcademicYear
        // Semester
        #endregion
    }
}
