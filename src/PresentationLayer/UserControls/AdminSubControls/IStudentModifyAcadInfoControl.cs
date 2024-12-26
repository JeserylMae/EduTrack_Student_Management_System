using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.UserControls.AdminSubControls
{
    internal interface IStudentModifyAcadInfoControl
    {
        event EventHandler ControlLoad;

        void ClearInfoTable();
        void TriggerInfoTableReload();

        object[] InfoTableRowData { set; }
    }
}
