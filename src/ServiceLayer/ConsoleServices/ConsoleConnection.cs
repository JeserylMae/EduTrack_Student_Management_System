using System;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace ServiceLayer
{
    public class ConsoleConnection
    {
        public ConsoleConnection(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Process ExecuteWebAPI()
        {
            Dictionary<string, string> Info = new Dictionary<string, string>();
            GetExecuteWedAPIArguments (ref Info);

            Process cmdProcess = new Process();
            ConfigureProcessStartInfo(process: ref cmdProcess, fname: "cmd.exe", 
                                      args: Info["arguments"]);
            cmdProcess.Start();

            return cmdProcess;
        }

        public void ForceQuit(Process cmdProcess)
        {
            Dictionary<string, string> Info = new Dictionary<string, string>();
            GetForceQuitArguments(ref Info);

            Console.WriteLine($"Args: {Info["arguments"]}");

            cmdProcess.StartInfo.Arguments = Info["arguments"];
            cmdProcess.Start();
            cmdProcess.WaitForExit(2000);
            cmdProcess.Kill();

            DisplayFinishedTaskPath(Info["webPath"], ref cmdProcess);
        }

        private void DisplayFinishedTaskPath(string webPath, ref Process process)
        {
            if (process.ExitCode != 0)
            {
                string path = Path.GetFullPath(webPath);
                Console.WriteLine($"\n{path} (process id {process.Id})");
            }
        }

        private void GetForceQuitArguments(ref Dictionary<string, string> info)
        {
            string taskKill = _configuration["Commands:TASKKILL_NAME"];
            string webExe = _configuration["Projects:WEB_API_EXE"];
            string webPath = _configuration["Projects:WEB_API_PATH"];

            string arguments = $"/k {taskKill} {webExe} /F && {taskKill} cmd.exe";

            info["arguments"] = arguments;
            info["webPath"] = webPath;
        }

        private void ConfigureProcessStartInfo(ref Process process,
                                        string fname, string args)
        {
            process.StartInfo.FileName = fname;
            process.StartInfo.Arguments = args;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        }

        private void GetExecuteWedAPIArguments(ref Dictionary<string, string> info)
        {
            string cd      = _configuration["Commands:CHANGE_DIR"];
            string execAPI = _configuration["Commands:EXECUTE_WEB_API"];

            string arguments = $"/k {cd}\\ && {execAPI}";
            Console.WriteLine("arguments: " + arguments);

            info["args"] = arguments;
            info["cd"] = cd;
        }

        private void DisposeProcess(ref Process process)
        {
            process.Close();
            process.Dispose();
        }

        private IConfigurationRoot ConfigBuilder()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config;
        }


        private readonly IConfiguration _configuration;
    }
}
