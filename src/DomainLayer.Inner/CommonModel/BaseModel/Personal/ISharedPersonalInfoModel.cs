
namespace DomainLayer.Inner.CommonModel.BaseModel
{
    public interface ISharedPersonalInfoModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
    }
}