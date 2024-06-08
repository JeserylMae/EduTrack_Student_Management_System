namespace DomainLayer.Models.CommonModel
{
    public interface IAcademicInfoModel
    {
        string Program { get; set; }
        string Section { get; set; }
        string Semester { get; set; }
        string Year { get; set; }
    }
}