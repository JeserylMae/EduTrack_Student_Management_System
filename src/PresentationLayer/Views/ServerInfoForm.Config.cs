using System;
using FontAwesome.Sharp;
using System.Threading.Tasks;

namespace PresentationLayer.Views
{
    partial class ServerInfoForm
    {
        private void OnControlsCreated(IconButton exitButton, IconButton submitButton)
        {
            if (exitButton != null) ExitAppButtonCreated.TrySetResult(true);
            if (submitButton != null) SubmitButtonCreated.TrySetResult(true);
        }

        private async Task InitializeExitAppButtonSubscriber()
        {
            await ExitAppButtonCreated.Task;
            ExitAppButton.Click += delegate { WindowExit?.Invoke(this, EventArgs.Empty); };
        }

        private async Task InitializeSubmitButtonSubscriber() 
        {
            await SubmitButtonCreated.Task;
            SubmitServerInfoButton.Click += delegate { SubmittedServerInfo?.Invoke(this, EventArgs.Empty); };
        }
    }
}
