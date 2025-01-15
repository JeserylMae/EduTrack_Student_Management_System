using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.AdminSubControls
{
    internal interface IProgramInfoFormControl
    {
        TextBox AccessProgramId             { get; }
        TextBox AccessProgramName           { get; }
        TextBox AccessDepartmentId          { get; } 
        TextBox AccessDepartmentName        { get; }
        IconButton AccessSubmitAddButton    { get; }
        IconButton AccessSubmitUpdateButton { get; }

        event EventHandler OnControlLoad; 
        event EventHandler CloseButtonClicked;
        event EventHandler SubmitAddButtonClicked;
        event EventHandler SubmitUpdateButtonClicked;
        event EventHandler CancelSubmitButtonClicked;
    }
}
