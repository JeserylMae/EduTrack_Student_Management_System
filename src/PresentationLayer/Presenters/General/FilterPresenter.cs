using PresentationLayer.Presenters.Enumerations;
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
            _previousComboBox = FilterFrom.None;
            _filteredContents = new List<DataGridViewRow>();
            _unfilteredContents = new List<DataGridViewRow>();
            _allInfoTableContents = _filterControl.AccessStudentControl.AccessInfoTable.Rows;


            _filterControl.ControlLoad += FilterControl_Load;
            _filterControl.ProgramComboBoxSelectedIndexChanged += ProgramComboBoxSelectedIndex_Changed;
            _filterControl.SectionComboBoxSelectedIndexChanged += SectionComboBoxSelectedIndex_Changed;
            _filterControl.SemesterComboBoxSelectedIndexChanged += SemesterComboBoxSelectedIndex_Changed;
            _filterControl.YearLevelComboBoxSelectedIndexChanged += YearLevelComboBoxSelectedIndex_Changed;
            _filterControl.AcademicYearComboBoxSelectedIndexChanged += AcademicYearComboBoxSelectedIndex_Changed;
        }

        private void AcademicYearComboBoxSelectedIndex_Changed(object sender, EventArgs e)
        {
            int targetColIdx = _allInfoTableContents[0].Cells["AcademicYear"].ColumnIndex;
            string selectedAcadYear = _filterControl.AccessAcademicYearComboBox.Text;
            
            FilterDataByCondition(FilterFrom.AcademicYear, selectedAcadYear, targetColIdx);
            AddFilteredContentsToInfoTable();
        }

        private void YearLevelComboBoxSelectedIndex_Changed(object sender, EventArgs e)
        {
            int targetColIdx = _allInfoTableContents[0].Cells["YearLevel"].ColumnIndex;
            string selectedYearLevel = _filterControl.AccessYearLevelComboBox.Text;

            FilterDataByCondition(FilterFrom.YearLevel, selectedYearLevel, targetColIdx);
            AddFilteredContentsToInfoTable();
        }

        private void SemesterComboBoxSelectedIndex_Changed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SectionComboBoxSelectedIndex_Changed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ProgramComboBoxSelectedIndex_Changed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FilterControl_Load(object sender, EventArgs e)
        {
            LoadComboBoxOptions();
        }


        #region Helpers
        private void FilterDataByCondition(FilterFrom senderComboBox, 
                                string filterValue, 
                                int targetColIdx)
        {
            if ((_filteredContents.Count == 0 && _previousComboBox == FilterFrom.None) ||
                (_filteredContents.Count != 0 && _previousComboBox == senderComboBox))
            { 
                List<DataGridViewRow> temp = new List<DataGridViewRow>();
                FilterData(ref temp, _allInfoTableContents, filterValue, targetColIdx);

                Console.WriteLine($"ALL COUNT: {_allInfoTableContents.Count}");
                Console.WriteLine($"UF COUNT: {_unfilteredContents.Count}");
                Console.WriteLine($"F COUNT: {_filteredContents.Count}");

                _filteredContents.Clear();
                _filteredContents = temp;
                _previousComboBox = senderComboBox;
            }
            else
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();
                FilterData(ref temp, _filteredContents, filterValue, targetColIdx);

                _filteredContents.Clear();
                _filteredContents = temp;
                _previousComboBox = senderComboBox;
            }
        }

        private void FilterData(ref List<DataGridViewRow> outputContainer, 
                                DataGridViewRowCollection inputContainer, 
                                string filterValue, 
                                int columnIndex)
        {
            outputContainer.AddRange(inputContainer.Cast<DataGridViewRow>()
                .Where(row => row.Cells[columnIndex].Value.ToString() == filterValue)
                .ToList()
            );

            _unfilteredContents.AddRange(inputContainer.Cast<DataGridViewRow>()
                .Where(row => row.Cells[columnIndex].Value.ToString() != filterValue)
                .ToList()
            );
        }

        private void FilterData(ref List<DataGridViewRow> outputContainer,
                                List<DataGridViewRow> inputContainer,
                                string filterValue,
                                int columnInndex)
        {
            outputContainer.AddRange(inputContainer.Cast<DataGridViewRow>()
                .Where(row => row.Cells[columnInndex].Value.ToString() == filterValue)
                .ToList()
            );
        }

        private void AddFilteredContentsToInfoTable()
        {
            _filterControl.AccessStudentControl.AccessInfoTable.Rows.Clear();

            List<object[]> contents = _filteredContents.Cast<DataGridViewRow>()
                .Select(row => row.Cells.Cast<DataGridViewCell>()
                    .Select(cell => cell.Value)
                    .ToArray()
                ).ToList();

            contents.ForEach(row => _filterControl.AccessStudentControl.InfoTableRowData = row);
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

        private FilterFrom _previousComboBox;
        private IFilterControl _filterControl;
        private List<DataGridViewRow> _unfilteredContents;
        private List<DataGridViewRow> _filteredContents;
        private DataGridViewRowCollection _allInfoTableContents;
    }
}
