using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.DerivedModel
{
    class StudentAttendanceInfoModel : StudentSharedInfoModel, IStudentAttendanceInfoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Attendance date is required!")]
        [DataType(DataType.Date, ErrorMessage = "Enter a valid date!")]
        public DateTime AttendanceDate { get; set; }

        [StringLength(15)]
        public string status { get; set; }
    }
}

/// *** ATTENDANCE ***
/// SrCode
/// Section
/// CourseCode
/// Date - U
/// Academic Year
/// Semester
/// Status - U


/// *** GRADE ***
/// SrCode - ACAD
/// Section - ACAD
/// CourseCode - COURSE
/// Academic Year - ACAD
/// Semester - ACAD
/// Grade - U