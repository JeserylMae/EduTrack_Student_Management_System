﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.AdminSubControls
{
    partial class ProgramInfoControl
    {
        private void InitializeInfoTable()
        {
            InfoTable.ScrollBars = ScrollBars.Both;
            InfoTable.BackgroundColor = ColorTranslator.FromHtml("#FAEEFD");
            InfoTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            InfoTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            ModifyDataGridViewColumnStyle();
            ModifyDataGridViewColumnWidth();
            ModifyDataGridViewColumnHeaderStyle();
        }

        private void ModifyDataGridViewColumnStyle()
        {
            InfoTable.DefaultCellStyle.ForeColor            = Color.Black;
            InfoTable.DefaultCellStyle.SelectionForeColor   = Color.White;
            InfoTable.DefaultCellStyle.Padding              = new Padding(3);
            InfoTable.GridColor                             = ColorTranslator.FromHtml("#FAEEFD");
            InfoTable.DefaultCellStyle.BackColor            = ColorTranslator.FromHtml("#FAEEFD");
            InfoTable.DefaultCellStyle.SelectionBackColor   = ColorTranslator.FromHtml("#58048C");
            InfoTable.DefaultCellStyle.Alignment            = DataGridViewContentAlignment.MiddleLeft;
            InfoTable.DefaultCellStyle.Font                 = new System.Drawing.Font("Candara", 12F, FontStyle.Regular,
                                                                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void ModifyDataGridViewColumnHeaderStyle()
        {
            InfoTable.EnableHeadersVisualStyles                         = false;
            InfoTable.ColumnHeadersDefaultCellStyle.ForeColor           = Color.Black;
            InfoTable.ColumnHeadersDefaultCellStyle.SelectionForeColor  = Color.Black;
            InfoTable.ColumnHeadersDefaultCellStyle.Padding             = new Padding(5);
            InfoTable.ColumnHeadersDefaultCellStyle.BackColor           = ColorTranslator.FromHtml("#D68BAC");
            InfoTable.ColumnHeadersDefaultCellStyle.SelectionBackColor  = ColorTranslator.FromHtml("#D68BAC");
            InfoTable.ColumnHeadersDefaultCellStyle.Alignment           = DataGridViewContentAlignment.MiddleCenter;
            InfoTable.ColumnHeadersDefaultCellStyle.Font                = new System.Drawing.Font("Candara", 12F, FontStyle.Bold,
                                                                             System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void ModifyDataGridViewColumnWidth()
        {
            InfoTable.Columns["ProgramId"].Width        = 200;
            InfoTable.Columns["ProgramName"].Width      = 400;
            InfoTable.Columns["DepartmentId"].Width     = 200;
            InfoTable.Columns["DepartmentName"].Width   = 400;
        }
    }
}
