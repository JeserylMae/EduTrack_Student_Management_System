using DomainLayer.DataModels;
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
    public interface IStudentAcadInfoControl
    {
        void DisposeControl();

        event EventHandler ControlLoad;
        event EventHandler CloseButtonClicked;

        UserControl CurrentControl          { get; }
        TextBox AccessLastNameTextBox       { get; }
        TextBox AccessFirstNameTextBox      { get; }
        TextBox AccessMiddleNameTextBox     { get; }
        IconButton AccessSubmitAddButton    { get; }
        IconButton AccessSubmitUpdateButton { get; }

        FormRequestType CurrentRequestType { get; set; }
    }
}
