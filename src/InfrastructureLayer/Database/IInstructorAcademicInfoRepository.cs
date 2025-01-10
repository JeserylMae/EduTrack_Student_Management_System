using DomainLayer.DataModels;
using DomainLayer.DataModels.Instructor;

namespace InfrastructureLayer.Database
{
    public interface IInstructorAcademicInfoRepository
    {
        Task<List<PInstructorAcademicInfoModel<PNameModel>>> GetAll();
    }
}