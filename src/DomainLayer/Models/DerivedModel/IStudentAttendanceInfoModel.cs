using System;

namespace DomainLayer.Models.DerivedModel
{
    public interface IStudentAttendanceInfoModel
    {
        DateTime? AttendanceDate { get; set; }
        string Status { get; set; }
    }
}
