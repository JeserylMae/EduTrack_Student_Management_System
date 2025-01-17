using Dapper;
using DomainLayer.DataModels;
using PresentationLayer.Presenters.Enumerations;

namespace InfrastructureLayer.Database
{
    public interface IStudentAcademicInfoRepository
    {
        Task<List<PStudentAcademicInfoModel<PNameModel>>> GetAll();
        
        Task<int> DeleteStudent(PRStudentAcademicInfoParams paramsModel);
        
        Task<List<PStudentAcademicInfoModel<PNameModel>>> GetByParams(PRStudentAcademicInfoParams paramsModel);
        
        void AddDynamicParameters(ref DynamicParameters parameters,
                    PStudentAcademicInfoModel<string> studentModel,
                    RequestType request, int? dataId = null);

        void AddDynamicParameters(ref DynamicParameters parameters,
                            StudentAcadParams parameterType,
                            PRStudentAcademicInfoParams studentModel);
    }
}
