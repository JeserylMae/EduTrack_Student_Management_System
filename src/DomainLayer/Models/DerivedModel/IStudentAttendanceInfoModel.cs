using System;
using System.Collections.Generic;
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
}
