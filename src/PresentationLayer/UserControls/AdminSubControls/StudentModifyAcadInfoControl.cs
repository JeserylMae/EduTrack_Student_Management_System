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
            InfoTableCreated            = new TaskCompletionSource<bool>();
            OpenAddFormButtonCreated    = new TaskCompletionSource<bool>();
            FileDropDownButtonCreated   = new TaskCompletionSource<bool>();
            FileDropDownLayoutCreated   = new TaskCompletionSource<bool>();
            OpenDropFormButtonCreated   = new TaskCompletionSource<bool>();
            OpenModifyFormButtonCreated = new TaskCompletionSource<bool>();
            SearchSrCodeButtonCreated   = new TaskCompletionSource<bool>();
            SearchSrCodeTextboxCreated  = new TaskCompletionSource<bool>();


            InitializeComponent();
            InitializeInfoTable();
            InvokeElementCreated();
            _ = InitializeEventSubscribers();
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
            ControlLoad?.Invoke(this, EventArgs.Empty);
        }


        public object[] InfoTableRowData 
        { 
            set
            {
                InfoTable.Rows.Add(value);
                InfoTable.Rows[InfoTable.Rows.Count - 1].Height = 28;
            }
        }
        public IStudentAcadInfoControl CurrentUserControl
        {
            get { return (IStudentAcadInfoControl)_addedUserControl; }
            set
            {
                _addedUserControl = (UserControl)value;
                MainControlHolder.Controls.Add(_addedUserControl);
                _addedUserControl.Dock = DockStyle.Left;
            }
        }
        public UserControl AccessFilterEditor
        {
            get => _filterControl;
            set
            {
                _filterControl = value;

                if (value != null)
                {
                    MainControlHolder.Controls.Add(_filterControl);
                    _filterControl.Dock = DockStyle.Top;
                }
            }                   
        }

        public DataGridView AccessInfoTable             { get => InfoTable;           }
        public TextBox AccessSearchSrCodeTextbox        { get => SearchSrCodeTextbox; }
        public FlowLayoutPanel AccessFileDropDownLayout { get => FileDropDownLayout;  }

        public event EventHandler ControlLoad;
        public event EventHandler ExitButtonClicked;
        public event EventHandler CloseEditorButtonClicked;
        public event EventHandler OpenAddFormButtonClicked;
        public event EventHandler FileDropDownButtonClicked;
        public event EventHandler OpenDropFormButtonClicked;
        public event EventHandler SearchSrCodeButtonClicked;
        public event EventHandler InfoTableSelectionChanged;
        public event EventHandler FilterEditorButtonClicked;
        public event EventHandler OpenModifyFormButtonClicked;
        public event EventHandler InstructorAcadInfoButtonClicked;
        public event EventHandler StudentPersonalInfoButtonClicked;
        public event EventHandler InstructorPersonalInfoButtonClicked;
        public event KeyEventHandler SearchSrCodeTextboxPressed;


        private UserControl _filterControl;
        private UserControl _addedUserControl;
        private TaskCompletionSource<bool> InfoTableCreated;
        private TaskCompletionSource<bool> OpenAddFormButtonCreated;
        private TaskCompletionSource<bool> OpenDropFormButtonCreated;
        private TaskCompletionSource<bool> FileDropDownButtonCreated;
        private TaskCompletionSource<bool> FileDropDownLayoutCreated;
        private TaskCompletionSource<bool> SearchSrCodeButtonCreated;
        private TaskCompletionSource<bool> SearchSrCodeTextboxCreated;
        private TaskCompletionSource<bool> OpenModifyFormButtonCreated;
    }
}
