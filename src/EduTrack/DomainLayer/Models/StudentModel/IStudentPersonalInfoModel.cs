
using DomainLayer.Models.CommonModel;

namespace DomainLayer.StudentModel
{
    public interface IStudentPersonalInfoModel : IPersonalInfoModel
    {
        string SrCode { get; set; }
    }
}