
using System;
using System.Collections.Generic;


namespace PresentationLayer.UserControls.AdminSubControls
{
    partial class PersonalInfoControl
    {
		private void InitializeButtonsAsHidden()
		{
			SubmitAddButton.Hide();
			SubmitUpdateButton.Hide();
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
		}
	}
}
