﻿
using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.UserControls.MainControls
{
    public partial class AdminModifyInfoControl : UserControl, IAdminModifyInfoControl
    {
        public AdminModifyInfoControl()
        {
            InfoTableCreated            = new TaskCompletionSource<bool>();
            OpenAddFormButtonCreated    = new TaskCompletionSource<bool>();
            OpenUpdateFormButtonCreated = new TaskCompletionSource<bool>();

            InitializeComponent();
            InitializeInfoTable();
            OnInfoTableCreated();
            OnTopBarButtonsCreated();
            InitializeButtonSubscriber();
            InitializeControlSubscriber();
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
        public object[] InfoTableRowData 
        {
            set 
            { 
                InfoTable.Rows.Add(value);
                InfoTable.Rows[InfoTable.RowCount - 1].Height = 28;
            } 
        }
        public DataGridViewSelectedRowCollection SelectedRowCollection
        {
            get => InfoTable.SelectedRows;
        }
        public IPersonalInfoControl PersonalInfoControl { get; set; }

        public event EventHandler ControlLoad;
        public event EventHandler ViewAddForm;
        public event EventHandler ViewUpdateForm;
        public event EventHandler SelectedRowChanged;

        public void ClearInfoTable() { InfoTable.Rows.Clear(); InfoTable.Refresh(); }

        private UserControl _addedControl;
        private TaskCompletionSource<bool> InfoTableCreated;
        private TaskCompletionSource<bool> OpenAddFormButtonCreated;
        private TaskCompletionSource<bool> OpenUpdateFormButtonCreated;
    }
}
