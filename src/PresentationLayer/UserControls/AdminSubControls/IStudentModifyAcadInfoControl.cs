using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.AdminSubControls
{
    internal interface IStudentModifyAcadInfoControl
    {
        event EventHandler ControlLoad;
        event EventHandler ExitButtonClicked;
        event EventHandler CloseEditorButtonClicked;
        event EventHandler OpenAddFormButtonClicked;
        event EventHandler OpenDropFormButtonClicked;
        event EventHandler SearchSrCodeButtonClicked;
        event EventHandler FileDropDownButtonClicked;
        event EventHandler OpenModifyFormButtonClicked;
        event EventHandler InstructorAcadInfoButtonClicked;
        event EventHandler StudentPersonalInfoButtonClicked;
        event EventHandler InstructorPersonalInfoButtonClicked;
        event KeyEventHandler SearchSrCodeTextboxPressed;
        

        void ClearInfoTable();
        void DisposeControl();
        void TriggerInfoTableReload();

        object[] InfoTableRowData { set; }
        TextBox AccessSearchSrCodeTextbox        { get; }
        FlowLayoutPanel AccessFileDropDownLayout { get; }
        UserControl AddUserControlToMainControl { get; set; }
    }
}
