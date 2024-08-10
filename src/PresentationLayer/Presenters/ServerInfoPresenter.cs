using DomainLayer.WebModels;
using PresentationLayer.Views;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Presenters
{
    internal class ServerInfoPresenter
    {
        public ServerInfoPresenter(IServerInfoForm serverInfoForm, IEdutrackMainForm edutrackMainForm) 
        { 
            _serverInfoForm = serverInfoForm;
            _edutrackMainForm = edutrackMainForm;

            _serverInfoForm.WindowExit          += ExitAppButton_Clicked;
            _serverInfoForm.SubmittedServerInfo += ServerInfoButton_Clicked;
            _serverInfoForm.SslCaButtonClicked += SslCaDialogButton_Clicked;
            _serverInfoForm.SslKeyButtonClicked += SslKeyDialogButton_Clicked;
            _serverInfoForm.SslCertButtonClicked += SslCertDialogButton_Clicked;
        }

        private void ExitAppButton_Clicked(object sender, EventArgs e) 
            => Application.Exit();

        private void RunEdutrackForm()
        {
            _serverInfoForm.CloseForm();
            _edutrackMainForm.FormWindowState = FormWindowState.Normal;
        }

        private void ServerInfoButton_Clicked(object sender, EventArgs e)
        {
            ServerInfoModel serverInfo = new ServerInfoModel();
            serverInfo.UserId      = _serverInfoForm.GetServerUserId;
            serverInfo.Localhost   = _serverInfoForm.GetServerServerName;
            serverInfo.Password    = _serverInfoForm.GetServerPassword;
            serverInfo.SslCaPath   = _serverInfoForm.SslCaLabelText;
            serverInfo.SslKeyPath  = _serverInfoForm.SslKeyLabelText;
            serverInfo.SslCertPath = _serverInfoForm.SslCertLabelText;

            // Function that validates whether the connection string can
            // successfully send request to the web api.
            // return value: bool

            // Only run this function when the web api connection is
            // successful.
            RunEdutrackForm();
        }

        private void SslCaDialogButton_Clicked(object sender, EventArgs e)
        {
            if (_serverInfoForm.ShowSslCaFileDialog() == DialogResult.OK)
                _serverInfoForm.SslCaLabelText = _serverInfoForm.GetSslCaFileDialogFileName;
        }

        private void SslKeyDialogButton_Clicked(object sender, EventArgs e)
        {
            if (_serverInfoForm.ShowSslKeyFileDialog() == DialogResult.OK)
                _serverInfoForm.SslKeyLabelText = _serverInfoForm.GetSslKeyFileDialogFileName;
        }

        private void SslCertDialogButton_Clicked(object sender, EventArgs e)
        {
            if (_serverInfoForm.ShowSslCertFileDialog() == DialogResult.OK)
                _serverInfoForm.SslCertLabelText = _serverInfoForm.GetSslCertFileDialogFileName;
        }
        
        private IServerInfoForm _serverInfoForm;
        private IEdutrackMainForm _edutrackMainForm;
    }
}
