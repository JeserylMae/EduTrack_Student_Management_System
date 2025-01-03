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
            ProgramComboBox.SelectedIndexChanged += delegate { ProgramComboBoxSelectedIndexChanged?.Invoke(this, EventArgs.Empty); };

            await SectionComboBoxCreated.Task;
            SectionComboBox.SelectedIndexChanged += delegate { SectionComboBoxSelectedIndexChanged?.Invoke(this, EventArgs.Empty); };
            
            await SemesterComboBoxCreated.Task;
            SemesterComboBox.SelectedIndexChanged += delegate { SemesterComboBoxSelectedIndexChanged?.Invoke(this, EventArgs.Empty); };

            await YearLevelComboBoxCreated.Task;
            YearLevelComboBox.SelectedIndexChanged += delegate { YearLevelComboBoxSelectedIndexChanged?.Invoke(this, EventArgs.Empty); };

            await AcademicYearComboBoxCreated.Task;
            AcademicYearComboBox.SelectedIndexChanged += delegate { AcademicYearComboBoxSelectedIndexChanged?.Invoke(this, EventArgs.Empty); };
            
            this.Load += delegate { ControlLoad?.Invoke(this, EventArgs.Empty); };
        }
    }
}
