
using System;


namespace PresentationLayer.UserControls.AdminSubControls
{
    public interface IPersonalInfoControl
    {
        void ShowAddButton();
        void ShowUpdateButton();

        event EventHandler AddNewStudentInfoSubmit;
        event EventHandler UpdateStudentInfoSubmit;
    }
}
