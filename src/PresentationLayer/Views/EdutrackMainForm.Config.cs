using PresentationLayer.Presenters;
using System;
using System.Runtime.Remoting.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    partial class EdutrackMainForm
    {
        internal void OnTopBarPanelCreated(Panel TopBarPanel)
        {
            if (TopBarPanel != null)    TopBarCreated.TrySetResult(true);
        }

        private async Task InitializeTopBarButtonSubscribers()
        {
            await TopBarCreated.Task;

            ExitAppButton.Click     += delegate { WindowExit?     .Invoke(this, EventArgs.Empty); };
            MaximizeAppbutton.Click += delegate { WindowMaximized?.Invoke(this, EventArgs.Empty); };
            MinimizeAppButton.Click += delegate { WindowMinimized?.Invoke(this, EventArgs.Empty); };
        }

        private async Task AppMainPanelEventSubscriber()
        {
            await TopBarCreated.Task;

            TopBarPanel.MouseDown += (sender, e) => MousePressed?.Invoke(sender, e);
            TopBarPanel.MouseMove += (sender, e) => MouseMoved?  .Invoke(sender, e);
        }
    }
}
