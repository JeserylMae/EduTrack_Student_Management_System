using System;
using System.Activities;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.MainControls
{
    partial class ModifyAcadInfoControl
    {
        private void InvokeElementCreated()
        {
            if (InfoTable != null) InfoTableCreated.TrySetResult(true);
            if (OpenAddFormButton != null)    OpenAddFormButtonCreated.TrySetResult(true);
            if (FileDropDownButton != null)   FileDropDownButtonCreated.TrySetResult(true);
            if (FileDropDownLayout != null)   FileDropDownLayoutCreated.TrySetResult(true);
            if (OpenDropFormButton != null)   OpenDropFormButtonCreated.TrySetResult(true);
            if (SearchUsrCodeButton != null)   SearchSrCodeButtonCreated.TrySetResult(true);
            if (SearchUsrCodeTextbox != null)  SearchUsrCodeTextboxCreated.TrySetResult(true);
            if (OpenModifyFormButton != null) OpenModifyFormButtonCreated.TrySetResult(true);
        }

        private async Task InitializeEventSubscribers()
        {
            await InfoTableCreated.Task;
            this.Load += delegate { ControlLoad?.Invoke(this, EventArgs.Empty); };
            InfoTable.SelectionChanged += delegate { InfoTableSelectionChanged?.Invoke(this, EventArgs.Empty); };

            await FileDropDownButtonCreated.Task;
            FileDropDownButton.Click += delegate { FileDropDownButtonClicked?.Invoke(this, EventArgs.Empty); };

            await FileDropDownLayoutCreated.Task;
            ExitButton.Click                   += delegate { ExitButtonClicked?.Invoke(this, EventArgs.Empty); };
            CloseEditorButton.Click            += delegate { CloseEditorButtonClicked?.Invoke(this, EventArgs.Empty); };
            FilterEditorButton.Click           += delegate { FilterEditorButtonClicked?.Invoke(this, EventArgs.Empty); };
            InstructorAcadInfoButton.Click     += delegate { InstructorAcadInfoButtonClicked?.Invoke(this, EventArgs.Empty); };
            StudentPersonalInfoButton.Click    += delegate { StudentPersonalInfoButtonClicked?.Invoke(this, EventArgs.Empty); };
            StudentAcademicInfoButton.Click    += delegate { StudentAcademicInfoButtonClicked?.Invoke(this, EventArgs.Empty); };
            InstructorPersonalInfoButton.Click += delegate { InstructorPersonalInfoButtonClicked?.Invoke(this, EventArgs.Empty); };

            await OpenAddFormButtonCreated.Task;
            OpenAddFormButton.Click += delegate { OpenAddFormButtonClicked?.Invoke(this, EventArgs.Empty); };

            await OpenDropFormButtonCreated.Task;
            OpenDropFormButton.Click += delegate { OpenDropFormButtonClicked?.Invoke(this, EventArgs.Empty); };

            await OpenModifyFormButtonCreated.Task;
            OpenModifyFormButton.Click += delegate { OpenModifyFormButtonClicked?.Invoke(this, EventArgs.Empty); };

            await SearchSrCodeButtonCreated.Task;
            SearchUsrCodeButton.Click += delegate { SearchUsrCodeButtonClicked?.Invoke(this, EventArgs.Empty); };

            await SearchUsrCodeTextboxCreated.Task;
            SearchUsrCodeTextbox.KeyDown += delegate (object sender, KeyEventArgs e) { SearchUsrCodeTextboxPressed?.Invoke(sender, e); };
        }

        private void InitializeInfoTable()
        {
            InfoTable.ScrollBars            = ScrollBars.Both;
            InfoTable.BackgroundColor       = ColorTranslator.FromHtml("#FAEEFD");
            InfoTable.AutoSizeRowsMode      = DataGridViewAutoSizeRowsMode.None;
            InfoTable.AutoSizeColumnsMode   = DataGridViewAutoSizeColumnsMode.None;

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
            InfoTable.Columns["SrCode"].Width           = 180;
            InfoTable.Columns["InstructorCode"].Width   = 180;
            InfoTable.Columns["LastName"].Width         = 200;
            InfoTable.Columns["FirstName"].Width        = 200;
            InfoTable.Columns["MiddleName"].Width       = 200;
            InfoTable.Columns["Course"].Width           = 200;
            InfoTable.Columns["Section"].Width          = 200;
            InfoTable.Columns["Semester"].Width         = 200;
            InfoTable.Columns["YearLevel"].Width        = 200;
            InfoTable.Columns["AcademicYear"].Width     = 250;
            InfoTable.Columns["Program"].Width          = 520;
        }
    }
}
