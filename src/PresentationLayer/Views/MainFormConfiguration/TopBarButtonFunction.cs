using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.MainFormConfiguration
{
    internal partial class TopBarButtonFunction
    {
        internal delegate void TopBarButtonEventHandler(Form form, object sender, EventArgs e);

        internal event TopBarButtonEventHandler TopBarButtonClicked;

        internal void Clicked(Form form)
        {
            OnTopBarButtonClicked(form);
        }

        protected virtual void OnTopBarButtonClicked(Form form) 
        {
            TopBarButtonClicked?.Invoke(form, this, EventArgs.Empty);
        }
    }
}
