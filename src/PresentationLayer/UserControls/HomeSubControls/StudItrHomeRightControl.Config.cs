
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.HomeSubControls
{
    partial class StudItrHomeRightControl
    {
        //private void InitializeDataGridView()
        //{
        //    PersonalInfoTbl.Rows.Add("Row1 Col1", "Row1 Col2");
        //    PersonalInfoTbl.Rows.Add("Row2 Col1", "Row2 Col2");


        //    ConfigureCellDefaultStyle(idx: 0, forecolor: Color.White, bgColor: "#D68BAC",
        //        fStyle: FontStyle.Bold, allignment: DataGridViewContentAlignment.MiddleRight);

        //    ConfigureCellDefaultStyle(idx: 1, forecolor: Color.Black, bgColor: "#FAEEFD",
        //        fStyle: FontStyle.Regular, allignment: DataGridViewContentAlignment.MiddleLeft);

        //    PersonalInfoTbl.CellPainting += DataGridView1_CellPainting;
        //    PersonalInfoTbl.DefaultCellStyle.Padding = new Padding(3);


        //    PersonalInfoTbl.SelectionChanged += (s, e) => PersonalInfoTbl.ClearSelection();
        //}

        //private void ConfigureCellDefaultStyle(int idx, Color forecolor, string bgColor, FontStyle fStyle,
        //                                       DataGridViewContentAlignment allignment)
        //{
        //    PersonalInfoTbl.Rows[idx].DividerHeight = 10;
        //    PersonalInfoTbl.Columns[idx].DividerWidth = 10;
        //    PersonalInfoTbl.Columns[idx].DefaultCellStyle.ForeColor = forecolor;
        //    PersonalInfoTbl.Columns[idx].DefaultCellStyle.Alignment = allignment;
        //    PersonalInfoTbl.Columns[idx].DefaultCellStyle.BackColor = ColorTranslator.FromHtml(bgColor);
        //    PersonalInfoTbl.Columns[idx].DefaultCellStyle.Font = new System.Drawing.Font("Candara", 11.25F,
        //                                                fStyle, System.Drawing.GraphicsUnit.Point,
        //                                                ((byte)(0)));
        //}

        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                using (Pen pen = new Pen(Color.Gray, 1))
                {
                    Rectangle rect = e.CellBounds;
                    e.Graphics.DrawRectangle(pen, rect.X, rect.Y, rect.Width - 10, rect.Height - 10);
                }

                e.Handled = true;
            }
        }
    }
}
