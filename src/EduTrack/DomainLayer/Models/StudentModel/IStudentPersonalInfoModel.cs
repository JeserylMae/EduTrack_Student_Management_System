
using DomainLayer.Models.CommonModel;

namespace DomainLayer.StudentModel
{
    interface IStudentPersonalInfoModel : IPersonalInfoModel
    {
        string SrCode { get; set; }
    }
}