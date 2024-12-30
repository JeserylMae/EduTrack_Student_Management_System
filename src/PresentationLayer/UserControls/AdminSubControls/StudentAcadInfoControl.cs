using DomainLayer.DataModels;
using FontAwesome.Sharp;
using PresentationLayer.Presenters.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PresentationLayer.UserControls.AdminSubControls
{
    public partial class StudentAcadInfoControl : UserControl, IStudentAcadInfoControl
    {
        public StudentAcadInfoControl()
        {
            CloseButtonCreated       = new TaskCompletionSource<bool>();
            LastNameTextBoxCreated   = new TaskCompletionSource<bool>();
            FirstNameTextBoxCreated  = new TaskCompletionSource<bool>();
            MiddleNameTextBoxCreated = new TaskCompletionSource<bool>();   

            InitializeComponent();
            InvokeElementCreated();
            _ = InitializeEventSubscribers();
        }
        

        public void DisposeControl() => this.Dispose();


        public event EventHandler ControlLoad;
        public event EventHandler CloseButtonClicked;


        public UserControl CurrentControl           { get => this;                 }
        public ComboBox AccessYearComboBox          { get => YearComboBox;         }
        public TextBox AccessLastNameTextBox        { get => LastNameTextBox;      }
        public ComboBox AccessProgramComboBox       { get => ProgramComboBox;      }
        public TextBox AccessFirstNameTextBox       { get => FirstNameTextBox;     }
        public TextBox AccessMiddleNameTextBox      { get => MiddleNameTextBox;    }
        public ComboBox AccessSemesterComboBox      { get => SemesterComboBox;     }
        public IconButton AccessSubmitAddButton     { get => SubmitAddButton;      }
        public IconButton AccessSubmitUpdateButton  { get => SubmitUpdateButton;   }
        public ComboBox AccessAcademicYearComboBox  { get => AcademicYearComboBox; }

        public FormRequestType CurrentRequestType { get; set; }


        private TaskCompletionSource<bool> CloseButtonCreated;
        private TaskCompletionSource<bool> LastNameTextBoxCreated;
        private TaskCompletionSource<bool> FirstNameTextBoxCreated;
        private TaskCompletionSource<bool> MiddleNameTextBoxCreated;
    }
}
