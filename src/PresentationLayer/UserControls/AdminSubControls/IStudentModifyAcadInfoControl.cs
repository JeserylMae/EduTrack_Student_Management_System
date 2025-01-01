using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.MainControls
{
    public interface IStudentModifyAcadInfoControl
    {
        event EventHandler ControlLoad;
        event EventHandler ExitButtonClicked;
        event EventHandler CloseEditorButtonClicked;
        event EventHandler OpenAddFormButtonClicked;
        event EventHandler OpenDropFormButtonClicked;
        event EventHandler SearchSrCodeButtonClicked;
        event EventHandler FileDropDownButtonClicked;
        event EventHandler InfoTableSelectionChanged;
        event EventHandler OpenModifyFormButtonClicked;
        event EventHandler InstructorAcadInfoButtonClicked;
        event EventHandler StudentPersonalInfoButtonClicked;
        event EventHandler InstructorPersonalInfoButtonClicked;
        event KeyEventHandler SearchSrCodeTextboxPressed;


        void ClearInfoTable();
        void DisposeControl();
        void TriggerInfoTableReload();

        object[] InfoTableRowData                { set; }
        DataGridView AccessInfoTable             { get; }
        TextBox AccessSearchSrCodeTextbox        { get; }
        FlowLayoutPanel AccessFileDropDownLayout { get; }
        IStudentAcadInfoControl CurrentUserControl           { get; set; }
    }
}
