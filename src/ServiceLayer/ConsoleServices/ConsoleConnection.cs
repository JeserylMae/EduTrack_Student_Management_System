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
        public void GetExecuteWedAPIArguments()
        {

        }
        public static Process StartCommandPrompt()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string cd = config["Commands:CHANGE_DIR"];
            string execAPI = config["Commands:EXECUTE_WEB_API"];

            string arguments = $"/k {cd}\\ && {execAPI}";
            Console.WriteLine("arguments: " + arguments);


            /// break here
            /// ExecuteWebAPI()
            if (cd != null)
            {
                var curr = Process.GetCurrentProcess();
                curr.Kill();
                curr.Close();
                curr.Dispose();
            }

            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = "cmd.exe";
            cmdProcess.StartInfo.Arguments = arguments;
            cmdProcess.StartInfo.CreateNoWindow = false;
            cmdProcess.StartInfo.UseShellExecute = true;
            cmdProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmdProcess.Start();

            return cmdProcess;
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
