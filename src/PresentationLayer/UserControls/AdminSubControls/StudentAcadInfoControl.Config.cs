﻿using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.UserControls.AdminSubControls
{
    partial class StudentAcadInfoControl
    {
        private void InvokeElementCreated()
        {
            if (CloseButton != null) CloseButtonCreated.TrySetResult(true);
            if (LastNameTextBox != null) LastNameTextBoxCreated.TrySetResult(true);
            if (FirstNameTextBox != null) FirstNameTextBoxCreated.TrySetResult(true);
            if (MiddleNameTextBox != null) MiddleNameTextBoxCreated.TrySetResult(true);
        }

        private async Task InitializeEventSubscribers()
        {
            await LastNameTextBoxCreated.Task;
            await FirstNameTextBoxCreated.Task;
            await MiddleNameTextBoxCreated.Task;
            this.Load += delegate { ControlLoad?.Invoke(this, EventArgs.Empty); };

            await CloseButtonCreated.Task;
            CloseButton.Click += delegate { CloseButtonClicked?.Invoke(this, EventArgs.Empty); };
        }
    }
}
