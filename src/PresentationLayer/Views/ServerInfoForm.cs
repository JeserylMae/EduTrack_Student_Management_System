using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
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
            OnSSLButtonCreated(sslCaDialogButton, sslKeyDialogButton, sslCertDialogButton);

            _= InitializeExitAppButtonSubscriber();
            _= InitializeSubmitButtonSubscriber();
            _= InitializeSSLButtonSubscriber();
        }

        public void ShowForm() => this.Show();
        public void CloseForm() => this.Close();
        public DialogResult ShowSslCaFileDialog () => sslCaFileDialog.ShowDialog();
        public DialogResult ShowSslKeyFileDialog () => sslKeyFileDialog.ShowDialog();
        public DialogResult ShowSslCertFileDialog () => sslCertFileDialog.ShowDialog();

        public Size GetSize               { get => this.Size;            }
        public Point GetLocation          { get => this.Location;        }
        public string GetServerUserId     { get => UserIdTextbox.Text;   }
        public string GetServerPassword   { get => PasswordTextbox.Text; }
        public string GetServerServerName { get => ServerTextbox.Text;   }
        public string GetSslCaFileDialogFileName   { get => sslCaFileDialog.FileName;   }
        public string GetSslKeyFileDialogFileName  { get => sslKeyFileDialog.FileName;  }
        public string GetSslCertFileDialogFileName { get => sslCertFileDialog.FileName; }
        
        public string SslCaLabelText   
        { 
                get => sslCaLabel.Text;
                set => sslCaLabel.Text = value;   
        }
        public string SslKeyLabelText  
        { 
            get => sslKeyLabel.Text;
            set => sslKeyLabel.Text = value;  
        }
        public string SslCertLabelText 
        { 
            get => sslCertLabel.Text;
            set => sslCertLabel.Text = value; 
        }

        public string SetFileDialogInitDir { 
            set
            {
                sslCaFileDialog.InitialDirectory = value;
                sslKeyFileDialog.InitialDirectory = value;
                sslCertFileDialog.InitialDirectory = value;
            } 
        }

        public event EventHandler WindowExit;
        public event EventHandler SslCaButtonClicked;
        public event EventHandler SslKeyButtonClicked;
        public event EventHandler SubmittedServerInfo;
        public event EventHandler SslCertButtonClicked;

        private TaskCompletionSource<bool> SslCaButtonCreated = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> SslKeyButtonCreated = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> SubmitButtonCreated = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> SslCertButtonCreated = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> ExitAppButtonCreated = new TaskCompletionSource<bool>();
    }
}
