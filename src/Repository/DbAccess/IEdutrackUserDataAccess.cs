using DomainLayer.Models.DerivedModel;

namespace WebService.DbAccess
{
    public interface IEdutrackUserDataAccess
    {
        Task DeleteUser(string UserId);
        Task<IEdutrackUserModel?> GetUser(string UserId);
        Task<IEnumerable<IEdutrackUserModel>> GetUsers();
        Task InsertUser(IEdutrackUserModel edutrackUserModel);
        Task UpdateUser(IEdutrackUserModel edutrackUserModel);
    }
}