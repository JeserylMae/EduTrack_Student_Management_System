
using InfrastructureLayer.Database;

namespace InfrastructureLayer.Data
{
    internal static class BuilderServices
    {
        internal static void AddTransientServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IDataRepository, DataRepository>();
            builder.Services.AddTransient<IStudentAcademicInfoRepository, StudentAcademicInfoRepository>();
            builder.Services.AddTransient<IInstructorAcademicInfoRepository, InstructorAcademicInfoRepository>();
        }
    }
}
