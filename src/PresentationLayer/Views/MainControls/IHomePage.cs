
using System;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.MainControls
{
    public interface IHomePage
    {
        void DestroyControl();
        event EventHandler LoggedOut; 
        UserControl RightUserControlPage { get; set; }
        UserControl BottomUserControlPage { get; set; }
    }
}
