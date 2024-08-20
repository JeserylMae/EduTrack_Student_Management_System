

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

        public async Task<int> InsertNew(StudentPersonalInfoModel studentPersonalInfo,
                                      string DefaultPassword, string Position, 
                                      string StudentCode, string GuardianCode)
        {
            string storedProcedure = "spStudent_InsertNewPersonalInfo";

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("p_SrCode",        studentPersonalInfo.SrCode);
                parameters.Add("p_LastName",      studentPersonalInfo.LastName);
                parameters.Add("p_FirstName",     studentPersonalInfo.FirstName);
                parameters.Add("p_MiddleName",    studentPersonalInfo.MiddleName);
                parameters.Add("p_BirthDate",     studentPersonalInfo.BirthDate);
                parameters.Add("p_Gender",        studentPersonalInfo.Gender);
                parameters.Add("p_ContactNumber", studentPersonalInfo.ContactNumber);
                parameters.Add("p_EmailAddress",  studentPersonalInfo.EmailAddress);
                parameters.Add("p_HouseNumber",   studentPersonalInfo.ZipCode);
                parameters.Add("p_Barangay",      studentPersonalInfo.Barangay);
                parameters.Add("p_Municipality",  studentPersonalInfo.Municipality);
                parameters.Add("p_Province",              studentPersonalInfo.Province);
                parameters.Add("p_GuardianLastName",      studentPersonalInfo.GuardianLastName);
                parameters.Add("p_GuardianFirstName",     studentPersonalInfo.GuardianFirstName);
                parameters.Add("p_GuardianMiddleName",    studentPersonalInfo.GuardianMiddleName);
                parameters.Add("p_GuardianContactNumber", studentPersonalInfo.GuardianContactNumber);
                parameters.Add("p_GuardianHouseNumber",   studentPersonalInfo.GuardianZipCode);
                parameters.Add("p_GuardianBarangay",      studentPersonalInfo.GuardianBarangay);
                parameters.Add("p_GuardianMunicipality",  studentPersonalInfo.GuardianMunicipality);
                parameters.Add("p_GuardianProvince",      studentPersonalInfo.GuardianProvince);
                parameters.Add("p_StudentNameCode",       StudentCode);
                parameters.Add("p_StudentAddressCode",    StudentCode);
                parameters.Add("p_GuardianNameCode",      GuardianCode);
                parameters.Add("p_GuardianAddressCode",   GuardianCode);
                parameters.Add("p_DefaultPassword",       DefaultPassword);
                parameters.Add("p_Position",              Position);

                return await connection.ExecuteAsync(storedProcedure, parameters,
                                       commandType: CommandType.StoredProcedure);
            }

        }

        private DatabaseContext _databaseContext;
    }
}
