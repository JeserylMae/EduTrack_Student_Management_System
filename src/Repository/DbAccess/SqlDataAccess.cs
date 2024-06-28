
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace WebService.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionID = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionID));

            return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task SaveData<T>(string storedProcedure, T parameters, string connectionID = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionID));

            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

        private IConfiguration _config;
    }
}
