
using System;
using System.Windows.Forms;
using System.Web.Configuration;
using PresentationLayer.Views;
using PresentationLayer.Presenters;
using ServiceLayer.ConsoleServices;
using PresentationLayer.UserControls;

///
/// CREATE A METHOD WHICH AUTOMATICALLY ADDS THE secrets.json file 
/// IN DEBUG OR RELEASE FOLDER.
///
/// tasklist | findstr "InfrastructureLayer.exe"
/// tasklist | findstr "dotnet.exe"
/// taskkill /IM InfrastructureLayer.exe /F && taskkill /IM dotnet.exe /F && taskkill /IM cmd.exe /F 

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppSettings appSettings            = new AppSettings();
            SplashScreen splashScreen          = new SplashScreen();
            IServerInfoForm serverInfoForm     = new ServerInfoForm();
            IEdutrackMainForm edutrackMainForm = new EdutrackMainForm(serverInfoForm);

            new ServerInfoPresenter(serverInfoForm, edutrackMainForm, splashScreen, appSettings);
            new EdutrackMainFormPresenter(edutrackMainForm);


            Application.Run((Form)edutrackMainForm);
        }
    }
}
