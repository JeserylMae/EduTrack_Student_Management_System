
using DomainLayer.Inner.CommonModel.BaseModel;
using DomainLayer.Inner.CommonModel.DistinctModel;


namespace DomainLayer.Models.InformationModel.PersonalModel
{
    public interface IStudentPersonalInfoModel : IPersonalInfoModel
    {
        StudentPropertyModel StudentPropertyModel { get; set; }
    }
}
