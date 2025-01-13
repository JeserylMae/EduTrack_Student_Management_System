using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PresentationLayer.UserControls.AdminSubControls
{
    public partial class ProgramInfoControl : UserControl, IProgramInfoControl
    {
        public ProgramInfoControl()
        {
            InitializeComponent();
        }


        public void DisposeControl() 
        { 
            this.Dispose(); 
        }

        public void TriggerInfoTableReload()
        {
            OnControlLoad?.Invoke(this, EventArgs.Empty);
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


        public event EventHandler OnControlLoad;
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
        public event KeyboardEventHandler SearchProgramIdTextboxPressed;
    }
}
