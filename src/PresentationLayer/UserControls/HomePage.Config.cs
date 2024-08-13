

using FontAwesome.Sharp;
using System;
using System.Threading.Tasks;

namespace PresentationLayer.UserControls
{
    partial class HomePage
    {
        private void TerminateRightUserControl()
        {
            RightPanel.Controls.Clear();
            _rightUserControl = null;
        }

        private void TerminateBottomUserControl()
        {
            BottomPanel.Controls.Clear();
            _bottomUserControl = null;
        }

        private void OnLoggoutButtonCreated(IconButton button)
        {
            if (button != null) { LogoutButtonCreated.TrySetResult(true); }
        }

        private async Task InitializeLogoutButtonSubscriber()
        {
            await LogoutButtonCreated.Task;

            LogoutButton.Click += delegate { LoggedOut?.Invoke(this, EventArgs.Empty); };
        }
    }
}
