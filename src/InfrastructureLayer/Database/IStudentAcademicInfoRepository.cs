using DomainLayer.DataModels;

namespace InfrastructureLayer.Database
{
    public interface IStudentAcademicInfoRepository
    {
        Task<List<RStudentAcademicInfoModel>> GetAll();
    }
}
