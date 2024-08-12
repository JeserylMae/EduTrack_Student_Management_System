
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.UserControls
{
    partial class LogInPage
    {
        private void OnLogInButtonCreated(Button LogInButton)
        {
            if (LogInButton != null) { LogInButtonCreated.TrySetResult(true); }
        }

        private async Task InitializeButtonSubscriber()
        {
            await LogInButtonCreated.Task;

            LogInButton.Click += delegate { LoggedIn?.Invoke(this, EventArgs.Empty); };
        }
    }
}
