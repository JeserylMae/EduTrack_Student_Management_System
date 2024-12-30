using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.Presenters.General;
using PresentationLayer.UserControls.AdminSubControls;
using ServiceLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters.Admin
{
    internal class AcadInfoPresenter
    {
        public AcadInfoPresenter(IStudentAcadInfoControl studentAcadInfoControl)
        {
            _studentAcadInfoControl = studentAcadInfoControl;

            _studentAcadInfoControl.ControlLoad += StudentAcadInfoControl_Load;
            _studentAcadInfoControl.CloseButtonClicked += CloseButton_Clicked;
        }

        private void CloseButton_Clicked(object sender, EventArgs e)
        {
            _studentAcadInfoControl.CurrentControl.Dispose();
        }

        private void StudentAcadInfoControl_Load(object sender, EventArgs e)
        {
            if (_studentAcadInfoControl.CurrentRequestType == FormRequestType.UPDATE)
                SetNameTextBoxToReadOnly();

            LoadComboBoxOptions();
        }


        #region Helpers
        private async void LoadComboBoxOptions()
        {
            string[] yearOptions = { "FIRST", "SECOND", "THIRD", "FOURTH", "FIFTH"};
            _studentAcadInfoControl.AccessYearComboBox.Items.AddRange(yearOptions);

            string[] semesterOptions = { "FISRT", "SECOND", "SUMMER" };
            _studentAcadInfoControl.AccessSemesterComboBox.Items.AddRange(semesterOptions);

            int startingYear = DateTime.Now.Year + 1;
            string[] acadYearOptions = Enumerable.Range(0, 9)
                .Select(i => $"A.Y. {startingYear - (i + 1)} - {startingYear - i}")
                .ToArray();
            _studentAcadInfoControl.AccessAcademicYearComboBox.Items.AddRange(acadYearOptions);

            ProrgamServices services = new ProrgamServices();
            Dictionary<string, string> programList = await services.GetAllProgram();
            string[] programOptions = programList.Values.ToArray();
            _studentAcadInfoControl.AccessProgramComboBox.Items.AddRange(programOptions);
        }

        private void SetNameTextBoxToReadOnly()
        {
            _studentAcadInfoControl.AccessLastNameTextBox.ReadOnly = true;
            _studentAcadInfoControl.AccessFirstNameTextBox.ReadOnly = true;
            _studentAcadInfoControl.AccessMiddleNameTextBox.ReadOnly = true;
        }
        #endregion

        private IStudentAcadInfoControl _studentAcadInfoControl;
    }
}
