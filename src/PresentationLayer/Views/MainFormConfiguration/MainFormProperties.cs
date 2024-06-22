using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views.MainFormConfiguration
{
    internal partial class MainFormProperties
    {
        internal delegate void MouseClickedEventHandler (Form form, object sender, MouseEventArgs e);

        internal event MouseClickedEventHandler MouseClicked;

        internal void Clicked(Form form, MouseEventArgs mouseEventArgs)
        {
            OnMouseCliked(form, mouseEventArgs);
        }

        protected virtual void OnMouseCliked(Form form, MouseEventArgs mouseEventArgs)
        {
            MouseClicked?.Invoke(form, this, mouseEventArgs);
        }
    }
}
