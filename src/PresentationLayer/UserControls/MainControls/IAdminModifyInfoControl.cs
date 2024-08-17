
using System;
using System.Windows.Forms;


namespace PresentationLayer.UserControls.MainControls
{
    public interface IAdminModifyInfoControl
    {
        event EventHandler ViewAddForm;
        event EventHandler ViewUpdateForm;

        UserControl MainControlHolderControl { get; set; }
    }
}
