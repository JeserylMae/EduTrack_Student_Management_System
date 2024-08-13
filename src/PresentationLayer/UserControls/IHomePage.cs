
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public interface IHomePage
    {
        UserControl RightUserControlPage { get; set; }
        UserControl BottomUserControlPage { get; set; }
    }
}
