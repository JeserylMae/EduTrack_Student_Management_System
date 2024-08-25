
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
        event EventHandler SelectedRowChanged;

        void ClearInfoTable();
        object[] InfoTableRowData { set; }
        UserControl MainControlHolderControl { get; set; }
        IPersonalInfoControl PersonalInfoControl { get; set; }
        DataGridViewSelectedRowCollection SelectedRowCollection { get; }
    }
}
