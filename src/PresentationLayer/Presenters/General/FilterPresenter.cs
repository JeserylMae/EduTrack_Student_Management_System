using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.UserControls.General;
using ServiceLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            _filterBy = new Dictionary<string, List<string>>();
            _unfilteredContents = _filterControl.InfoTableContents;


            _filterControl.ControlLoad += FilterControl_Load;
            _filterControl.ProgramComboBoxSelectedIndexChanged += ProgramComboBoxSelectedIndex_Changed;
            _filterControl.SectionComboBoxSelectedIndexChanged += SectionComboBoxSelectedIndex_Changed;
            _filterControl.SemesterComboBoxSelectedIndexChanged += SemesterComboBoxSelectedIndex_Changed;
            _filterControl.YearLevelComboBoxSelectedIndexChanged += YearLevelComboBoxSelectedIndex_Changed;
            _filterControl.AcademicYearComboBoxSelectedIndexChanged += AcademicYearComboBoxSelectedIndex_Changed;
        }

        private void AcademicYearComboBoxSelectedIndex_Changed(object sender, EventArgs e)
        {
            string filterValue = _filterControl.AccessAcademicYearComboBox.Text;

            HandleComboBoxSelectionChanged(filterValue, "AcademicYear", FilterFrom.AcademicYear);
        }

        private void YearLevelComboBoxSelectedIndex_Changed(object sender, EventArgs e)
        {
            string filterValue = _filterControl.AccessYearLevelComboBox.Text;
            HandleComboBoxSelectionChanged(filterValue, "YearLevel", FilterFrom.YearLevel);
        }

        private void SemesterComboBoxSelectedIndex_Changed(object sender, EventArgs e)
        {
            string filterValue = _filterControl.AccessSemesterComboBox.Text;
            HandleComboBoxSelectionChanged(filterValue, "Semester", FilterFrom.Semester);
        }

        private void SectionComboBoxSelectedIndex_Changed(object sender, EventArgs e)
        {
            string filterValue = _filterControl.AccessSectionComboBox.Text;
            HandleComboBoxSelectionChanged(filterValue, "Section", FilterFrom.Section);
        }

        private void ProgramComboBoxSelectedIndex_Changed(object sender, EventArgs e)
        {
            string filterValue = _filterControl.AccessProgramComboBox.Text;
            HandleComboBoxSelectionChanged(filterValue, "Program", FilterFrom.Program);
        }

        private async void FilterControl_Load(object sender, EventArgs e)
        {
            LoadAcademicYearOptions();
            LoadYearLevelOptions();
            LoadSemesterOptions();

            await LoadSectionOptions();
            await LoadProgramOptions();
        }


        #region Helpers
        private void FilterDataByCondition(FilterFrom senderComboBox)
        {
            GetUnfilteredContents(ref _filteredContents);

            List<DataGridViewRow> temp = new List<DataGridViewRow>();
            FilterData(ref temp, ref _filteredContents);

            _filteredContents.Clear();
            _filteredContents = temp;
            _previousComboBox = senderComboBox;
        }

        private void FilterData(ref List<DataGridViewRow> outputContainer,
                                ref List<DataGridViewRow> inputContainer)
        {
            if (_filterBy.Count <= 0) outputContainer.AddRange(inputContainer);

            foreach (var kpv in _filterBy)
            {
                int columnIndex = int.Parse(kpv.Value[1]);
                string filterValue = kpv.Value[0];

                outputContainer.AddRange(inputContainer.Cast<DataGridViewRow>()
                    .Where(row => row.Cells[columnIndex]?.Value.ToString() == filterValue)
                    .ToList()
                );
            }
        }

        private void HandleComboBoxSelectionChanged(string filterValue, string columnName, FilterFrom senderComboBox)
        {
            if (_filterControl.AccessStudentControl.AccessInfoTable.Rows.Count <= 0) return;
            
            int targetColIdx = _filterControl.AccessStudentControl.AccessInfoTable.Rows[0].Cells[columnName].ColumnIndex;
            

            if (filterValue == "ALL" && _filterBy.Count <= 0)
                _filterBy.Remove(columnName);
            else
                _filterBy[columnName] = new List<string> { filterValue, targetColIdx.ToString() };
            

            FilterDataByCondition(senderComboBox);
            AddFilteredContentsToInfoTable(_filteredContents);
        }

        private void GetUnfilteredContents(ref List<DataGridViewRow> filteredContents)
        {
            filteredContents.Clear();
            filteredContents = _unfilteredContents
                .Select(row => {
                    var clonedRow = (DataGridViewRow)row.Clone();

                    row.Cells.Cast<DataGridViewCell>()
                        .Select((cell, index) => clonedRow.Cells[index].Value = cell.Value)
                        .ToList();

                    return clonedRow;
                })
                .ToList();
        }

        private void AddFilteredContentsToInfoTable(List<DataGridViewRow> data)
        {
            _filterControl.AccessStudentControl.AccessInfoTable.Rows.Clear();

            List<object[]> contents = data.Cast<DataGridViewRow>()
                .Select(row => row.Cells.Cast<DataGridViewCell>()
                    .Select(cell => cell.Value)
                    .ToArray()
                ).ToList();

            contents.ForEach(row => _filterControl.AccessStudentControl.InfoTableRowData = row);
        }

        private void LoadSemesterOptions()
        {
            string[] semesterOptions = { "ALL", "FIRST", "SECOND", "SUMMER" };

            _filterControl.AccessSemesterComboBox.Items.AddRange(semesterOptions);
        }

        private void LoadYearLevelOptions()
        {
            string[] yearOptions = { "ALL", "FIRST", "SECOND", "THIRD", "FOURTH", "FIFTH" };

            _filterControl.AccessYearLevelComboBox.Items.AddRange(yearOptions);
        }

        private void LoadAcademicYearOptions()
        {
            int startingYear = DateTime.Now.Year + 1;

            string[] academicYearOptions = new[] { "ALL" }
                .Concat(Enumerable.Range(0, 9)
                    .Select(i => $"A.Y. {startingYear - (i + 1)}-{startingYear - i}")
                ).ToArray();

            _filterControl.AccessAcademicYearComboBox.Items.AddRange(academicYearOptions);
        }
        
        private async Task LoadSectionOptions()
        {
            StudentAcademicInfoServices studentServices = new StudentAcademicInfoServices();

            List<string> sectionOptions = new List<string> { "ALL" };
            sectionOptions.AddRange(await studentServices.GetAllSections());
            
            _filterControl.AccessSectionComboBox.Items.AddRange(sectionOptions.ToArray());
        }

        private async Task LoadProgramOptions()
        {
            ProrgamServices services = new ProrgamServices();

            Dictionary<string, string> response = await services.GetAllProgram();

            List<string> programOptions = new List<string> { "ALL" };
            programOptions.AddRange(response.Values);

            _filterControl.AccessProgramComboBox.Items.AddRange(programOptions.ToArray());
        }
        #endregion


        private Dictionary<string, List<string>> _filterBy;
        private string _previousFilterColumn;
        private FilterFrom _previousComboBox;
        private IFilterControl _filterControl;
        private List<DataGridViewRow> _unfilteredContents;
        private List<DataGridViewRow> _filteredContents;
    }
}
