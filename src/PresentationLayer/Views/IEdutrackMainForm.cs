
using System;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public delegate void TopBarButtonEventHandler(Form form, object sender, EventArgs e);
    public delegate void MouseClickedEventHandler(Form form, object sender, MouseEventArgs e);

     interface IEdutrackMainForm
    {
        event TopBarButtonEventHandler WindowExit;
        event TopBarButtonEventHandler WindowMaximized;
        event TopBarButtonEventHandler WindowMinimized;
        event MouseClickedEventHandler MouseClicked;
    }
}
