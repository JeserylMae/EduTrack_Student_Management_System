

namespace PresentationLayer.UserControls
{
    partial class HomePage
    {
        void TerminateRightUserControl()
        {
            RightPanel.Controls.Clear();
            _rightUserControl = null;
        }

        void TerminateBottomUserControl()
        {
            BottomPanel.Controls.Clear();
            _bottomUserControl = null;
        }
    }
}
