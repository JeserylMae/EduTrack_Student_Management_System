using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AppHelper
{
    internal class TopBarButtonHelper
    {
        public delegate void TopBarButtonEventHandler(Form form, object sender, EventArgs e);

        public event TopBarButtonEventHandler TopBarButtonClicked;

        internal void Clicked(Form form)
        {
            OnTopBarButtonClicked(form);
        }

        protected virtual void OnTopBarButtonClicked(Form form) 
        {
            if (TopBarButtonClicked != null) 
            {
                TopBarButtonClicked(form, this, EventArgs.Empty);
            }
        }
    }
}
