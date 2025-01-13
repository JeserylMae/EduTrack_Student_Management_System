using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.Presenters.General;
using PresentationLayer.UserControls.AdminSubControls;
using PresentationLayer.UserControls.HomeSubControls;
using PresentationLayer.UserControls.MainControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PresentationLayer.Presenters.Admin
{
    internal class ProgramInfoPresenter
    {
        public ProgramInfoPresenter(IProgramInfoControl programControl)
        {
            _programControl = programControl;

            _programControl.ExitButtonClicked                   += GeneralPresenter.TriggerAppExit;
            _programControl.OnControlLoad                       += OnProgramInfoControl_Load;
            _programControl.OpenAddFormButtonClicked            += OpenAddFormButton_Clicked;
            _programControl.CloseEditorButtonClicked            += CloseEditorButton_Clicked;
            _programControl.FileDropDownButtonClicked           += FileDropDownButton_Clicked;
            _programControl.OpenDropFormButtonClicked           += OpenDropFormButton_Clicked;
            _programControl.OpenModifyFormButtonClicked         += OpenModifyFormButton_Clicked;
            _programControl.SearchProgramIdButtonClicked        += SearchProgramIfButton_Clicked;
            _programControl.SearchProgramIdTextboxPressed       += SearchProgramIdTextBox_Pressed;
            _programControl.InstructorAcadInfoButtonClicked     += InstructorAcademicInfoButton_Clicked;
            _programControl.StudentAcademicInfoButtonClicked    += StudentAcademicInfoButton_Clicked;
            _programControl.StudentPersonalInfoButtonClicked    += StudentPersonalInfoButton_Clicked;
            _programControl.InstructorPersonalInfoButtonClicked += InstructorPersonalInfoButton_Clicked;
        }

        private void CloseEditorButton_Clicked(object sender, EventArgs e)
        {
            _programControl.DisposeControl();

            HomePage homePage = new HomePage();
            new HomePagePresenter(homePage);

            IAdminHomeRightControl adminHomeRightControl = new AdminHomeRightControl();
            new AdminHomeRightPresenter(adminHomeRightControl);

            homePage.RightUserControlPage = (UserControl)adminHomeRightControl;

            GeneralPresenter.NewWindowControl = (UserControl)homePage;
            GeneralPresenter.TriggerWindowControlChange(sender, e);
        }

        private void InstructorPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            IPersonalInfoControl userControl = new PersonalInfoControl();
            userControl.ModifyUser = AccessType.INSTRUCTOR;

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _programControl.DisposeControl();
        }

        private void InstructorAcademicInfoButton_Clicked(object sender, EventArgs e)
        {
            IAcademicInfoControl userControl = new AcademicInfoControl();
            userControl.ModifyUser = AccessType.INSTRUCTOR;

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _programControl.DisposeControl();
        }

        private void StudentPersonalInfoButton_Clicked(object sender, EventArgs e)
        {
            IPersonalInfoControl userControl = new PersonalInfoControl();
            userControl.ModifyUser = AccessType.STUDENT;

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _programControl.DisposeControl();   
        }

        private void StudentAcademicInfoButton_Clicked(object sender, EventArgs e)
        {
            IAcademicInfoControl userControl = new AcademicInfoControl();
            userControl.ModifyUser = AccessType.STUDENT;

            GeneralPresenter.NewWindowControl = (UserControl)userControl;
            GeneralPresenter.TriggerWindowControlChange(sender, e);

            _programControl.DisposeControl();
        }

        private void SearchProgramIdTextBox_Pressed(object sender, KeyboardEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchProgramIfButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OpenModifyFormButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OpenDropFormButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OpenAddFormButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FileDropDownButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnProgramInfoControl_Load(object sender, EventArgs e)
        {
            throw new NotFiniteNumberException();
        }



        IProgramInfoControl _programControl;
    }
}
