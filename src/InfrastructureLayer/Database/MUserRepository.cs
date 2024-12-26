
using Dapper;
using DomainLayer.DataModels;
using InfrastructureLayer.Data;
using InfrastructureLayer.Query;
using System.Data;

namespace InfrastructureLayer.Database
{
    public class MUserRepository : IUserRepository
    {
        private readonly DatabaseContext _databaseContext;

        public MUserRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _userQuery = new UserQuery();
        }

        public async Task<PRUserModel?> GetById(string UserId)
        {
            string procedure = _userQuery.GetById;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@p_userId", UserId, DbType.String);

                var user = await connection.QuerySingleOrDefaultAsync<PRUserModel>(
                    procedure,
                    parameters,
                    commandType: CommandType.Text
                );

                return user;
            }
        }


        private UserQuery _userQuery;
    }
}
