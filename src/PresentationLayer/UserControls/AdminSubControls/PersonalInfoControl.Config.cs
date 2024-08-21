
using System;
using System.Collections.Generic;
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

		private void OnButtonsCreated()
		{
			if (CloseButton != null)		{ TopCloseButtonCreated.TrySetResult(true);			}
			if (CancelButton != null)		{ BotCancelButtonCreated.TrySetResult(true);		}
			if (SubmitAddButton != null)	{ SubmitAddInfoButtonCreated.TrySetResult(true);	}	
			if (SubmitUpdateButton != null) { SubmitUpdateInfoButtonCreated.TrySetResult(true); }
		}

		private async Task InitializeButtonSubcribers()
		{
			await TopCloseButtonCreated.Task;
			CloseButton.Click += delegate { TopCloseButtonClicked?.Invoke(this, EventArgs.Empty); };

			await BotCancelButtonCreated.Task;
			CancelButton.Click += delegate { BotCancelButtonClicked?.Invoke(this, EventArgs.Empty); };

			await SubmitAddInfoButtonCreated.Task;
			SubmitAddButton.Click += delegate { AddNewStudentInfoSubmit?.Invoke(this, EventArgs.Empty); };

			await SubmitUpdateInfoButtonCreated.Task;
			SubmitUpdateButton.Click += delegate { UpdateStudentInfoSubmit?.Invoke(this, EventArgs.Empty); };
		}

		private void SetYearOptions()
		{
			int currentYear = DateTime.Now.Year;
			IList<string> years = new List<string>();

			for (int idx = currentYear; idx >= 1950; idx--)
			{
				years.Add(idx.ToString());
			}
			YearComboBox.DataSource = years;
			YearComboBox.SelectedItem = null;
		}
	}
}
