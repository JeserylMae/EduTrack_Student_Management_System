namespace DomainLayer.Models.CommonModel.BaseModel
{
    public interface ISharedAcademicInfoModel
    {
        string AcademicYear { get; set; }
        string Section { get; set; }
        string Semester { get; set; }
    }
}