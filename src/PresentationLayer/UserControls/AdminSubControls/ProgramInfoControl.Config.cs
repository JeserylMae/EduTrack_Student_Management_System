using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.AdminSubControls
{
    partial class ProgramInfoControl
    {
        private void InitializedElementCreated()
        {
            if (FileDropDownLayout != null) FileDropDownLayoutCreated.TrySetResult(true);
            if (OpenAddFormButton != null) OpenAddFormButtonCreated.TrySetResult(true);
            if (OpenDropFormButton != null) OpenDropFormButtonCreated.TrySetResult(true);
            if (OpenModifyFormButton != null) OpenModifyFormButtonCreated.TrySetResult(true);
            if (SearchProgramIdButton != null) SearchProgramIdButtonCreated.TrySetResult(true);
            if (SearchProgramIdTextbox != null) SearchProgramIdTextBoxCraeted.TrySetResult(true);
        }

        private async Task InitializedButtonSubscriber()
        {
            await FileDropDownLayoutCreated.Task;
            ExitButton.Click += delegate { ExitButtonClicked?.Invoke(this, EventArgs.Empty); };
            CloseEditorButton.Click += delegate { CloseEditorButtonClicked?.Invoke(this, EventArgs.Empty); };
            ProgramInfoButton.Click += delegate { ProgramInfoButtonClicked?.Invoke(this, EventArgs.Empty); };
            FileDropDownButton.Click += delegate { FileDropDownButtonClicked?.Invoke(this, EventArgs.Empty); };
            InstructorAcadInfoButton.Click += delegate { InstructorAcadInfoButtonClicked?.Invoke(this, EventArgs.Empty); };
            StudentAcademicInfoButton.Click += delegate { StudentAcademicInfoButtonClicked?.Invoke(this, EventArgs.Empty); };
            StudentPersonalInfoButton.Click += delegate { StudentPersonalInfoButtonClicked?.Invoke(this, EventArgs.Empty); };
            InstructorPersonalInfoButton.Click += delegate { InstructorPersonalInfoButtonClicked?.Invoke(this, EventArgs.Empty); };

            await OpenAddFormButtonCreated.Task;
            OpenAddFormButton.Click += delegate { OpenAddFormButtonClicked?.Invoke(this, EventArgs.Empty); };

            await OpenDropFormButtonCreated.Task;
            OpenDropFormButton.Click += delegate { OpenDropFormButtonClicked?.Invoke(this, EventArgs.Empty); };

            await OpenModifyFormButtonCreated.Task;
            OpenModifyFormButton.Click += delegate { OpenModifyFormButtonClicked?.Invoke(this, EventArgs.Empty); };

            await SearchProgramIdButtonCreated.Task;
            SearchProgramIdButton.Click += delegate { SearchProgramIdButtonClicked?.Invoke(this, EventArgs.Empty); };

            await SearchProgramIdTextBoxCraeted.Task;
            SearchProgramIdTextbox.KeyDown += delegate (object sender, KeyEventArgs e) { SearchProgramIdTextboxPressed?.Invoke(sender, e); };

            this.Load += delegate { OnControlLoad?.Invoke(this, EventArgs.Empty); };
            InfoTable.SelectionChanged += delegate { SelectionChanged?.Invoke(this, EventArgs.Empty); };
        }

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
            InfoTable.Columns["ProgramName"].Width      = 800;
            InfoTable.Columns["DepartmentId"].Width     = 200;
            InfoTable.Columns["DepartmentName"].Width   = 800;
        }
    }
}
