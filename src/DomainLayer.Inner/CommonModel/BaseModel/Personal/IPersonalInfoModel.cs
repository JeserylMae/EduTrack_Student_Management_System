
using System;

namespace DomainLayer.Inner.CommonModel.BaseModel
{
    public interface IPersonalInfoModel : ISharedPersonalInfoModel
    {
        DateTime? BirthDate { get; set; }
        string ContactNumber { get; set; }
        string Email { get; set; }
        string EmergencyContactName { get; set; }
        string EmergencyContactNumber { get; set; }
        string Gender { get; set; }
        string HomeAddress { get; set; }
    }
}