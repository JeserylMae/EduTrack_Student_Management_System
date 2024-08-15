

using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    partial class AdminModifyInfoControl
    {
        private void InitializeInfoTable()
        {
            InfoTable.Rows.Add("11-0000", "Montefalco", "Knoxx", "Navarro", "2000-12-12", "Male", "09089", "", "Padre Castillo", "San Pascual", "Batangas", "Claudin N. Montefalco", "");
            InfoTable.Rows.Add("11-0000", "Montefalco", "Knoxx", "Navarro", "2000-12-12");

           // ModifyRowStyle();
        }

        private void ModifyRowStyle()
        {
            for (int idx = 0; idx < InfoTable.RowCount; idx++)
            {
                InfoTable.Rows[idx].Height = 40;
                InfoTable.Rows[idx].DefaultCellStyle.ForeColor = Color.Black;
                InfoTable.Rows[idx].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAEEFD");
                InfoTable.Rows[idx].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                InfoTable.Rows[idx].DefaultCellStyle.Padding = new Padding(3);
                InfoTable.Rows[idx].DefaultCellStyle.Font = new System.Drawing.Font("Candara", 12F,
                                                    FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                                                    ((byte)(0))); ;
            }
        }
    }
}
