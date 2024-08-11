using Dapper;
using InfrastructureLayer.Data;
using System.Data;

namespace InfrastructureLayer.Database
{
    public class EndpointRepository : IEndpointRepository
    {
        private readonly DatabaseContext _databaseContext;

        public EndpointRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<int> CheckDatabaseConnection()
        {
            string query = "SELECT 1";

            using IDbConnection connection = _databaseContext.CreateConnection();
            int result = await connection.ExecuteScalarAsync<int>(query);

            return result;
        }
    }
}
