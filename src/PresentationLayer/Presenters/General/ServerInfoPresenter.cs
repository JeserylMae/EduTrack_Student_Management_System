using DomainLayer.WebModels;
using PresentationLayer.Views;
using ServiceLayer.ConsoleServices;
using ServiceLayer.Database;
using ServiceLayer.Services;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Presenters.General
{
    internal class ServerInfoPresenter
    {
        public ServerInfoPresenter(IServerInfoForm serverInfoForm, IEdutrackMainForm edutrackMainForm,
                                   SplashScreen splashScreen, AppSettings settings) 
        { 
            _settings = settings;
            _splashScreen = splashScreen;
            _serverInfoForm = serverInfoForm;
            _edutrackMainForm = edutrackMainForm;
            _cmdConn = _settings.GetConsoleConnection();

            _serverInfoForm.WindowExit             += ExitAppButton_Clicked;
            _serverInfoForm.SubmittedServerInfo    += ServerInfoButton_Clicked;
            _serverInfoForm.SslCaButtonClicked     += SslCaDialogButton_Clicked;
            _serverInfoForm.SslKeyButtonClicked    += SslKeyDialogButton_Clicked;
            _serverInfoForm.SslCertButtonClicked   += SslCertDialogButton_Clicked;
            
            GeneralPresenter.WindowExitSubscriber += ExitAppButton_Clicked;
        }

        #region Button Subcribers

        private void ExitAppButton_Clicked(object sender, EventArgs e)
        {
            _settings.DestroyWebAPIConnection(ref _cmdProcess, ref _cmdConn);
            Application.Exit();
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

        private async void ServerInfoButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                ServerInfoModel serverInfo = new ServerInfoModel();
                AssignServerInfoFields(ref serverInfo);

                string connectionString = DatabaseConnection.GenerateConnectionString(ref serverInfo);
                _cmdProcess = await InitializeWebAPI(connectionString);

                RunEdutrackForm();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Helper Methods

        private void RunEdutrackForm()
        {
            _serverInfoForm.CloseForm();
            _edutrackMainForm.FormWindowState = FormWindowState.Normal;
        }

        private void AssignServerInfoFields(ref ServerInfoModel serverInfo)
        {
            serverInfo.UserId = _serverInfoForm.GetServerUserId;
            serverInfo.Localhost = _serverInfoForm.GetServerServerName;
            serverInfo.Password = _serverInfoForm.GetServerPassword;
            serverInfo.SslCaPath = _serverInfoForm.SslCaLabelText;
            serverInfo.SslKeyPath = _serverInfoForm.SslKeyLabelText;
            serverInfo.SslCertPath = _serverInfoForm.SslCertLabelText;
        }

        private async Task<Process> InitializeWebAPI(string connectionString)
        {
            if (_cmdConn != null)
            {
                DisplaySplashForm();

                EndpointAuthentication authentication = new EndpointAuthentication();
                Process cmdProcess = _cmdConn.ExecuteWebAPI(connectionString);
                                
                int attempts = await authentication.CheckWebConnection();
                authentication.EvaluateWebConnection(attempts);
                
                _splashScreen.CloseForm();

                return cmdProcess;
            }
            else return null;
        }

        private void DisplaySplashForm()
        {
            Size parentSize = _serverInfoForm.GetSize;
            Point parentLocation = _serverInfoForm.GetLocation;
            _splashScreen.SetFormLocation(parentLocation, parentSize);
            _splashScreen.ShowForm();
        }

        #endregion

        private Process _cmdProcess;
        private AppSettings _settings;
        private ConsoleConnection _cmdConn;
        private SplashScreen _splashScreen;
        private IServerInfoForm _serverInfoForm;
        private IEdutrackMainForm _edutrackMainForm;
    }
}
