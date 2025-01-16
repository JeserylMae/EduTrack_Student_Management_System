using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.AdminSubControls
{
    public partial class ProgramInfoControl : UserControl, IProgramInfoControl
    {
        public ProgramInfoControl()
        {
            FileDropDownLayoutCreated = new TaskCompletionSource<bool>();
            OpenAddFormButtonCreated = new TaskCompletionSource<bool>();
            OpenDropFormButtonCreated = new TaskCompletionSource<bool>();
            OpenModifyFormButtonCreated = new TaskCompletionSource<bool>();
            SearchProgramIdButtonCreated = new TaskCompletionSource<bool>();
            SearchProgramIdTextBoxCraeted = new TaskCompletionSource<bool>();


            InitializeComponent();
            InitializeInfoTable();
            InitializedElementCreated();
            _ = InitializedButtonSubscriber();
        }


        public void DisposeControl() 
        { 
            this.Dispose(); 
        }

        public void ClearInfoTable()
        {
            if (InfoTable.Rows.Count <= 0) return;

            InfoTable.Rows.Clear();
            InfoTable.Refresh();
        }

        public void TriggerInfoTableReload()
        {
            OnControlLoad?.DynamicInvoke(this, EventArgs.Empty);
        }


        public object[] AccessInfoTableRowData 
        { 
            set
            {
                InfoTable.Rows.Add(value);
                InfoTable.Rows[InfoTable.RowCount - 1].Height = 28;
            } 
        }

        public DataGridView AccessInfoTable
        {
            get => InfoTable;
        }

        public TextBox AccessSearchProgramIdTextbox 
        {
            get => SearchProgramIdTextbox;
        }

        public FlowLayoutPanel AccessFileDropDownLayout
        {
            get => FileDropDownLayout;
        }

        public IProgramInfoFormControl ProgramControl 
        {
            get => _programControl;
            set
            {
                if (ProgramControl != null)
                    ProgramControl.DisposeControl();

                _programControl = value;
                UserControl control = (UserControl) value;

                MainControlHolder.Controls.Add(control);
                control.Dock = DockStyle.Left;   
            }
        }


        public event EventHandler OnControlLoad;
        public event EventHandler SelectionChanged;
        public event EventHandler ExitButtonClicked;
        public event EventHandler CloseEditorButtonClicked;
        public event EventHandler ProgramInfoButtonClicked;
        public event EventHandler OpenAddFormButtonClicked;
        public event EventHandler OpenDropFormButtonClicked;
        public event EventHandler FileDropDownButtonClicked;
        public event EventHandler OpenModifyFormButtonClicked;
        public event EventHandler SearchProgramIdButtonClicked;
        public event EventHandler InstructorAcadInfoButtonClicked;
        public event EventHandler StudentAcademicInfoButtonClicked;
        public event EventHandler StudentPersonalInfoButtonClicked;
        public event EventHandler InstructorPersonalInfoButtonClicked;
        public event KeyEventHandler SearchProgramIdTextboxPressed;


        private IProgramInfoFormControl _programControl;
        private TaskCompletionSource<bool> FileDropDownLayoutCreated;
        private TaskCompletionSource<bool> OpenAddFormButtonCreated;
        private TaskCompletionSource<bool> OpenDropFormButtonCreated;
        private TaskCompletionSource<bool> OpenModifyFormButtonCreated;
        private TaskCompletionSource<bool> SearchProgramIdButtonCreated;
        private TaskCompletionSource<bool> SearchProgramIdTextBoxCraeted;
    }
}
