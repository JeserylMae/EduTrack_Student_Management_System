using DomainLayer.DataModels;

namespace InfrastructureLayer.Database
{
    public interface IStudentPersonalInfoRepository
    {
        Task<List<StudentPersonalInfoModel>> GetAll();
        Task<int> InsertNew(StudentPersonalInfoModel studentPersonalInfo,
                            string DefaultPassword, string Position,
                            string StudentCode, string GuardianCode);
    }
}