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
            InitializeComponent();
            InitializeInfoTable();
            InitializeEventSubscribers();

            InfoTableCreated = new TaskCompletionSource<bool>();
        }


        public object[] InfoTableRowData 
        { 
            set
            {
                InfoTable.Rows.Add(value);
                InfoTable.Rows[InfoTable.Rows.Count - 1].Height = 28;
            }
        }

        public void ClearInfoTable()
        {
            InfoTable.Rows.Clear();
            InfoTable.Refresh();
        }

        public void TriggerInfoTableReload()
        {
            throw new NotImplementedException();
        }


        public event EventHandler ControlLoad;


        private TaskCompletionSource<bool> InfoTableCreated;
    }
}
