
using DomainLayer.Inner.CommonModel.BaseModel;
using DomainLayer.Inner.CommonModel.DistinctModel;


namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public interface IInstructorAcademicInfoModel : IAcademicInfoModel
    {
        InstructorPropertyModel InstructorPropertyModel { get; set; }
        SharedCourseInfoModel SharedCourseInfoModel { get; set; }
    }
}
