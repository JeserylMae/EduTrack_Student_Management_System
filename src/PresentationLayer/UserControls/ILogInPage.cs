
using System;

namespace PresentationLayer.UserControls
{
    public interface ILogInPage
    {
        string GetUserId       { get; }
        string GetPassword     { get; }
        string GetEmailAddress { get; }

        event EventHandler LoggedIn;
    }
}
