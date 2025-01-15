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
        void InfoTableReload();

        TextBox AccessProgramId             { get; }
        TextBox AccessProgramName           { get; }
        TextBox AccessDepartmentId          { get; } 
        TextBox AccessDepartmentName        { get; }
        IconButton AccessSubmitAddButton    { get; }
        IconButton AccessSubmitUpdateButton { get; }

        IProgramInfoControl ProgramControl     { get; set; }
        FormRequestType AccessFormRequestType  { get; set; }

        event EventHandler OnControlLoad; 
        event EventHandler CloseButtonClicked;
        event EventHandler SubmitAddButtonClicked;
        event EventHandler InfoTableReloadTriggered;
        event EventHandler SubmitUpdateButtonClicked;
        event EventHandler CancelSubmitButtonClicked;
    }
}
