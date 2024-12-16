
using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace PresentationLayer.UserControls.MainControls
{
    public interface IAdminModifyInfoControl
    {
        event EventHandler ControlLoad;
        event EventHandler ViewAddForm;
        event EventHandler ViewUpdateForm;
        event EventHandler DeleteSelectedRow;
        event EventHandler SelectedRowChanged;
        event EventHandler SearchButtonClicked;
        event KeyEventHandler SearchTextBoxKeyDown;

        void ClearInfoTable();
        void TriggerInfoTableReload();

        string SearchSrCodeText    { get; }
        object[] InfoTableRowData  { set; }

        DataGridViewRowCollection InfoTableRows  { get; }
        UserControl MainControlHolderControl     { get; set; }
        IPersonalInfoControl PersonalInfoControl { get; set; }
        DataGridViewSelectedRowCollection SelectedRowCollection { get; }
    }
}
