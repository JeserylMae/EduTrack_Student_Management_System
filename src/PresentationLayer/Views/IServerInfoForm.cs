
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public interface IServerInfoForm
    {
        void ShowForm();
        void CloseForm();
        DialogResult ShowSslCaFileDialog();
        DialogResult ShowSslKeyFileDialog();
        DialogResult ShowSslCertFileDialog();

        Size GetSize                { get; }
        Point GetLocation           { get; }
        string GetServerUserId      { get; }
        string GetServerPassword    { get; }
        string GetServerServerName  { get; }
        string SetFileDialogInitDir { set; }
        string SslCaLabelText       { get; set; }
        string SslKeyLabelText      { get; set; }
        string SslCertLabelText     { get; set; }
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