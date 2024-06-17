

namespace DomainLayer.Models.DerivedModel
{
    public interface IEdutrackUserModel
    {
        string UserID { get; set; }
        string AccountPassword { get; set; }
        string Email {  get; set; }
    }
}
