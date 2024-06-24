using PresentationLayer.Presenters;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

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
            new EdutrackMainFormPresenter(edutrackMainForm, connectionString);

            Application.Run((Form)edutrackMainForm);
        }
    }
}
