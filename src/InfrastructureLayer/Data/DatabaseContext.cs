using MySql.Data.MySqlClient;
using System.Data;

namespace InfrastructureLayer.Data
{
    public class DatabaseContext
    {
        // private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString.Replace('@', '=');
        }

        // main ng web api
        public IDbConnection CreateConnection() => new MySqlConnection(_connectionString);
    }
}
