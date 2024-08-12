
using System.Drawing;

namespace PresentationLayer.Views
{
    public interface ISplashScreen
    {
        void ShowForm();
        void CloseForm();
        void SetFormLocation(Point ParentLocation, Size ParentSize);
    }
}
