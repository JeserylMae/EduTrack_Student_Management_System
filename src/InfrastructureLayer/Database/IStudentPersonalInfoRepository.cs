using DomainLayer.DataModels;

namespace InfrastructureLayer.Database
{
    public interface IStudentPersonalInfoRepository
    {
        Task<List<RStudentPersonalInfoModel>> GetAll();
        Task<RStudentPersonalInfoModel> GetById(string SrCode);
        Task<int> DeleteById(PStudentPersonalInfoCodeModel codes);
        Task<int> Update(PStudentPersonalInfoModel<RStudentPersonalInfoModel> student);
        Task<int> InsertNew(PStudentPersonalInfoModel<RStudentPersonalInfoModel> student);
    }
}