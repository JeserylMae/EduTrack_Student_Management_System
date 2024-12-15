using DomainLayer.DataModels;

namespace InfrastructureLayer.Database
{
    public interface IStudentPersonalInfoRepository
    {
        Task<List<StudentPersonalInfoModel>> GetAll();
        Task<StudentPersonalInfoModel> GetById(string SrCode);
        Task<int> Update(PersonalInfoModel<StudentPersonalInfoModel> student);
        Task<int> InsertNew(PersonalInfoModel<StudentPersonalInfoModel> student);
    }
}