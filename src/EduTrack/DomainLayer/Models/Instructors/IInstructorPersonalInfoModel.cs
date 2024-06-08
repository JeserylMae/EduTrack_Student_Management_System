using DomainLayer.Models.CommonModels;

namespace DomainLayer.Models.Instructors
{
    internal interface IInstructorPersonalInfoModel : IPersonalInfoModel
    {
        string SrCode { get; set; }
    }
}