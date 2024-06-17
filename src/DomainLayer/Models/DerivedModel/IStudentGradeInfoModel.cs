
using DomainLayer.Inner.CommonModel.BaseModel;


namespace DomainLayer.Models.DerivedModel
{
    public interface IStudentGradeInfoModel : IStudentSharedInfoModel
    {
        decimal Grade { get; set; }
    }
}
