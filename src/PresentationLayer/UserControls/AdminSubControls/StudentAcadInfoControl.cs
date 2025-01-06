using DomainLayer.DataModels;
using FontAwesome.Sharp;
using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.UserControls.MainControls;
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
            CloseButtonCreated        = new TaskCompletionSource<bool>();
            SubmitAddButtonCreated    = new TaskCompletionSource<bool>();
            LastNameTextBoxCreated    = new TaskCompletionSource<bool>();
            FirstNameTextBoxCreated   = new TaskCompletionSource<bool>();
            MiddleNameTextBoxCreated  = new TaskCompletionSource<bool>();   
            SubmitUpdateButtonCreated = new TaskCompletionSource<bool>();
            CancelSubmitButtonCreated = new TaskCompletionSource<bool>();

            InitializeComponent();
            InvokeElementCreated();
            _ = InitializeEventSubscribers();
        }
        

        public void DisposeControl() => this.Dispose();


        public event EventHandler ControlLoad;
        public event EventHandler CloseButtonClicked;
        public event EventHandler SubmitAddButtonClicked;
        public event EventHandler SubmitUpdateButtonClicked;
        public event EventHandler CancelSubmitButtonClicked;


        public UserControl CurrentControl           { get => this;                 }
        public TextBox AccessSrCodeTextBox          { get => SrCodeTextBox;        }
        public TextBox AccessLastNameTextBox        { get => LastNameTextBox;      }
        public TextBox AccessSectionTextBox         { get => SectionTextBox;       }
        public TextBox AccessFirstNameTextBox       { get => FirstNameTextBox;     }
        public TextBox AccessMiddleNameTextBox      { get => MiddleNameTextBox;    }
        public ComboBox AccessYearComboBox          { get => YearComboBox;         }
        public ComboBox AccessProgramComboBox       { get => ProgramComboBox;      }
        public ComboBox AccessSemesterComboBox      { get => SemesterComboBox;     }
        public ComboBox AccessAcademicYearComboBox  { get => AcademicYearComboBox; }
        public IconButton AccessSubmitAddButton     { get => SubmitAddButton;      }
        public IconButton AccessSubmitUpdateButton  { get => SubmitUpdateButton;   }


        public DataGridView AccessInfoTable                 { get; set; }
        public FormRequestType CurrentRequestType           { get; set; }
        public IModifyAcadInfoControl StudentControl {  get; set; }


        private TaskCompletionSource<bool> CloseButtonCreated;
        private TaskCompletionSource<bool> SubmitAddButtonCreated;
        private TaskCompletionSource<bool> LastNameTextBoxCreated;
        private TaskCompletionSource<bool> FirstNameTextBoxCreated;
        private TaskCompletionSource<bool> MiddleNameTextBoxCreated;
        private TaskCompletionSource<bool> CancelSubmitButtonCreated;
        private TaskCompletionSource<bool> SubmitUpdateButtonCreated;
    }
}
