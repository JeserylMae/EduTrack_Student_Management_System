using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ConsoleConnection consoleConnection = new ConsoleConnection();

            // Check if .NET SDK is installed
            if (!consoleConnection.IsDotNetInstalled())
            {
                Console.WriteLine(".NET SDK not found. Installing .NET SDK...");
                string installerPath = await consoleConnection.DownloadDotNetInstallerAsync();
                if (installerPath != null)
                {
                    consoleConnection.InstallDotNet(installerPath);
                }
                else
                {
                    Console.WriteLine("Failed to download .NET SDK installer.");
                }
            }
            else
            {
                Console.WriteLine(".NET SDK is already installed.");
            }
        }
    }
}
