using DomainLayer.DataModels;

namespace InfrastructureLayer.Database
{
    public interface IStudentAcademicInfoRepository
    {
        Task<List<PStudentAcademicInfoModel<PNameModel>>> GetAll();
        Task<int> GetRecordId(PRStudentAcademicInfoParams paramsModel);
        Task<int> DeleteStudent(PRStudentAcademicInfoParams paramsModel);
        Task<int> InsertNew(PStudentAcademicInfoModel<string> studentModel);
        Task<int> Update(PStudentAcademicInfoModel<string> studentModel, int dataId);
        Task<PStudentAcademicInfoModel<PNameModel>> GetByParams(PRStudentAcademicInfoParams paramsModel);
    }
}
