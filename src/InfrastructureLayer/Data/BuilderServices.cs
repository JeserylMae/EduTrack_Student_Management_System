

using InfrastructureLayer.Database;

namespace InfrastructureLayer.Data
{
    internal static class BuilderServices
    {
        internal static void AddTransientServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUserRepository, UserRepository>();
            builder.Services.AddTransient<IEndpointRepository, EndpointRepository>();
            builder.Services.AddTransient<IStudentPersonalInfoRepository, StudentPersonalInfoRepository>();
        }
    }
}
