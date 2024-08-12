using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.HomeSubControls
{
    public partial class ItrHomeRightControl : UserControl
    {
        public ItrHomeRightControl()
        {
            InitializeComponent();
            InitializeDataGridView();
        }


        private void InitializeDataGridView()
        {
            PersonalInfoTbl.Rows.Add("Row1 Col1", "Row1 Col2");
            PersonalInfoTbl.Rows.Add("Row2 Col1", "Row2 Col2");

            PersonalInfoTbl.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            PersonalInfoTbl.Columns[0].DividerWidth = 2;
            PersonalInfoTbl.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAEEFD");
            PersonalInfoTbl.Columns[1].DividerWidth = 2;
            PersonalInfoTbl.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            PersonalInfoTbl.SelectionChanged += (s, e) => PersonalInfoTbl.ClearSelection();
        }

    }
}
