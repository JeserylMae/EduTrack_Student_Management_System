using System;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ConsoleConnection
    {
        private static readonly HttpClient client = new HttpClient(); // Singleton instance for HttpClient

        public bool IsDotNetInstalled()
        {
            Process process = new Process();
            bool isInstalled = false;

            ConfigureProcessStartInfo(ref process, "dotnet", "--list-sdks");
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            isInstalled = !string.IsNullOrWhiteSpace(output);
            DisposeProcess(ref process);

            return isInstalled;
        }

        public async Task<string> DownloadDotNetInstallerAsync()
        {
            var config = ConfigBuilder();

            string url = config["URL:DOTNET_INSTALLER"];
            if (string.IsNullOrEmpty(url))
            {
                throw new InvalidOperationException("The URL for the .NET installer is not configured.");
            }

            string tempFilePath = Path.GetTempFileName();

            bool IsSuccessfull = await SuccessfullHTTPRequestAsync(tempFilePath, url);

            return IsSuccessfull ? tempFilePath : null;
        }

        public void InstallDotNet(string installerPath)
        {
            Process process = new Process();

            try
            {
                ConfigureProcessStartInfo(ref process, installerPath, "/quiet");
                process.Start();
                process.WaitForExit();

                Console.WriteLine(".NET SDK installation completed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to install .NET SDK: " + ex.Message);
            }
            finally
            {
                if (File.Exists(installerPath)) File.Delete(installerPath);
                DisposeProcess(ref process);
            }
        }

        private async Task<bool> SuccessfullHTTPRequestAsync(string tempFilePath, string url)
        {
            bool IsSuccessful;
            HttpResponseMessage response = await client.GetAsync(url);

            try
            {
                response.EnsureSuccessStatusCode();
                using (var fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                {
                    await response.Content.CopyToAsync(fs);
                }
                IsSuccessful = true;
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine("HTTP request failed: " + httpEx.Message);
                IsSuccessful = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                IsSuccessful = false;
            }
            finally
            {
                response?.Dispose();
            }

            return IsSuccessful;
        }

        private void ConfigureProcessStartInfo(ref Process process,
                                        string fname, string args)
        {
            process.StartInfo.FileName = fname;
            process.StartInfo.Arguments = args;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;  
            process.StartInfo.RedirectStandardError = true;  
        }

        private void DisposeProcess(ref Process process)
        {
            process.Close();
            process.Dispose();
        }

        private IConfigurationRoot ConfigBuilder()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config;
        }
    }
}
