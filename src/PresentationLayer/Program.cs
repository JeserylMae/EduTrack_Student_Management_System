
using System;
using System.Windows.Forms;
using System.Web.Configuration;
using PresentationLayer.Views;
using PresentationLayer.Presenters;

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

            string connectionString = "";
            IServerInfoForm serverInfoForm = new ServerInfoForm();
            IEdutrackMainForm edutrackMainForm = new EdutrackMainForm(serverInfoForm);

            edutrackMainForm.ConnectionString = connectionString;

            new ServerInfoPresenter(serverInfoForm, edutrackMainForm);
            new EdutrackMainFormPresenter(edutrackMainForm);

          //  Application.Run((Form)serverInfoForm);
            Application.Run((Form)edutrackMainForm);
        }
    }
}
