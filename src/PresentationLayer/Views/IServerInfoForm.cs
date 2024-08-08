using System;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public interface IServerInfoForm
    {
        void ShowForm();
        void CloseForm();

        string GetServerUserId     { get; }
        string GetServerPassword   { get; }
        string GetServerServerName { get; }

        event EventHandler WindowExit;
        event EventHandler SubmittedServerInfo;
    }
}