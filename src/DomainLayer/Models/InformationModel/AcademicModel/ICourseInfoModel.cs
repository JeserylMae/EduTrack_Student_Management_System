
using DomainLayer.Inner.CommonModel.BaseModel;


namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public interface ICourseInfoModel : ISharedCourseInfoModel
    {
        string CourseName { get; set; }
        int NumberOfUnits { get; set; }
    }
}
