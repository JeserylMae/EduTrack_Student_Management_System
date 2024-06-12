
namespace DomainLayer.Models.CommonModel.BaseModel
{
    public interface IAcademicInfoModel
    {
        string AcademicYear { get; set; }
        string Program { get; set; }
        string Section { get; set; }
        string Semester { get; set; }
        string Year { get; set; }
    }
}