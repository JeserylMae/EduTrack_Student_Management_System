using PresentationLayer.UserControls.AdminSubControls;
using PresentationLayer.UserControls.MainControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.General
{
    public partial class FilterControl : UserControl, IFilterControl
    {
        public FilterControl()
        {
            ProgramComboBoxCreated      = new TaskCompletionSource<bool>();
            SectionComboBoxCreated      = new TaskCompletionSource<bool>();
            SemesterComboBoxCreated     = new TaskCompletionSource<bool>();
            YearLevelComboBoxCreated    = new TaskCompletionSource<bool>();
            AcademicYearComboBoxCreated = new TaskCompletionSource<bool>();

            InitializeComponent();
            InvokeElementsCreated();
            _ = InitializeEventSubscribers();
        }


        public ComboBox AccessProgramComboBox      { get => ProgramComboBox;      }
        public ComboBox AccessSectionComboBox      { get => SectionComboBox;      }
        public ComboBox AccessSemesterComboBox     { get => SemesterComboBox;     }
        public ComboBox AccessYearLevelComboBox    { get => YearLevelComboBox;    }
        public ComboBox AccessAcademicYearComboBox { get => AcademicYearComboBox; }
        public IStudentModifyAcadInfoControl AccessStudentControl 
        { 
            get => _studentControl; 
            set => _studentControl = value; 
        }

        
        public event EventHandler ControlLoad;
        public event EventHandler ProgramComboBoxDropDownClosed;
        public event EventHandler SectionComboBoxDropDownClosed;
        public event EventHandler SemesterComboBoxDropDownClosed;
        public event EventHandler YearLevelComboBoxDropDownClosed;
        public event EventHandler AcademicYearComboBoxDropDownClosed;


        private IStudentModifyAcadInfoControl _studentControl;
        private TaskCompletionSource<bool> ProgramComboBoxCreated;
        private TaskCompletionSource<bool> SectionComboBoxCreated;
        private TaskCompletionSource<bool> SemesterComboBoxCreated;
        private TaskCompletionSource<bool> YearLevelComboBoxCreated;
        private TaskCompletionSource<bool> AcademicYearComboBoxCreated;
    }
}
