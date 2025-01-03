
using PresentationLayer.UserControls.MainControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.General
{
    internal interface IFilterControl
    {
        event EventHandler ControlLoad;
        event EventHandler ProgramComboBoxSelectedIndexChanged;
        event EventHandler SectionComboBoxSelectedIndexChanged;
        event EventHandler SemesterComboBoxSelectedIndexChanged;
        event EventHandler YearLevelComboBoxSelectedIndexChanged;
        event EventHandler AcademicYearComboBoxSelectedIndexChanged;

        ComboBox AccessAcademicYearComboBox { get; }
        ComboBox AccessYearLevelComboBox    { get; }
        ComboBox AccessSemesterComboBox     { get; }
        ComboBox AccessSectionComboBox      { get; }
        ComboBox AccessProgramComboBox      { get; }
        List<DataGridViewRow> InfoTableContents { get; }
        IStudentModifyAcadInfoControl AccessStudentControl { get; set; }
    }
}
