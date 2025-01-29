using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.UserControls.HomeSubControls
{
    partial class StudItrHomeBottomControl
    {
        private void InitializeElementsCreated()
        {
            if (GradeButton != null) GradeButtonCreated.TrySetResult(true);
            if (AttendanceButton != null) AttendanceButtonCreated.TrySetResult(true);
            if (StudentInfoButton != null) StudentInfoButtonCreated.TrySetResult(true);
        }

        private async Task InitializeEventSubscriber()
        {
            await GradeButtonCreated.Task;
            GradeButton.Click += delegate { GradeButtonClicked?.Invoke(this, EventArgs.Empty); };

            await AttendanceButtonCreated.Task;
            AttendanceButton.Click += delegate { AttendanceButtonClicked?.Invoke(this, EventArgs.Empty); };

            await StudentInfoButtonCreated.Task;
            StudentInfoButton.Click += delegate { StudentInfoButtonClicked?.Invoke(this, EventArgs.Empty); };
        }
    }
}
