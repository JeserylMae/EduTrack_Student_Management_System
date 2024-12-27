using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.MainControls
{
    public partial class StudentModifyAcadInfoControl : UserControl, IStudentModifyAcadInfoControl
    {
        public StudentModifyAcadInfoControl()
        {
            InfoTableCreated          = new TaskCompletionSource<bool>();
            FileDropDownButtonCreated = new TaskCompletionSource<bool>();
            FileDropDownLayoutCreated = new TaskCompletionSource<bool>();
          
            InitializeComponent();
            InitializeInfoTable();
            InvokeElementCreated();
            _ = InitializeEventSubscribers();
        }


        public object[] InfoTableRowData 
        { 
            set
            {
                InfoTable.Rows.Add(value);
                InfoTable.Rows[InfoTable.Rows.Count - 1].Height = 28;
            }
        }
        public FlowLayoutPanel AccessFileDropDownLayout 
        { 
            get => FileDropDownLayout; 
        }
        public UserControl AddUserControlToMainControl
        {
            get { return _addedUserControl; }
            set
            {
                _addedUserControl = value;
                MainControlHolder.Controls.Add(_addedUserControl);
                _addedUserControl.Dock = DockStyle.Left;
            }
        }

        public void ClearInfoTable()
        {
            InfoTable.Rows.Clear();
            InfoTable.Refresh();
        }
        public void DisposeControl() { 
            this.Dispose(); 
        }
        public void TriggerInfoTableReload()
        {
            throw new NotImplementedException();
        }


        public event EventHandler ControlLoad;
        public event EventHandler ExitButtonClicked;
        public event EventHandler CloseEditorButtonClicked;
        public event EventHandler FileDropDownButtonClicked;
        public event EventHandler InstructorAcadInfoButtonClicked;
        public event EventHandler StudentPersonalInfoButtonClicked;
        public event EventHandler InstructorPersonalInfoButtonClicked;


        private UserControl _addedUserControl;
        private TaskCompletionSource<bool> InfoTableCreated;
        private TaskCompletionSource<bool> FileDropDownButtonCreated;
        private TaskCompletionSource<bool> FileDropDownLayoutCreated;
    }
}
