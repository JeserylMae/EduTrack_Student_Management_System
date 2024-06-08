
using DomainLayer.Models.CommonModel;

namespace DomainLayer.Models.InstructorModel
{
    public interface IInstructorPersonalInfoModel : IPersonalInfoModel
    {
        string SrCode { get; set; }
    }
}