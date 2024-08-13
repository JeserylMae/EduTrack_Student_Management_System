

using System;

namespace PresentationLayer.UserControls.HomeSubControls
{
    internal interface IAdminHomeRightControl
    {
        void DestroyControl();
        event EventHandler CourseInfoButtonClicked;
        event EventHandler ItrAcadInfoButtonClicked;
        event EventHandler StudAcadInfoButtonClicked;
        event EventHandler ItrPersonalInfoButtonClicked;
        event EventHandler StudPersonalInfoButtonClicked;
    }
}
