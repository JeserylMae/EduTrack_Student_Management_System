
using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace PresentationLayer.UserControls.AdminSubControls
{
    public interface IModifyPersonalInfoControl
    {
        event EventHandler ControlLoad;
        event EventHandler ViewAddForm;
        event EventHandler ViewUpdateForm;
        event EventHandler DeleteSelectedRow;
        event EventHandler ExitButtonClicked;
        event EventHandler SelectedRowChanged;
        event EventHandler SearchButtonClicked;
        event KeyEventHandler SearchTextBoxKeyDown;
        event EventHandler CloseEditorButtonClicked;
        event EventHandler ItrAcadInfoButtonClicked;
        event EventHandler ProgramInfoButtonClicked;
        event EventHandler FileDropDownButtonClicked;
        event EventHandler StudAcadInfoButtonClicked;
        event EventHandler ItrPersonalInfoButtonClicked;
        event EventHandler StudPersonalInfoButtonClicked;

        void ClearInfoTable();
        void DisposeControl();
        void TriggerInfoTableReload();

        string SearchUsrCodeText { get; }
        object[] InfoTableRowData  { set; }

        Label AccessPageLabel                    { get; }
        DataGridView AccessInfoTable             { get; }
        DataGridViewRowCollection InfoTableRows  { get; }
        FlowLayoutPanel AccessFileDropDownLayout { get; }

        AccessType ModifyUser                    { get; set; }
        UserControl MainControlHolderControl     { get; set; }
        IPersonalInfoControl PersonalInfoControl { get; set; }

        FontAwesome.Sharp.IconButton AccessSearchUsrCodeButton  { get; }
        DataGridViewSelectedRowCollection SelectedRowCollection { get; }
    }
}
