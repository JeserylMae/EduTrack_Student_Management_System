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
            serverInfo.UserId    = _serverInfoForm.GetServerUserId;
            serverInfo.Localhost = _serverInfoForm.GetServerServerName;
            serverInfo.Password  = _serverInfoForm.GetServerPassword;


            // Function that validates whether the connection string can
            // successfully send request to the web api.
            // return value: bool

            // Only run this function when the web api connection is
            // successful.
            RunEdutrackForm();
        }
        
        private IServerInfoForm _serverInfoForm;
        private IEdutrackMainForm _edutrackMainForm;
    }
}
