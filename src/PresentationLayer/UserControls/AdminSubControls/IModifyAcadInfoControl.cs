using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.MainControls
{
    public interface IModifyAcadInfoControl
    {
        event EventHandler ControlLoad;
        event EventHandler ExitButtonClicked;
        event EventHandler CloseEditorButtonClicked;
        event EventHandler OpenAddFormButtonClicked;
        event EventHandler ProgramInfoButtonClicked;
        event EventHandler OpenDropFormButtonClicked;
        event EventHandler FileDropDownButtonClicked;
        event EventHandler InfoTableSelectionChanged;
        event EventHandler FilterEditorButtonClicked;
        event EventHandler SearchUsrCodeButtonClicked;
        event EventHandler OpenModifyFormButtonClicked;
        event EventHandler InstructorAcadInfoButtonClicked;
        event EventHandler StudentPersonalInfoButtonClicked;
        event EventHandler StudentAcademicInfoButtonClicked;
        event EventHandler InstructorPersonalInfoButtonClicked;
        event KeyEventHandler SearchUsrCodeTextboxPressed;


        void ClearInfoTable();
        void DisposeControl();
        void TriggerInfoTableReload();


        AccessType ModifyUser                       { get; set; }
        UserControl AccessFilterEditor              { get; set; }
        IAcademicInfoControl CurrentUserControl     { get; set; }


        object[] InfoTableRowData                              { set; }
        Label AccessPageLabel                                  { get; }
        DataGridView AccessInfoTable                           { get; }
        TextBox AccessSearchUsrCodeTextbox                     { get; }
        FlowLayoutPanel AccessFileDropDownLayout               { get; }
        FontAwesome.Sharp.IconButton AccessSearchUsrCodeButton { get; }
    }
}
