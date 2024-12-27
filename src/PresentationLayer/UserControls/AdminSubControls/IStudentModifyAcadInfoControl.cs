using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.AdminSubControls
{
    internal interface IStudentModifyAcadInfoControl
    {
        event EventHandler ControlLoad;
        event EventHandler ExitButtonClicked;
        event EventHandler CloseEditorButtonClicked;
        event EventHandler FileDropDownButtonClicked;
        event EventHandler InstructorAcadInfoButtonClicked;
        event EventHandler StudentPersonalInfoButtonClicked;
        event EventHandler InstructorPersonalInfoButtonClicked;

        void ClearInfoTable();
        void DisposeControl();
        void TriggerInfoTableReload();

        object[] InfoTableRowData { set; }
        FlowLayoutPanel AccessFileDropDownLayout { get; }
    }
}
