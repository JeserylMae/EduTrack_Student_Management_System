
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.UserControls.AdminSubControls
{
    public partial class PersonalInfoControl : UserControl, IPersonalInfoControl
    {
        public PersonalInfoControl()
        {
            InitializeComponent();
            SetYearOptions();
            OnButtonsCreated();
            InitializeButtonsAsHidden();
            _ = InitializeButtonSubcribers();
        }
        
        public void DestroyControl()   { this.Dispose();            }
        public void ShowAddButton()    { SubmitAddButton.Show();    }
        public void ShowUpdateButton() { SubmitUpdateButton.Show(); }

        public string PageIndicatorLabelText      { set => PageIndicatorLabel.Text      = value; }
        public string UserCodeIndicatorLabelText  { set => UserCodeIndicatorLabel.Text  = value; }
        public string BasicInfoIndicatorLabelText { set => BasicInfoIndicatorLabel.Text = value; }

        public string UserCodeTextboxText   { get => UserCodeTextbox.Text;   set => UserCodeTextbox.Text   = value; }
        public string LastNameTextboxText   { get => LastNameTextbox.Text;   set => LastNameTextbox.Text   = value; }
        public string FirstNameTextboxText  { get => FirstNameTextbox.Text;  set => FirstNameTextbox.Text  = value; }
        public string MiddleNameTextboxText { get => MiddleNameTextbox.Text; set => MiddleNameTextbox.Text = value; }
        public string ZipCodeTextboxText    { get => ZipCodeTextbox.Text;    set => ZipCodeTextbox.Text    = value; }
        public string BarangayTextboxText   { get => BarangayTextbox.Text;   set => BarangayTextbox.Text   = value; }

        public string MunicipalityTextboxText  { get => MunicipalityTextbox.Text;  set => MunicipalityTextbox.Text  = value; }
        public string ProvinceTextboxText      { get => ProvinceTextbox.Text;      set => ProvinceTextbox.Text      = value; }
        public string ContactNumberTextboxText { get => ContactNumberTextbox.Text; set => ContactNumberTextbox.Text = value; }
        public string EmailAddresTextboxText   { get => EmailAddressTextbox.Text;  set => EmailAddressTextbox.Text  = value; }

        public string MonthComboBoxText     { get => MonthComboBox.SelectedItem.ToString();     set => MonthComboBox.SelectedItem  = value; }
        public string DayComboBoxText       { get => DayComboBox.SelectedItem.ToString();       set => DayComboBox.SelectedItem    = value; }
        public string YearComboBoxText      { get => YearComboBox.SelectedItem.ToString();      set => YearComboBox.SelectedItem   = value; }
        public string GenderComboBoxText    { get => GenderComboBox.SelectedItem.ToString();    set => GenderComboBox.SelectedItem = value; }

        public string DefaultPasswordTextboxText       { get => DefaultPasswordTextbox.Text;       set => DefaultPasswordTextbox.Text       = value; }
        public string GuardianLastNameTextboxText      { get => GuardianLastNameTextbox.Text;      set => GuardianFirstNameTextbox.Text     = value; }
        public string GuardianFirstNameTextboxText     { get => GuardianFirstNameTextbox.Text;     set => GuardianFirstNameTextbox.Text     = value; }
        public string GuardianMiddleNameTextboxText    { get => GuardianMiddleNameTextbox.Text;    set => GuardianMiddleNameTextbox.Text    = value; }
        public string GuardianZipCodeTextboxText       { get => GuardianZipCodeTextbox.Text;       set => GuardianZipCodeTextbox.Text       = value; }
        public string GuardianBarangayTextboxText      { get => GuardianBarangayTextbox.Text;      set => GuardianBarangayTextbox.Text      = value; }
        public string GuardianMunicipalityTextboxText  { get => GuardianMunicipalityTextbox.Text;  set => GuardianMunicipalityTextbox.Text  = value; }
        public string GuardianProvinceTextboxText      { get => GuardianProvinceTextbox.Text;      set => GuardianProvinceTextbox.Text      = value; }
        public string GuardianContactNumberTextboxText { get => GuardianContactNumberTextbox.Text; set => GuardianContactNumberTextbox.Text = value; }


        public event EventHandler TopCloseButtonClicked;
        public event EventHandler BotCancelButtonClicked;
        public event EventHandler AddNewStudentInfoSubmit;
        public event EventHandler UpdateStudentInfoSubmit;

        private TaskCompletionSource<bool> TopCloseButtonCreated         = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> BotCancelButtonCreated        = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> SubmitAddInfoButtonCreated    = new TaskCompletionSource<bool>();
        private TaskCompletionSource<bool> SubmitUpdateInfoButtonCreated = new TaskCompletionSource<bool>();
    }
}
