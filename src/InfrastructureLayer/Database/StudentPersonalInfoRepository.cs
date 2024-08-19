

using Dapper;
using DomainLayer.DataModels;
using InfrastructureLayer.Data;
using System.Data;

namespace InfrastructureLayer.Database
{
    public class StudentPersonalInfoRepository
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

        private DatabaseContext _databaseContext;
    }
}
