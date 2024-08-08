using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
