using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PresentationLayer.UserControls.AdminSubControls
{
    internal interface IProgramInfoControl
    {
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
        event KeyboardEventHandler SearchProgramIdTextboxPressed;

        object[] AccessInfoTableRowData      { set; }
        DataGridView AccessInfoTable         { get; }
        TextBox AccessSearchProgramIdTextbox { get; }
    }
}
