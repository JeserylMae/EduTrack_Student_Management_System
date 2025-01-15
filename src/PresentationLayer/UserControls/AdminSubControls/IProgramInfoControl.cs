using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.AdminSubControls
{
    public interface IProgramInfoControl
    {
        void DisposeControl();
        void TriggerInfoTableReload();


        object[] AccessInfoTableRowData             { set; }
        DataGridView AccessInfoTable                { get; }
        TextBox AccessSearchProgramIdTextbox        { get; }
        FlowLayoutPanel AccessFileDropDownLayout    { get; }


        event EventHandler OnControlLoad;
        event EventHandler ExitButtonClicked;
        event EventHandler CloseEditorButtonClicked;
        event EventHandler ProgramInfoButtonClicked;
        event EventHandler OpenAddFormButtonClicked;
        event EventHandler OpenDropFormButtonClicked;
        event EventHandler FileDropDownButtonClicked;
        event EventHandler OpenModifyFormButtonClicked;
        event EventHandler SearchProgramIdButtonClicked;
        event EventHandler InstructorAcadInfoButtonClicked;
        event EventHandler StudentAcademicInfoButtonClicked;
        event EventHandler StudentPersonalInfoButtonClicked;
        event EventHandler InstructorPersonalInfoButtonClicked;
        event KeyEventHandler SearchProgramIdTextboxPressed;
    }
}
