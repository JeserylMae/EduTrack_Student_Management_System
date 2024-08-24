
using System;
using System.Threading.Tasks;


namespace PresentationLayer.UserControls.AdminSubControls
{
    partial class PersonalInfoControl
    {
		private void InitializeButtonsAsHidden()
		{
			SubmitAddButton.Hide();
			SubmitUpdateButton.Hide();
		}

		private void OnControlsCreated()
		{
			if (CloseButton != null)		{ TopCloseButtonCreated.TrySetResult(true);			}
			if (YearComboBox != null)		{ YearComboBoxCreated.TrySetResult(true);			}
			if (CancelButton != null)		{ BotCancelButtonCreated.TrySetResult(true);		}
			if (SubmitAddButton != null)	{ SubmitAddInfoButtonCreated.TrySetResult(true);	}	
			if (SubmitUpdateButton != null) { SubmitUpdateInfoButtonCreated.TrySetResult(true); }
		}

		private async Task InitializeControlSubcribers()
		{
			await YearComboBoxCreated.Task;
			this.Load += delegate { OnControlLoad?.Invoke(this, EventArgs.Empty); };

			await TopCloseButtonCreated.Task;
			CloseButton.Click += delegate { TopCloseButtonClicked?.Invoke(this, EventArgs.Empty); };

			await BotCancelButtonCreated.Task;
			CancelButton.Click += delegate { BotCancelButtonClicked?.Invoke(this, EventArgs.Empty); };

			await SubmitAddInfoButtonCreated.Task;
			SubmitAddButton.Click += delegate { AddNewStudentInfoSubmit?.Invoke(this, EventArgs.Empty); };

			await SubmitUpdateInfoButtonCreated.Task;
			SubmitUpdateButton.Click += delegate { UpdateStudentInfoSubmit?.Invoke(this, EventArgs.Empty); };
		}
	}
}
