

using System;
using System.Threading.Tasks;

namespace PresentationLayer.UserControls.HomeSubControls
{
    partial class AdminHomeRightControl
    {
        private void OnRightPanelButtonCreated()
        {
            if(CourseInfoButton       != null) { CourseInfoButtonCreated.TrySetResult(true);       }
            if(ItrAcadInfoButton      != null) { ItrAcadInfoButtonCreated.TrySetResult(true);      }
            if(StudAcadInfoButton     != null) { StudAcadInfoButtonCreated.TrySetResult(true);     }
            if(ItrPersonalInfoButton  != null) { ItrPersonalInfoButtonCreated.TrySetResult(true);  }
            if(StudPersonalInfoButton != null) { StudPersonalInfoButtonCreated.TrySetResult(true); }
        }

        private async Task InitializeRightPanelButton()
        {
            await CourseInfoButtonCreated.Task;
            CourseInfoButton.Click += delegate { CourseInfoButtonClicked?.Invoke(this, EventArgs.Empty); };

            await ItrAcadInfoButtonCreated.Task;
            ItrAcadInfoButton.Click += delegate { ItrAcadInfoButtonClicked?.Invoke(this, EventArgs.Empty); };

            await StudAcadInfoButtonCreated.Task;
            StudAcadInfoButton.Click += delegate { StudAcadInfoButtonClicked?.Invoke(this, EventArgs.Empty); };

            await ItrPersonalInfoButtonCreated.Task;
            ItrPersonalInfoButton.Click += delegate { ItrPersonalInfoButtonClicked?.Invoke(this, EventArgs.Empty); };

            await StudPersonalInfoButtonCreated.Task;
            StudPersonalInfoButton.Click += delegate { StudPersonalInfoButtonClicked?.Invoke(this, EventArgs.Empty); };
        }
    }
}
