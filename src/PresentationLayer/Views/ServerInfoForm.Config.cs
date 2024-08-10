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

        private void OnSSLButtonCreated(IconButton sslCaButton, IconButton sslKeyButton,
                                        IconButton sslCertButton) 
        {
            if (sslCaButton != null) SslCaButtonCreated.TrySetResult(true); 
            if (sslKeyButton != null) SslKeyButtonCreated.TrySetResult(true); 
            if (sslCertButton != null) SslCertButtonCreated.TrySetResult(true); 
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

        private async Task InitializeSSLButtonSubscriber()
        {
            await SslCaButtonCreated.Task;
            sslCaDialogButton.Click += delegate { SslCaButtonClicked?.Invoke(this, EventArgs.Empty); };

            await SslKeyButtonCreated.Task;
            sslKeyDialogButton.Click += delegate { SslKeyButtonClicked?.Invoke(this, EventArgs.Empty); };

            await SslCertButtonCreated.Task;
            sslCertDialogButton.Click += delegate { SslCertButtonClicked?.Invoke(this, EventArgs.Empty); };
        }
    }
}
