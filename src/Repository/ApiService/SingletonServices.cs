using WebService.DbAccess;

namespace WebService.ApiService
{
    public static class SingletonServices
    {
        public static WebApplicationBuilder AddSingletonServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
            builder.Services.AddSingleton<IEdutrackUserDataAccess, EdutrackUserDataAccess>();

            return builder;
        }
    }
}
