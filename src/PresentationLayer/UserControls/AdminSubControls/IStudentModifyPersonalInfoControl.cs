
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
        event EventHandler FileDropDownButtonClicked;
        event EventHandler StudAcadInfoButtonClicked;
        event EventHandler ItrPersonalInfoButtonClicked;

        void ClearInfoTable();
        void DisposeControl();
        void TriggerInfoTableReload();

        string SearchSrCodeText    { get; }
        object[] InfoTableRowData  { set; }

        DataGridViewRowCollection InfoTableRows  { get; }
        FlowLayoutPanel AccessFileDropDownLayout { get; }
        UserControl MainControlHolderControl     { get; set; }
        IStudentPersonalInfoControl PersonalInfoControl { get; set; }
        DataGridViewSelectedRowCollection SelectedRowCollection { get; }
    }
}
