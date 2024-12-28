using Dapper;
using DomainLayer.DataModels;
using InfrastructureLayer.Data;
using InfrastructureLayer.Query;
using System.Data;

namespace InfrastructureLayer.Database
{
    public class MStudentAcademicInfoRepository : IStudentAcademicInfoRepository
    {
        public MStudentAcademicInfoRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _studentQuery = new StudentAcadInfoQuery();
        }


        public async Task<List<RStudentAcademicInfoModel>> GetAll()
        {
            string procedure = _studentQuery.spGetAll;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                var result = await connection.QueryAsync<RStudentAcademicInfoModel>(
                                procedure,
                                commandType: CommandType.Text
                );
                return result.ToList();
            }
        }

        public Task<int> DeleteStudent(PStudentAcadInfoParams paramsModel)
        {
            throw new NotImplementedException();
        }

        public async Task<RStudentAcademicInfoModel> GetByParams(PStudentAcadInfoParams paramsModel)
        {
            StudentAcadParams parameterType = HandleParameter(paramsModel);
            string procedure = _studentQuery.spGetById(parameterType);


            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                AddDynamicParameters(ref parameters, parameterType, paramsModel);

                var result = await connection.QuerySingleOrDefaultAsync<RStudentAcademicInfoModel>(
                                procedure, parameters,
                                commandType: CommandType.Text
                );
                return result;
            }
        }

        public Task<int> Update(RStudentAcademicInfoModel studentModel)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertNew(RStudentAcademicInfoModel studentModel)
        {
            throw new NotImplementedException();
        }


        private StudentAcadParams HandleParameter(PStudentAcadInfoParams model)
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

        private void AddDynamicParameters(ref DynamicParameters parameters, StudentAcadParams parameterType,
                                          PStudentAcadInfoParams studentModel)
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

        private DatabaseContext _databaseContext;
        private StudentAcadInfoQuery _studentQuery;
    }
}
