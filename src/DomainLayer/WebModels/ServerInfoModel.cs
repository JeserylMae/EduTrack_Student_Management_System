
namespace DomainLayer.WebModels
{
    public class ServerInfoModel
    {
        public string UserId      { get; set; }
        public string Localhost   { get; set; }
        public string Password    { get; set; }
        public string SslCaPath   { get; set; }
        public string SslKeyPath  { get; set; }
        public string SslCertPath { get; set; }
    }
}
