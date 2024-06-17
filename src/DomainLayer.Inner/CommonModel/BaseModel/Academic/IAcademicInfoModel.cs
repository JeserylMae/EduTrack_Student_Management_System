

namespace DomainLayer.Inner.CommonModel.BaseModel
{
    public interface IAcademicInfoModel : ISharedAcademicInfoModel
    {
        string Program { get; set; }
        string Year { get; set; }
    }
}