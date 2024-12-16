using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace PresentationLayer.Presenters
{
    internal static class GeneralPresenter
    {
        public static event EventHandler WindowExitSubscriber;

        public static void TriggerAppExit(object sender, EventArgs e)
        {
            WindowExitSubscriber.Invoke(sender, e);
        }
    }
}
