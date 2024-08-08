using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class ServerInfoForm : Form, IServerInfoForm
    {
        public ServerInfoForm()
        {
            InitializeComponent();
            OnControlsCreated(ExitAppButton, SubmitServerInfoButton);

            _= InitializeExitAppButtonSubscriber();
            _= InitializeSubmitButtonSubscriber();
        }

        public void ShowForm() => this.Show();
        public void CloseForm() => this.Close();
        
        public string GetServerUserId     { get => UserIdTextbox.Text;   }
        public string GetServerPassword   { get => PasswordTextbox.Text; }
        public string GetServerServerName { get => ServerTextbox.Text;   }

        public event EventHandler WindowExit;
        public event EventHandler SubmittedServerInfo;

        private TaskCompletionSource<bool> SubmitButtonCreated = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> ExitAppButtonCreated = new TaskCompletionSource<bool>();
    }
}
