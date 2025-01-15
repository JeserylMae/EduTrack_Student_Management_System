using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.UserControls.AdminSubControls
{
    partial class ProgramInfoFormControl
    {
        private void InitializeElementCreated()
        {
            if (CloseButton != null)                CloseButtonCreated.TrySetResult(true);
            if (SubmitAddButton != null)            SubmitAddButtonCreated.TrySetResult(true);
            if (SubmitUpdateButton != null)         SubmitUpdateButtonCreated.TrySetResult(true);
            if (CancelSubmitButtonClicked != null)  CancelSubmitButtonCreated.TrySetResult(true);
        }

        private async Task InitializeEventSubscriber()
        {
            this.Load += delegate { OnControlLoad?.Invoke(this, EventArgs.Empty); };
            
            await CloseButtonCreated.Task;
            CloseButton.Click += delegate { CloseButtonClicked?.Invoke(this, EventArgs.Empty); };

            await SubmitAddButtonCreated.Task;
            SubmitAddButton.Click += delegate { SubmitAddButtonClicked?.Invoke(this, EventArgs.Empty); };

            await SubmitUpdateButtonCreated.Task;
            SubmitUpdateButton.Click += delegate { SubmitUpdateButtonClicked?.Invoke(this, EventArgs.Empty); };

            await CancelSubmitButtonCreated.Task;
            CancelSubmitButton.Click += delegate { CancelSubmitButtonClicked?.Invoke(this, EventArgs.Empty); };
        }
    }
}
