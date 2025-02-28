﻿
using System;
using System.Windows.Forms;
using PresentationLayer.Views;
using PresentationLayer.Presenters;
using ServiceLayer.ConsoleServices;
using ServiceLayer.Database;
using System.Reflection;
using PresentationLayer.Presenters.General;


namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                AppSettings appSettings = new AppSettings();
                SplashScreen splashScreen = new SplashScreen();
                IServerInfoForm serverInfoForm = new ServerInfoForm();
                IEdutrackMainForm edutrackMainForm = EdutrackMainForm.GetInstance(serverInfoForm);

                new ServerInfoPresenter(serverInfoForm, edutrackMainForm, splashScreen, appSettings);
                new EdutrackMainFormPresenter(edutrackMainForm);

                Application.Run((Form)edutrackMainForm);
            }
            catch (Exception ex)
            {
                Console.WriteLine("====================================================");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                //Console.WriteLine($"Inner Message: {ex.InnerException.Message}");
                //Console.WriteLine($"Inner StackTrace: {ex.InnerException.StackTrace}");
            }
        }
    }
}

