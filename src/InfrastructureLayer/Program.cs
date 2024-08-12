
using InfrastructureLayer.Data;
using InfrastructureLayer.Database;
using System.Data;


public static class Program
{
    public static void Main(string[] args)
    {
        string? connectionString = args.FirstOrDefault(arg => arg.StartsWith("ConnectionStrings="))?.Split("=")[1];

        //connectionString = "Server@JesayMae;"
        //                     + "Database@edutrack_server;"
        //                     + "User@Edutrack_User;"
        //                     + "Password@2NXzenE74FrwQk#JqwaB;"
        //                     + "SslMode@Required;"
        //                     + "SslCa@C:\\ProgramData\\MySQL\\MySQL Server 8.0\\Data\\ca.pem;"
        //                     + "SslCert@C:\\ProgramData\\MySQL\\MySQL Server 8.0\\Data\\client-cert.pem;"
        //                     + "SslKey@C:\\ProgramData\\MySQL\\MySQL Server 8.0\\Data\\client-key.pem;";

        // Filter out the connection string argument to pass only the original arguments to the builder
        var filteredArgs = args.Where(arg => !arg.StartsWith("ConnectionStrings=")).ToArray();

        if (string.IsNullOrEmpty(connectionString))
            throw new Exception("No connection string given.");

        var builder = WebApplication.CreateBuilder(filteredArgs);
        //this.InitializeAppBuilder();

        // Add services to the container.

        builder.Services.AddHttpClient();
        builder.Services.AddControllers();
        builder.Services.AddControllersWithViews();

        builder.Services.AddTransient<DatabaseContext>(sp => new DatabaseContext(connectionString));
        builder.Services.AddTransient<IEndpointRepository, EndpointRepository>();
        builder.Services.AddTransient<IUserRepository, UserRepository>();
        


        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}