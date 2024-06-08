using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.DerivedModel
{
    public interface IStudentAttendanceInfoModel : IStudentSharedInfoModel 
    { 
        DateTime AttendanceDate { get; set; }
        string status { get; set; }
    }

    class StudentAttendanceInfoModel : StudentSharedInfoModel, IStudentAttendanceInfoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Attendance date is required!")]
        [DataType(DataType.Date, ErrorMessage = "Enter a valid date!")]
        public DateTime AttendanceDate { get; set; }

        [StringLength(15)]
        public string status { get; set; }
    }
}
