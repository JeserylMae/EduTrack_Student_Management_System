using PresentationLayer.UserControls.General;
using ServiceLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Markup;

namespace PresentationLayer.Presenters.General
{
    internal class FilterPresenter
    {
        public FilterPresenter(IFilterControl filterControl)
        {
            _filterControl = filterControl;
            _filteredContents = new List<DataGridViewRow>();
            _allInfoTableContents = _filterControl.AccessStudentControl.AccessInfoTable.Rows;

            _filterControl.ControlLoad += FilterControl_Load;
            _filterControl.ProgramComboBoxDropDownClosed      += ProgramComboBoxDropDown_Closed;
            _filterControl.SectionComboBoxDropDownClosed      += SectionComboBoxDropDown_Closed;
            _filterControl.SemesterComboBoxDropDownClosed     += SemesterComboBoxDropDown_Closed;
            _filterControl.YearLevelComboBoxDropDownClosed    += YearLevelComboBoxDropDown_Closed;
            _filterControl.AcademicYearComboBoxDropDownClosed += AcademicYearComboBoxDropDown_Closed;
        }

        private void AcademicYearComboBoxDropDown_Closed(object sender, EventArgs e)
        {
            string selectedAcadYear = _filterControl.AccessProgramComboBox.Text;
            
            if (_filteredContents.Count == 0)
            {
                _filteredContents.AddRange(_allInfoTableContents.Cast<DataGridViewRow>()
                    .Where(row => selectedAcadYear == row.Cells["AcademicYear"].Value.ToString())
                    .ToArray()
                );
            }
            else
            {
                List<DataGridViewRow> newContents = new List<DataGridViewRow>();
                newContents.AddRange(_filteredContents.Cast<DataGridViewRow>()
                    .Where(row => selectedAcadYear == row.Cells["AcademicYear"].Value.ToString())
                    .ToArray()
                );
                _filteredContents = newContents;
            }
            AddFilteredContentsToInfoTable();
        }

        private void YearLevelComboBoxDropDown_Closed(object sender, EventArgs e)
        {
            string selectedYearLevel = _filterControl.AccessYearLevelComboBox.Text;

            if (_filteredContents.Count == 0)
            {
                _filteredContents.AddRange(_allInfoTableContents.Cast<DataGridViewRow>()
                    .Where(row => selectedYearLevel == row.Cells["YearLevel"].Value.ToString())
                    .ToArray()
                );
            }
            else
            {
                List<DataGridViewRow> newContents = new List<DataGridViewRow>();
                newContents.AddRange(_filteredContents.Cast<DataGridViewRow>()
                    .Where(row => selectedYearLevel == row.Cells["YearLevel"].Value.ToString())
                    .ToArray()
                );
                _filteredContents = newContents;
            }
        }

        private void SemesterComboBoxDropDown_Closed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SectionComboBoxDropDown_Closed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ProgramComboBoxDropDown_Closed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FilterControl_Load(object sender, EventArgs e)
        {
            LoadComboBoxOptions();
        }


        #region Helpers
        private void AddFilteredContentsToInfoTable()
        {
            _filterControl.AccessStudentControl.AccessInfoTable.Rows.Clear();

            _filteredContents.Cast<object[]>().ToList()
                .ForEach(row =>
                {
                    _filterControl.AccessStudentControl.InfoTableRowData = row;
                    Console.WriteLine("Row: " + row[0].ToString());
                });
        }

        private async void LoadComboBoxOptions()
        {
            // Semester
            string[] semesterOptions = { "FIRST", "SECOND", "SUMMER" };
            _filterControl.AccessSemesterComboBox.Items.AddRange(semesterOptions);

            // Year Level
            string[] yearOptions = { "FIRST", "SECOND", "THIRD", "FOURTH", "FIFTH" };
            _filterControl.AccessYearLevelComboBox.Items.AddRange(yearOptions);

            // Academic Year
            int startingYear = DateTime.Now.Year + 1;
            string[] academicYearOptions = Enumerable.Range(0, 9)
                .Select(i => $"A.Y. {startingYear - (i+1)}-{startingYear-i}")
                .ToArray();
            _filterControl.AccessAcademicYearComboBox.Items.AddRange(academicYearOptions);

            // Section
            StudentAcademicInfoServices studentServices = new StudentAcademicInfoServices();   
            List<string> sectionOptions = await studentServices.GetAllSections();
            _filterControl.AccessSectionComboBox.Items.AddRange(sectionOptions.ToArray());

            // Program
            ProrgamServices services = new ProrgamServices();
            Dictionary<string, string> programOptions = await services.GetAllProgram();
            _filterControl.AccessProgramComboBox.Items.AddRange(programOptions.Values.ToArray());
        }
        #endregion

        private IFilterControl _filterControl;
        private List<DataGridViewRow> _filteredContents;
        private DataGridViewRowCollection _allInfoTableContents;
    }
}
