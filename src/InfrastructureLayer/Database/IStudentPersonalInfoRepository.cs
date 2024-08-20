using DomainLayer.DataModels;

namespace InfrastructureLayer.Database
{
    public interface IStudentPersonalInfoRepository
    {
        Task<List<StudentPersonalInfoModel>> GetAll();
    }
}