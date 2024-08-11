using System;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;


namespace ServiceLayer.ConsoleServices
{
    public class ConsoleConnection
    {
        public ConsoleConnection(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Process ExecuteWebAPI(string connectionString)
        {
            Dictionary<string, string> Info = new Dictionary<string, string>();
            GetExecuteWedAPIArguments (ref Info, ref connectionString);

            Process cmdProcess = new Process();
            ConfigureProcessStartInfo(process: ref cmdProcess, fname: "cmd.exe", 
                                      args: Info["arguments"]);
            cmdProcess.Start();

            return cmdProcess;
        }

        public void ForceQuit()
        {
            Dictionary<string, string> Info = new Dictionary<string, string>();
            GetForceQuitArguments(ref Info);

            Console.WriteLine($"Args: {Info["arguments"]}");
            //cmdProcess.StartInfo.Arguments = Info["arguments"];

            Process process = new Process();
            ConfigureProcessStartInfo(ref process, "cmd.exe", Info["arguments"]);
            process.Start();
            process.WaitForExit(2000);
            
            if (!process.HasExited) process.Kill();

            DisplayFinishedTaskPath(Info["webPath"], ref process);
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
            info["arguments"] = _configuration["Commands:TASKKILL_CMD"];
            info["webPath"] = _configuration["Projects:WEB_API_PATH"];
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

        private void GetExecuteWedAPIArguments(ref Dictionary<string, string> info, 
                                               ref string connectionString)
        {
            string cd      = _configuration["Commands:CHANGE_DIR"];
            string execAPI = _configuration["Commands:EXECUTE_WEB_API"];

            string arguments = $"/k {cd}\\ && {execAPI}=\"{connectionString}\"";
            Console.WriteLine("arguments: " + arguments);

            info["arguments"] = arguments;
            info["cd"] = cd;
        }

        private void DisposeProcess(ref Process process)
        {
            process.Close();
            process.Dispose();
        }

        private readonly IConfiguration _configuration;
    }
}
