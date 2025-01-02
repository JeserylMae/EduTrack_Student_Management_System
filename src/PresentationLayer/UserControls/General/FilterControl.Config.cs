using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.UserControls.General
{
    partial class FilterControl
    {
        private void InvokeElementsCreated()
        {
            if (ProgramComboBox != null) ProgramComboBoxCreated.TrySetResult(true);
            if (SectionComboBox != null) SectionComboBoxCreated.TrySetResult(true);
            if (SemesterComboBox != null) SemesterComboBoxCreated.TrySetResult(true);
            if (YearLevelComboBox != null) YearLevelComboBoxCreated.TrySetResult(true);
            if (AcademicYearComboBox != null) AcademicYearComboBoxCreated.TrySetResult(true);   
        }

        private async Task InitializeEventSubscribers()
        {
            await ProgramComboBoxCreated.Task;
            ProgramComboBox.DropDownClosed += delegate { ProgramComboBoxDropDownClosed?.Invoke(this, EventArgs.Empty); };

            await SectionComboBoxCreated.Task;
            SectionComboBox.DropDownClosed += delegate { SectionComboBoxDropDownClosed?.Invoke(this, EventArgs.Empty); };
            
            await SemesterComboBoxCreated.Task;
            SemesterComboBox.DropDownClosed += delegate { SemesterComboBoxDropDownClosed?.Invoke(this, EventArgs.Empty); };

            await YearLevelComboBoxCreated.Task;
            YearLevelComboBox.DropDownClosed += delegate { YearLevelComboBoxDropDownClosed?.Invoke(this, EventArgs.Empty); };

            await AcademicYearComboBoxCreated.Task;
            AcademicYearComboBox.DropDownClosed += delegate { AcademicYearComboBoxDropDownClosed?.Invoke(this, EventArgs.Empty); };
            
            this.Load += delegate { ControlLoad?.Invoke(this, EventArgs.Empty); };
        }
    }
}
