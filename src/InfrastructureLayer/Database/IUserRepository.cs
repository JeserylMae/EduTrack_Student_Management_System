
using DomainLayer.DataModels;

namespace InfrastructureLayer.Database
{
    public interface IUserRepository
    {
        //Task<List<UserModel>> GetAll();
        Task<PRUserModel?> GetById(string UserId);
        //Task<int> InsertNew(UserModel user);
        //Task<int> UpdateAccountPassword(UserModel user);
    }
}
