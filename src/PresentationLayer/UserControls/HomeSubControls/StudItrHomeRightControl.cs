
using PresentationLayer.Presenters.Enumerations;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.HomeSubControls
{
    public partial class StudItrHomeRightControl : UserControl, IStudItrHomeRightControl
    {
        public StudItrHomeRightControl()
        {
            InitializeComponent();

            this.Load += delegate { OnControlLoad?.Invoke(this, EventArgs.Empty); };
        }


        public void DestroyControl() { this.Dispose(); }

        public event EventHandler OnControlLoad;

        public AccessType CurrentUserType { get; set; }

        public Label AccessYearText              => YearText;
        public Label AccessSrCodeText            => SrCodeText;
        public Label AccessSectionText           => SectionText;
        public Label AccessProgramText           => ProgramText;
        public Label AccessSemesterText          => SemesterText;
        public Label AccessStudEmailText         => StudEmailText;
        public Label AccessStudContactNumberText => StudContactNumberText;

        public Label AccessGenderText           => GenderText;
        public Label AccessItrCodeText          => ItrCodeText;
        public Label AccessAddressText          => AddressText;
        public Label AccessItrEmailText         => ItrEmailText;
        public Label AccessBirthDateText        => BirthDateText;
        public Label AccessItrContactNumberText => ItrContactNumberText;

        public FlowLayoutPanel AccessStudentInfoMainPanel    => StudentInfoMainPanel;
        public FlowLayoutPanel AccessInstructorInfoMainPanel => InstructorInfoMainPanel;
    }
}
