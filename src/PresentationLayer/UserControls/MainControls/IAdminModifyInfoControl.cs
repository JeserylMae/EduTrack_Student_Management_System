
using System;
using System.Windows.Forms;


namespace PresentationLayer.UserControls.MainControls
{
    public interface IAdminModifyInfoControl
    {
        event EventHandler ControlLoad;
        event EventHandler ViewAddForm;
        event EventHandler ViewUpdateForm;

        void ClearInfoTable();
        object[] InfoTableRowData { set; }
        UserControl MainControlHolderControl { get; set; }
    }
}
