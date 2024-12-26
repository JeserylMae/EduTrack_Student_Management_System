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


        private DatabaseContext _databaseContext;
        private StudentAcadInfoQuery _studentQuery;
    }
}
