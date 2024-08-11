using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.IO;


namespace ServiceLayer.ConsoleServices
{
    public class AppSettings
    {
        public AppSettings()
        {
            _configuration = SetUpServiceCollection();
        }

        private IConfiguration SetUpServiceCollection()
            => new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("secrets.json")
                .Build();

        public ConsoleConnection GetConsoleConnection()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<IConfiguration>(_configuration);
            services.AddSingleton<ConsoleConnection>();


            var serviceProvider = services.BuildServiceProvider();
            var cmdConn = serviceProvider.GetService<ConsoleConnection>();

            return cmdConn;
        }

        public void DestroyWebAPIConnection(ref Process cmdProcess, 
                                            ref ConsoleConnection cmdConn)
        {
            if (cmdProcess != null)
            {
                if (!cmdProcess.HasExited)
                {
                    cmdConn.ForceQuit();
                }
                cmdProcess.Close();
                cmdProcess.Dispose();
            }
        }

        private IConfiguration _configuration;
    }
}
