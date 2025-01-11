
using Dapper;
using System.Data;
using InfrastructureLayer.Data;

namespace InfrastructureLayer.Database
{
    public class DataRepository : IDataRepository
    {
        public DataRepository(DatabaseContext databaseContext)
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

        public async Task<List<TModel>> GetAll<TModel>(string procedure, 
                                    DynamicParameters? parameters = null) 
                                    where TModel : class
        {
            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                IEnumerable<TModel> result = new List<TModel>();
                
                result = await connection.QueryAsync<TModel>(
                    procedure, 
                    param: parameters,
                    commandType: CommandType.Text
                );

                return result.ToList();
            }
        }

        public async Task<Dictionary<dynamic, dynamic>> GetAll(string procedure)
        {
            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                var result = await connection.QueryAsync(
                    procedure, commandType: CommandType.Text
                );
                return result.ToDictionary(
                    row => (dynamic)row.ProgramId,
                    row => (dynamic)row.ProgramName
                );
            }
        }

        public async Task<TModel> GetSingle<TModel>(string procedure, DynamicParameters parameters)
        {
            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                var response = await connection.QuerySingleOrDefaultAsync<TModel>(
                    procedure, param: parameters,
                    commandType: CommandType.Text
                );

                return response;
            }
        }

        public async Task<int> Execute(string procedure, DynamicParameters parameters)
        {
            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                return await connection.ExecuteAsync(
                    procedure, parameters,
                    commandType: CommandType.Text);
            }
        }


        private DatabaseContext _databaseContext;
    }
}
