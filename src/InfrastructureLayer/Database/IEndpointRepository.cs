
namespace InfrastructureLayer.Database
{
    public interface IEndpointRepository
    {
        Task<int> CheckDatabaseConnection();
    }
}