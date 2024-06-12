
using System;

namespace DomainLayer.Models.CommonModel.BaseModel
{
    public interface IPersonalInfoModel
    {
        DateTime? BirthDate { get; set; }
        string ContactNumber { get; set; }
        string Email { get; set; }
        string EmergencyContactName { get; set; }
        string EmergencyContactNumber { get; set; }
        string FirstName { get; set; }
        string Gender { get; set; }
        string HomeAddress { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
    }
}