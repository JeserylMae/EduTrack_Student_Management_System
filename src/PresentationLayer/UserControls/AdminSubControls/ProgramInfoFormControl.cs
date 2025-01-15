using FontAwesome.Sharp;
using PresentationLayer.Presenters.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.AdminSubControls
{
    public partial class ProgramInfoFormControl : UserControl, IProgramInfoFormControl
    {
        public ProgramInfoFormControl()
        {
            CloseButtonCreated = new TaskCompletionSource<bool>();
            SubmitAddButtonCreated = new TaskCompletionSource<bool>();
            SubmitUpdateButtonCreated = new TaskCompletionSource<bool>();
            CancelSubmitButtonCreated = new TaskCompletionSource<bool>();

            InitializeComponent();
            InitializeElementCreated();
            _ = InitializeEventSubscriber();
        }


        public void DisposeControl()
        {
            this.Dispose();
        }


        public TextBox AccessProgramId => ProgramIdTextBox;
        public TextBox AccessProgramName => ProgramNameTextBox;
        public TextBox AccessDepartmentId => DepartmentIdTextBox;
        public TextBox AccessDepartmentName => DepartmentNameTextBox;

        public IconButton AccessSubmitAddButton => SubmitAddButton;
        public IconButton AccessSubmitUpdateButton => SubmitUpdateButton;

        public IProgramInfoControl ProgramControl     { get; set; }
        public FormRequestType AccessFormRequestType  { get; set; }

        public event EventHandler OnControlLoad;
        public event EventHandler CloseButtonClicked;
        public event EventHandler SubmitAddButtonClicked;
        public event EventHandler SubmitUpdateButtonClicked;
        public event EventHandler CancelSubmitButtonClicked;


        private TaskCompletionSource<bool> CloseButtonCreated;
        private TaskCompletionSource<bool> SubmitAddButtonCreated;
        private TaskCompletionSource<bool> SubmitUpdateButtonCreated;
        private TaskCompletionSource<bool> CancelSubmitButtonCreated;
    }
}
