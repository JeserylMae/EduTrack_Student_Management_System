using PresentationLayer.Presenters.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.UserControls.HomeSubControls
{
    internal interface IStudItrHomeBottomControl
    {
        event EventHandler GradeButtonClicked;
        event EventHandler AttendanceButtonClicked;
        event EventHandler StudentInfoButtonClicked;

        AccessType AccessCurrentUser { get; set; }

        void DestroyControl();
    }
}
