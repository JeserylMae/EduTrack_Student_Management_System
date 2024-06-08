
using DomainLayer.Models.CommonModel;

namespace DomainLayer.Models.InstructorModel
{
    internal interface IInstructorPersonalInfoModel : IPersonalInfoModel
    {
        string SrCode { get; set; }
    }
}