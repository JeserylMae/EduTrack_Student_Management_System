using Dapper;
using DomainLayer.DataModels;
using InfrastructureLayer.Data;
using InfrastructureLayer.Query;
using PresentationLayer.Presenters.Enumerations;
using System.Data;

namespace InfrastructureLayer.Database
{
    public class StudentAcademicInfoRepository : IStudentAcademicInfoRepository
    {
        public StudentAcademicInfoRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _studentQuery = new StudentAcadInfoQuery();
        }


        public async Task<List<PStudentAcademicInfoModel<PNameModel>>> GetAll()
        {
            string procedure = _studentQuery.spGetAll;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                var result = await connection.QueryAsync<PStudentAcademicInfoModel<PNameModel>,
                                             PNameModel, PStudentAcademicInfoModel<PNameModel>>(
                    procedure,
                    (academicInfo, name) =>
                    {
                        academicInfo.StudentName = name;
                        return academicInfo;
                    },  splitOn: "LastName",
                    commandType: CommandType.Text
                );
                return result.ToList();
            }
        }

        public async Task<int> DeleteStudent(PRStudentAcademicInfoParams paramsModel)
        {
            StudentAcadParams studentAcadParams = HandleParameter(paramsModel);
            string procedure = _studentQuery.spDelete(studentAcadParams);

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                AddDynamicParameters(ref parameters, studentAcadParams, paramsModel);

                return await connection.ExecuteAsync(procedure, parameters, commandType: CommandType.Text);
            }
        }

        public async Task<PStudentAcademicInfoModel<PNameModel>> GetByParams(
                                     PRStudentAcademicInfoParams paramsModel)
        {
            StudentAcadParams parameterType = HandleParameter(paramsModel);
            string procedure = _studentQuery.spGetById(parameterType);


            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                AddDynamicParameters(ref parameters, parameterType, paramsModel);

                var result = await connection.QueryAsync<PStudentAcademicInfoModel<PNameModel>,
                                            PNameModel, PStudentAcademicInfoModel<PNameModel>>(
                    procedure,
                    (academicInfo, name) =>
                    {
                        academicInfo.StudentName = name;
                        return academicInfo;
                    }, splitOn: "LastName",
                    param: parameters,
                    commandType: CommandType.Text
                );
                return result.SingleOrDefault();
            }
        }


        #region Helpers

        public void AddDynamicParameters(ref DynamicParameters parameters, 
                                    PStudentAcademicInfoModel<string> studentModel,
                                    RequestType request, int? dataId = null)
        {
            parameters.Add("@p_SrCode",         studentModel.SrCode         );
            parameters.Add("@p_YearLevel",      studentModel.YearLevel      );
            parameters.Add("@p_Semester",       studentModel.Semester       );
            parameters.Add("@p_Section",        studentModel.Section        );
            parameters.Add("@p_AcademicYear",   studentModel.AcademicYear   );
            parameters.Add("@p_Program",        studentModel.Program        );
            
            if (RequestType.INSERT == request)
                parameters.Add("@p_StudentNameId",  studentModel.StudentName);
            else if (RequestType.UPDATE == request && null != dataId)
                parameters.Add("@p_Id", dataId);
        }


        public void AddDynamicParameters(ref DynamicParameters parameters, 
                                          StudentAcadParams parameterType,
                                          PRStudentAcademicInfoParams studentModel)
        {
            switch (parameterType)
            {
                case StudentAcadParams.SrCode:
                    parameters.Add("@p_SrCode", studentModel.SrCode);
                    break;
                case StudentAcadParams.SrCodeAndAcadYear:
                    parameters.Add("@p_SrCode", studentModel.SrCode);
                    parameters.Add("@p_AcademicYear", studentModel.AcademicYear);
                    break;
                case StudentAcadParams.SrCodeAndAcadYearAndYearLevel:
                    parameters.Add("@p_SrCode", studentModel.SrCode);
                    parameters.Add("@p_AcademicYear", studentModel.AcademicYear);
                    parameters.Add("@p_YearLevel", studentModel.YearLevel);
                    break;
                case StudentAcadParams.SrCodeAndAcadYearAndYearLevelAndSemester:
                    parameters.Add("@p_SrCode", studentModel.SrCode);
                    parameters.Add("@p_AcademicYear", studentModel.AcademicYear);
                    parameters.Add("@p_YearLevel", studentModel.YearLevel);
                    parameters.Add("@p_Semester", studentModel.Semester);
                    break;
            }
        }


        private StudentAcadParams HandleParameter(PRStudentAcademicInfoParams model)
        {
            if (!String.IsNullOrEmpty(model.Semester))
            {
                return StudentAcadParams.SrCodeAndAcadYearAndYearLevelAndSemester;
            }
            else if (!String.IsNullOrEmpty(model.Semester))
            {
                return StudentAcadParams.SrCodeAndAcadYearAndYearLevel;
            }
            else if (!String.IsNullOrEmpty(model.AcademicYear))
            {
                return StudentAcadParams.SrCodeAndAcadYear;
            }
            else if (!String.IsNullOrEmpty(model.SrCode))
            {
                return StudentAcadParams.SrCode;
            }
            return StudentAcadParams.None;
        }
        
        #endregion


        private DatabaseContext _databaseContext;
        private StudentAcadInfoQuery _studentQuery;
    }
}
