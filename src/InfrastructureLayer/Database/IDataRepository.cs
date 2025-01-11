using Dapper;

namespace InfrastructureLayer.Database
{
    public interface IDataRepository
    {
        Task<int> CheckDatabaseConnection();

        Task<Dictionary<dynamic, dynamic>> GetAll(string procedure);
        
        Task<int> Execute(string procedure, DynamicParameters parameters);
        
        Task<TModel> GetSingle<TModel>(string procedure, DynamicParameters parameters);
        
        Task<List<TModel>> GetAll<TModel>(string procedure, DynamicParameters? parameters = null) where TModel : class;
    }
}