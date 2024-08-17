
using PresentationLayer.UserControls.AdminSubControls;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.UserControls.MainControls
{
    public partial class AdminModifyInfoControl : UserControl, IAdminModifyInfoControl
    {
        public AdminModifyInfoControl()
        {
            InitializeComponent();
            InitializeInfoTable();
            OnTopBarButtonsCreated();
            InitializeButtonSubscriber();
        }

        public UserControl MainControlHolderControl
        {
            get { return _addedControl; }
            set 
            { 
                _addedControl = value;
                MainControlHolder.Controls.Add(_addedControl);
                _addedControl.Dock = DockStyle.Left;
            }
        }

        public event EventHandler ViewAddForm;
        public event EventHandler ViewUpdateForm;

        private UserControl _addedControl;
        private TaskCompletionSource<bool> OpenAddFormButtonCreated      = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> OpenUpdateFormButtonCreated   = new TaskCompletionSource<bool>();
    }
}
