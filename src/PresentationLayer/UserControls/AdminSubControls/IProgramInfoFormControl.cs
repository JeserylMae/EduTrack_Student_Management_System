using FontAwesome.Sharp;
using PresentationLayer.Presenters.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.AdminSubControls
{
    public interface IProgramInfoFormControl
    {
        void DisposeControl();

        TextBox AccessProgramId             { get; }
        TextBox AccessProgramName           { get; }
        TextBox AccessDepartmentId          { get; } 
        TextBox AccessDepartmentName        { get; }
        IconButton AccessSubmitAddButton    { get; }
        IconButton AccessSubmitUpdateButton { get; }

        FormRequestType AccessFormRequestType  { get; set; }
        IProgramInfoFormControl ProgramControl { get; set; }

        event EventHandler OnControlLoad; 
        event EventHandler CloseButtonClicked;
        event EventHandler SubmitAddButtonClicked;
        event EventHandler SubmitUpdateButtonClicked;
        event EventHandler CancelSubmitButtonClicked;
    }
}
