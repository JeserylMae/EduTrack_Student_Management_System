
using DomainLayer.Inner.CommonModel.BaseModel;
using DomainLayer.Inner.CommonModel.DistinctModel;


namespace DomainLayer.Models.InformationModel.PersonalModel
{
    public interface IInstructorPersonalInfoModel : IPersonalInfoModel
    {
        string SpecializedDegree { get; set; }
        InstructorPropertyModel InstructorPropertyModel { get; set; }
    }
}
