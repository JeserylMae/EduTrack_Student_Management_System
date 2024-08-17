
using System;

namespace PresentationLayer.UserControls.MainControls
{
    public interface ILogInPage
    {
        string GetUserId       { get; }
        string GetPassword     { get; }
        string GetEmailAddress { get; }

        void DisposeForm();
        event EventHandler LoggedIn;
    }
}
