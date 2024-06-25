using PresentationLayer.Presenters;
using System.Web.Configuration;
using System.Windows.Forms;
using System;

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
            
            string connectionString = WebConfigurationManager.ConnectionStrings["CONSTR.EDUTRACK"].ConnectionString;
            IEdutrackMainForm edutrackMainForm = new EdutrackMainForm();

            edutrackMainForm.ConnectionString = connectionString;
            new EdutrackMainFormPresenter(edutrackMainForm);

            Application.Run((Form)edutrackMainForm);
        }
    }
}
