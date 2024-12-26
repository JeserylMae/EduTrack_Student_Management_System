using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PresentationLayer.Presenters.General
{
    internal static class GeneralPresenter
    {
        public static UserControl NewWindowControl;

        public static event EventHandler WindowExitSubscriber;
        public static event EventHandler WindowOpenControlSubscriber;

        public static void TriggerAppExit(object sender, EventArgs e) 
            => WindowExitSubscriber.Invoke(sender, e);

        public static void TriggerWindowControlChange(object sender, EventArgs e) 
            => WindowOpenControlSubscriber.Invoke(sender, e);
    }
}
