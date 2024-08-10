using System;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public interface IServerInfoForm
    {
        void ShowForm();
        void CloseForm();
        void ShowSslCaFileDialog();
        void ShowSslKeyFileDialog();
        void ShowSslCertFileDialog();

        string GetServerUserId      { get; }
        string GetServerPassword    { get; }
        string GetServerServerName  { get; }
        string SetSslCaLabelText    { set; }
        string SetSslKeyLabelText   { set; }
        string SetSslCertLabelText  { set; }
        string SetFileDialogInitDir { set; }
        string GetSslCaFileDialogFileName   { get; }
        string GetSslKeyFileDialogFileName  { get; }
        string GetSslCertFileDialogFileName { get; }

        event EventHandler WindowExit;
        event EventHandler SslCaButtonClicked;
        event EventHandler SslKeyButtonClicked;
        event EventHandler SubmittedServerInfo;
        event EventHandler SslCertButtonClicked;
    }
}