﻿
using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.UserControls.AdminSubControls
{
    public partial class ModifyPersonalInfoControl : UserControl, IModifyPersonalInfoControl
    {
        public ModifyPersonalInfoControl()
        {
            InfoTableCreated               = new TaskCompletionSource<bool>();
            SearchButtonCreated            = new TaskCompletionSource<bool>();
            SearchTextBoxCreated           = new TaskCompletionSource<bool>();
            OpenAddFormButtonCreated       = new TaskCompletionSource<bool>();
            FileDropDownButtonCreated      = new TaskCompletionSource<bool>();
            FileDropDownLayoutCreated      = new TaskCompletionSource<bool>();
            OpenUpdateFormButtonCreated    = new TaskCompletionSource<bool>();
            DeleteSelectedRowButtonCreated = new TaskCompletionSource<bool>();

            InitializeComponent();
            InitializeInfoTable();
            OnInfoTableCreated();
            OnTopBarButtonsCreated();
            InitializeButtonSubscriber();
            InitializeControlSubscriber();
        }


        public object[] InfoTableRowData 
        {
            set 
            { 
                InfoTable.Rows.Add(value);
                InfoTable.Rows[InfoTable.RowCount - 1].Height = 28;
            } 
        }
        public UserControl MainControlHolderControl
        {
            get { return _addedControl; }
            set 
            { 
                _addedControl = value;
                MainControlHolder.Controls.Add(_addedControl);
                _addedControl.Dock = DockStyle.Left;
            }
        }

        public AccessType ModifyUser                                   { get; set;                        }
        public IPersonalInfoControl PersonalInfoControl                { get; set;                        }

        public Label AccessPageLabel                                   { get => PageLabel;                }
        public DataGridView AccessInfoTable                            { get => InfoTable;                }
        public string SearchUsrCodeText                                { get => SearchUsrCodeTextbox.Text;}
        public DataGridViewRowCollection InfoTableRows                 { get => InfoTable.Rows;           }
        public FlowLayoutPanel AccessFileDropDownLayout                { get => FileDropDownLayout;       }
        public FontAwesome.Sharp.IconButton AccessSearchUsrCodeButton  { get => SearchUsrCodeButton;      }
        public DataGridViewSelectedRowCollection SelectedRowCollection { get => InfoTable.SelectedRows;   }


        public void ClearInfoTable() 
        { 
            InfoTable.Rows.Clear(); 
            InfoTable.Refresh(); 
        }
        public void DisposeControl() { this.Dispose(); }
        public void TriggerInfoTableReload() { ControlLoad?.Invoke(this, EventArgs.Empty); }


        public event EventHandler ControlLoad;
        public event EventHandler ViewAddForm;
        public event EventHandler ViewUpdateForm;
        public event EventHandler ExitButtonClicked;
        public event EventHandler DeleteSelectedRow;
        public event EventHandler SelectedRowChanged;
        public event EventHandler SearchButtonClicked;
        public event KeyEventHandler SearchTextBoxKeyDown;
        public event EventHandler CloseEditorButtonClicked;
        public event EventHandler ItrAcadInfoButtonClicked;
        public event EventHandler ProgramInfoButtonClicked;
        public event EventHandler FileDropDownButtonClicked;
        public event EventHandler StudAcadInfoButtonClicked;
        public event EventHandler ItrPersonalInfoButtonClicked;
        public event EventHandler StudPersonalInfoButtonClicked;


        private UserControl _addedControl;
        private TaskCompletionSource<bool> InfoTableCreated;
        private TaskCompletionSource<bool> SearchButtonCreated;
        private TaskCompletionSource<bool> SearchTextBoxCreated;
        private TaskCompletionSource<bool> OpenAddFormButtonCreated;
        private TaskCompletionSource<bool> FileDropDownButtonCreated;
        private TaskCompletionSource<bool> FileDropDownLayoutCreated;
        private TaskCompletionSource<bool> OpenUpdateFormButtonCreated;
        private TaskCompletionSource<bool> DeleteSelectedRowButtonCreated;
    }
}
