

using InfrastructureLayer.Database;

namespace InfrastructureLayer.Data
{
    internal static class BuilderServices
    {
        internal static void AddTransientServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUserRepository, MUserRepository>();
            builder.Services.AddTransient<IProgramRepository, MProgramRepository>();
            builder.Services.AddTransient<IEndpointRepository, MEndpointRepository>();
            builder.Services.AddTransient<IStudentAcademicInfoRepository, MStudentAcademicInfoRepository>();
            builder.Services.AddTransient<IStudentPersonalInfoRepository, MStudentPersonalInfoRepository>();
        }
    }
}
