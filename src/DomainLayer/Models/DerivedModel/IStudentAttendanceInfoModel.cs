using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.DerivedModel
{
    public interface IStudentAttendanceInfoModel
    {
        DateTime? AttendanceDate { get; set; }
        string Status { get; set; }
    }
}
