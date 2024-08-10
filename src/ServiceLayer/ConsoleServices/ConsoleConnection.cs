using System;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class ConsoleConnection
    {
        public void GetExecuteWedAPIArguments(ref Dictionary<string, string> info)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string cd = config["Commands:CHANGE_DIR"];
            string execAPI = config["Commands:EXECUTE_WEB_API"];

            string arguments = $"/k {cd}\\ && {execAPI}";
            Console.WriteLine("arguments: " + arguments);

            info["args"] = arguments;
            info["cd"] = cd;
        }

        public Process ExecuteWebAPI()
        {
            Dictionary<string, string> Info = new Dictionary<string, string>();
            GetExecuteWedAPIArguments (ref Info);

            if (Info["cd"] != null)
            {
                var curr = Process.GetCurrentProcess();
                curr.Kill();
                curr.Close();
                curr.Dispose();
            }

            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = "cmd.exe";
            cmdProcess.StartInfo.Arguments = Info["arguments"];
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
