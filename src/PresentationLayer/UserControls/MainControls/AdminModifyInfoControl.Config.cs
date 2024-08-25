
using System;
using System.Drawing;
using System.Windows.Forms;


namespace PresentationLayer.UserControls.MainControls
{
    partial class AdminModifyInfoControl
    {
        private void OnTopBarButtonsCreated()
        {
            if (OpenAddFormButton != null) { OpenAddFormButtonCreated.TrySetResult(true); }
            if (OpenModifyFormButton != null) { OpenUpdateFormButtonCreated.TrySetResult(true); }
        }

        private void OnInfoTableCreated()
        {
            if (InfoTable != null) { InfoTableCreated.TrySetResult(true); }
        }

        private async void InitializeButtonSubscriber()
        {
            await OpenAddFormButtonCreated.Task;
            OpenAddFormButton.Click += delegate { ViewAddForm?.Invoke(this, EventArgs.Empty); };

            await OpenUpdateFormButtonCreated.Task;
            OpenModifyFormButton.Click += delegate { ViewUpdateForm?.Invoke(this, EventArgs.Empty); };
        }

        private async void InitializeControlSubscriber()
        {
            await InfoTableCreated.Task;
            this.Load += delegate { ControlLoad?.Invoke(this, EventArgs.Empty); };
            InfoTable.SelectionChanged += delegate { SelectedRowChanged?.Invoke(this, EventArgs.Empty); };
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
            InfoTable.DefaultCellStyle.ForeColor          = Color.Black;
            InfoTable.DefaultCellStyle.SelectionForeColor = Color.White;
            InfoTable.DefaultCellStyle.Padding            = new Padding(3);
            InfoTable.GridColor                           = ColorTranslator.FromHtml("#FAEEFD");
            InfoTable.DefaultCellStyle.BackColor          = ColorTranslator.FromHtml("#FAEEFD");
            InfoTable.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#58048C");
            InfoTable.DefaultCellStyle.Alignment          = DataGridViewContentAlignment.MiddleLeft;
            InfoTable.DefaultCellStyle.Font               = new System.Drawing.Font("Candara", 12F, FontStyle.Regular, 
                                                                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void ModifyDataGridViewColumnHeaderStyle()
        {
            InfoTable.EnableHeadersVisualStyles                        = false;
            InfoTable.ColumnHeadersDefaultCellStyle.ForeColor          = Color.Black;
            InfoTable.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            InfoTable.ColumnHeadersDefaultCellStyle.Padding            = new Padding(5);
            InfoTable.ColumnHeadersDefaultCellStyle.BackColor          = ColorTranslator.FromHtml("#D68BAC");
            InfoTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#D68BAC");
            InfoTable.ColumnHeadersDefaultCellStyle.Alignment          = DataGridViewContentAlignment.MiddleCenter;
            InfoTable.ColumnHeadersDefaultCellStyle.Font               = new System.Drawing.Font("Candara", 12F, FontStyle.Bold, 
                                                                             System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void ModifyDataGridViewColumnWidth()
        {
            InfoTable.Columns["SrCode"].Width                 = 120;
            InfoTable.Columns["LastName"].Width               = 180;
            InfoTable.Columns["FirstName"].Width              = 180;
            InfoTable.Columns["MiddleName"].Width             = 180;
            InfoTable.Columns["BirthDate"].Width              = 150;
            InfoTable.Columns["Gender"].Width                 = 100;
            InfoTable.Columns["ContactNumber"].Width          = 170;
            InfoTable.Columns["HouseNumber"].Width            = 120;
            InfoTable.Columns["Barangay"].Width               = 180;
            InfoTable.Columns["Municipality"].Width           = 180;
            InfoTable.Columns["Province"].Width               = 180;
            InfoTable.Columns["EmergencyContactPerson"].Width = 250;
            InfoTable.Columns["ContactPersonAddress"].Width   = 250;
            InfoTable.Columns["ContactPersonNumber"].Width    = 170;
            InfoTable.Columns["EmailAddress"].Width           = 200;
        }
    }
}
