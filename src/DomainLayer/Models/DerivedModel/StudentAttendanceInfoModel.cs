using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.DerivedModel
{
    public class StudentAttendanceInfoModel : StudentSharedInfoModel, IStudentAttendanceInfoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Attendance date is required!")]
        [DataType(DataType.Date, ErrorMessage = "Enter a valid date!")]
        public DateTime? AttendanceDate { get; set; }

        [RegularExpression(@"^[a-zA-Z]{4,15}$", ErrorMessage = "Status must be 4 to 15 characters only!")]
        public string Status { get; set; }

        #region Properties Inherited From StudentSharedInfoModel
        // SrCode
        // Section 
        // CourseCode
        // AcademicYear
        // Semester
        #endregion
    }
}
