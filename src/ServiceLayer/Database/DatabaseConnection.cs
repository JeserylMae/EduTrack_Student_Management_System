
using DomainLayer.WebModels;


namespace ServiceLayer.Database
{
    public static class DatabaseConnection
    { 
        public static string GenerateConnectionString(ref ServerInfoModel serverInfo)
        {
            return $"Server={serverInfo.Localhost};"
                 + $"Database=edutrack_server;"
                 + $"User={serverInfo.UserId};"
                 + $"Password={serverInfo.Password};"
                 + $"SslMode=Required;"
                 + $"SslCa={serverInfo.SslCaPath};"
                 + $"SslCert={serverInfo.SslCertPath};"
                 + $"SslKey={serverInfo.SslKeyPath};";
        }
    }
}
