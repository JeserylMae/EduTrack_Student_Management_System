using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.UserControls
{
    public interface ILogInPage
    {
        string GetEmailAddress { get; }
        string GetPassword { get; }
        event EventHandler LoggedIn;
    }
}
