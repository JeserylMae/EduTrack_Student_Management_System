

using Dapper;
using DomainLayer.DataModels;
using InfrastructureLayer.Data;
using InfrastructureLayer.Query;
using System.Data;

namespace InfrastructureLayer.Database
{
    public class MStudentPersonalInfoRepository : IStudentPersonalInfoRepository
    {
        public MStudentPersonalInfoRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _studentQuery = new StudentPersonalInfoQuery();
        }

        public async Task<List<RStudentPersonalInfoModel>> GetAll()
        {
            string procedure = _studentQuery.spGetAll;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                var result = await connection.QueryAsync<RStudentPersonalInfoModel>(procedure,
                           commandType: CommandType.Text);

                return result.ToList();
            }
        }

        public async Task<RStudentPersonalInfoModel> GetById(string SrCode)
        {
            string procedure = _studentQuery.spGetById;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@p_SrCode", SrCode, DbType.String);

                var result = await connection.QuerySingleOrDefaultAsync<RStudentPersonalInfoModel>(
                           procedure,
                           parameters,
                           commandType: CommandType.Text);

                return result;
            }
        }

        public async Task<int> DeleteById(PStudentPersonalInfoParams codes)
        {
            string procedure = _studentQuery.spDelete;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                AddValuesToParameters(ref parameters, ref codes);

                return await connection.ExecuteAsync(procedure, parameters,
                            commandType: CommandType.Text);
            }
        }

        public async Task<int> Update(PStudentPersonalInfoModel<RStudentPersonalInfoModel> student)
        {
            string procedure = _studentQuery.spUpdate;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                AddValuesToParameters(ref parameters, ref student, RequestType.UPDATE);

                return await connection.ExecuteAsync(procedure, parameters,
                             commandType: CommandType.Text);
            }
        }

        public async Task<int> InsertNew(PStudentPersonalInfoModel<RStudentPersonalInfoModel> student)
        {
            string procedure = _studentQuery.spInsert;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                AddValuesToParameters(ref parameters, ref student, RequestType.INSERT);

                return await connection.ExecuteAsync(procedure, parameters,
                             commandType: CommandType.Text);
            }
        }


        #region Helper Methods
        private void AddValuesToParameters(ref DynamicParameters parameters, 
                                    ref PStudentPersonalInfoParams codes)
        {
            parameters.Add("@p_SrCode",              codes.SrCode);
            parameters.Add("@p_StudentNameCode",     codes.StudentNameCode);
            parameters.Add("@p_StudentAddressCode",  codes.StudentAddressCode);
            parameters.Add("@p_GuardianNameCode",    codes.GuardianNameCode);
            parameters.Add("@p_GuardianAddressCode", codes.GuardianAddressCode);
        }

        private void AddValuesToParameters(ref DynamicParameters parameters,
                    ref PStudentPersonalInfoModel<RStudentPersonalInfoModel> student,
                    RequestType request)
        {
            parameters.Add("@p_SrCode",        student.InfoModel.SrCode);
            parameters.Add("@p_LastName",      student.InfoModel.LastName);
            parameters.Add("@p_FirstName",     student.InfoModel.FirstName);
            parameters.Add("@p_MiddleName",    student.InfoModel.MiddleName);
            parameters.Add("@p_BirthDate",     student.InfoModel.BirthDate);
            parameters.Add("@p_Gender",        student.InfoModel.Gender);
            parameters.Add("@p_ContactNumber", student.InfoModel.ContactNumber);
            parameters.Add("@p_EmailAddress",  student.InfoModel.EmailAddress);
            parameters.Add("@p_HouseNumber",   student.InfoModel.HouseNumber);
            parameters.Add("@p_Barangay",      student.InfoModel.Barangay);
            parameters.Add("@p_Municipality",  student.InfoModel.Municipality);
            parameters.Add("@p_Province",      student.InfoModel.Province);
            parameters.Add("@p_GuardianLastName",      student.InfoModel.GuardianLastName);
            parameters.Add("@p_GuardianFirstName",     student.InfoModel.GuardianFirstName);
            parameters.Add("@p_GuardianMiddleName",    student.InfoModel.GuardianMiddleName);
            parameters.Add("@p_GuardianContactNumber", student.InfoModel.GuardianContactNumber);
            parameters.Add("@p_GuardianHouseNumber",   student.InfoModel.GuardianHouseNumber);
            parameters.Add("@p_GuardianBarangay",      student.InfoModel.GuardianBarangay);
            parameters.Add("@p_GuardianMunicipality",  student.InfoModel.GuardianMunicipality);
            parameters.Add("@p_GuardianProvince",      student.InfoModel.GuardianProvince);
            parameters.Add("@p_StudentNameCode",       student.UserId);
            parameters.Add("@p_StudentAddressCode",    student.UserId);
            parameters.Add("@p_GuardianNameCode",      student.GuardianCode);
            parameters.Add("@p_GuardianAddressCode",   student.GuardianCode);

            if (RequestType.INSERT == request)
            {
                int currentYear = DateTime.Now.Year; 
                string AcademicYear = $"A.Y. {currentYear-1}-{currentYear}";

                parameters.Add("@p_AcademicYear",          AcademicYear);
                parameters.Add("@p_DefaultPassword",       student.DefaultPassword);
                parameters.Add("@p_Position",              student.Position);
            }
        }
        #endregion

        private DatabaseContext _databaseContext;
        private StudentPersonalInfoQuery _studentQuery;
    }
}
