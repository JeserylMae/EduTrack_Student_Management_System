using Dapper;

namespace InfrastructureLayer.Database
{
    public interface IDataRepository
    {
        Task<int> CheckDatabaseConnection();
        Task<int> Execute(string procedure, DynamicParameters parameters);
        Task<Dictionary<dynamic, dynamic>> GetAll(string procedure);
        Task<List<TModel>> GetAll<TModel>(string procedure) where TModel : class;
        Task<TModel> GetSingle<TModel>(string procedure, DynamicParameters parameters);
    }
}