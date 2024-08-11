
using System;
using System.Windows.Forms;
using System.Web.Configuration;
using PresentationLayer.Views;
using PresentationLayer.Presenters;
using ServiceLayer.ConsoleServices;

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

            AppSettings appSettings = new AppSettings();
            IServerInfoForm serverInfoForm = new ServerInfoForm();
            IEdutrackMainForm edutrackMainForm = new EdutrackMainForm(serverInfoForm);

            new ServerInfoPresenter(serverInfoForm, edutrackMainForm, appSettings);
            new EdutrackMainFormPresenter(edutrackMainForm);

          //  Application.Run((Form)serverInfoForm);
            Application.Run((Form)edutrackMainForm);
        }
    }
}
