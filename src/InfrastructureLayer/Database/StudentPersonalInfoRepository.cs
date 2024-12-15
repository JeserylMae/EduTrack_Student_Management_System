

using Dapper;
using DomainLayer.DataModels;
using InfrastructureLayer.Data;
using System.Data;

namespace InfrastructureLayer.Database
{
    public class StudentPersonalInfoRepository : IStudentPersonalInfoRepository
    {
        public StudentPersonalInfoRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<StudentPersonalInfoModel>> GetAll()
        {
            string storedProcedure = "spStudent_SelectAllPersonalInfo";

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                var result = await connection.QueryAsync<StudentPersonalInfoModel>(storedProcedure,
                           commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }

        public async Task<StudentPersonalInfoModel> GetById(string SrCode)
        {
            string storedProcedure = "spStudent_SelectPersonalInfoById";

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("p_SrCode", SrCode, DbType.String);

                var result = await connection.QuerySingleOrDefaultAsync<StudentPersonalInfoModel>(
                           storedProcedure,
                           parameters,
                           commandType: CommandType.StoredProcedure);

                return result;
            }
        }

        public async Task<int> Update(PersonalInfoModel<StudentPersonalInfoModel> student)
        {
            string storedProcedure = "spStudent_UpdatePersonalInfo";

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                AddValuesToParameters(ref parameters, ref student, "UPDATE");

                return await connection.ExecuteAsync(storedProcedure, parameters,
                             commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<int> InsertNew(PersonalInfoModel<StudentPersonalInfoModel> student)
        {
            string storedProcedure = "spStudent_InsertNewPersonalInfo";

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                AddValuesToParameters(ref parameters, ref student, "ADD");

                return await connection.ExecuteAsync(storedProcedure, parameters,
                             commandType: CommandType.StoredProcedure);
            }
        }


        #region Helper Methods
        private void AddValuesToParameters(ref DynamicParameters parameters,
                    ref PersonalInfoModel<StudentPersonalInfoModel> student,
                    string modification)
        {
            parameters.Add("p_SrCode",        student.InfoModel.SrCode);
            parameters.Add("p_LastName",      student.InfoModel.LastName);
            parameters.Add("p_FirstName",     student.InfoModel.FirstName);
            parameters.Add("p_MiddleName",    student.InfoModel.MiddleName);
            parameters.Add("p_BirthDate",     student.InfoModel.BirthDate);
            parameters.Add("p_Gender",        student.InfoModel.Gender);
            parameters.Add("p_ContactNumber", student.InfoModel.ContactNumber);
            parameters.Add("p_EmailAddress",  student.InfoModel.EmailAddress);
            parameters.Add("p_HouseNumber",   student.InfoModel.HouseNumber);
            parameters.Add("p_Barangay",      student.InfoModel.Barangay);
            parameters.Add("p_Municipality",  student.InfoModel.Municipality);
            parameters.Add("p_Province",      student.InfoModel.Province);
            parameters.Add("p_GuardianLastName",      student.InfoModel.GuardianLastName);
            parameters.Add("p_GuardianFirstName",     student.InfoModel.GuardianFirstName);
            parameters.Add("p_GuardianMiddleName",    student.InfoModel.GuardianMiddleName);
            parameters.Add("p_GuardianContactNumber", student.InfoModel.GuardianContactNumber);
            parameters.Add("p_GuardianHouseNumber",   student.InfoModel.GuardianHouseNumber);
            parameters.Add("p_GuardianBarangay",      student.InfoModel.GuardianBarangay);
            parameters.Add("p_GuardianMunicipality",  student.InfoModel.GuardianMunicipality);
            parameters.Add("p_GuardianProvince",      student.InfoModel.GuardianProvince);
            parameters.Add("p_StudentNameCode",       student.StudentCode);
            parameters.Add("p_StudentAddressCode",    student.StudentCode);
            parameters.Add("p_GuardianNameCode",      student.GuardianCode);
            parameters.Add("p_GuardianAddressCode",   student.GuardianCode);

            if (modification == "ADD")
            {
                parameters.Add("p_DefaultPassword",       student.DefaultPassword);
                parameters.Add("p_Position",              student.Position);
            }
        }
        #endregion

        private DatabaseContext _databaseContext;
    }
}
