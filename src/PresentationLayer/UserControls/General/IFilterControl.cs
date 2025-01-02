
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
        event EventHandler ProgramComboBoxDropDownClosed;
        event EventHandler SectionComboBoxDropDownClosed;
        event EventHandler SemesterComboBoxDropDownClosed;
        event EventHandler YearLevelComboBoxDropDownClosed;
        event EventHandler AcademicYearComboBoxDropDownClosed;

        ComboBox AccessAcademicYearComboBox { get; }
        ComboBox AccessYearLevelComboBox    { get; }
        ComboBox AccessSemesterComboBox     { get; }
        ComboBox AccessSectionComboBox      { get; }
        ComboBox AccessProgramComboBox      { get; }
        IStudentModifyAcadInfoControl AccessStudentControl { get; set; }
    }
}
