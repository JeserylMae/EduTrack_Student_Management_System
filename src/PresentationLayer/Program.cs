
using System;
using System.Windows.Forms;
using PresentationLayer.Views;
using PresentationLayer.Presenters;
using ServiceLayer.ConsoleServices;
using ServiceLayer.Database;
using System.Reflection;

///
/// CREATE A METHOD WHICH AUTOMATICALLY ADDS THE secrets.json file 
/// IN DEBUG OR RELEASE FOLDER.
///
/// tasklist | findstr "InfrastructureLayer.exe"
/// tasklist | findstr "dotnet.exe"
/// taskkill /IM InfrastructureLayer.exe /F && taskkill /IM dotnet.exe /F && taskkill /IM cmd.exe /F 
/// 2NXzenE74FrwQk#JqwaB

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


//This exception was originally thrown at this call stack:
//    ServiceLayer.Database.StudentPersonalInfoServices.HasNullOrEmptyString<TModel>(TModel) in StudentPersonalInfoServices.cs
//    ServiceLayer.Database.StudentPersonalInfoServices.HasNullOrEmptyString<TModel>(TModel) in StudentPersonalInfoServices.cs
//    ServiceLayer.Database.StudentPersonalInfoServices.HasNullOrEmptyString<TModel>(TModel) in StudentPersonalInfoServices.cs
//    ServiceLayer.Database.StudentPersonalInfoServices.ValidateParameter(DomainLayer.DataModels.PersonalInfoModel<DomainLayer.DataModels.StudentPersonalInfoModel>) in StudentPersonalInfoServices.cs
//    System.Runtime.CompilerServices.AsyncMethodBuilderCore.ThrowAsync.AnonymousMethod__6_0(object)


