using DomainLayer.DataModels;

namespace InfrastructureLayer.Database
{
    public interface IStudentAcademicInfoRepository
    {
        Task<List<RStudentAcademicInfoModel>> GetAll();
        Task<int> Update(RStudentAcademicInfoModel studentModel);
        Task<int> InsertNew(RStudentAcademicInfoModel studentModel);
        Task<int> DeleteStudent(PStudentAcadInfoParams paramsModel);
        Task<RStudentAcademicInfoModel> GetByParams(PStudentAcadInfoParams paramsModel);
    }
}
