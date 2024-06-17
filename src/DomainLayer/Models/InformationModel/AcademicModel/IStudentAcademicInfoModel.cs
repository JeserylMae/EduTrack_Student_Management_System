
using DomainLayer.Inner.CommonModel.BaseModel;
using DomainLayer.Inner.CommonModel.DistinctModel;


namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public interface IStudentAcademicInfoModel : IAcademicInfoModel
    {
        StudentPropertyModel StudentPropertyModel { get; set; }
    }
}
