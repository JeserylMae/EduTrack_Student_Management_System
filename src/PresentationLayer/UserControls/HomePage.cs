
using PresentationLayer.UserControls.HomeSubControls;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();

            //AdminHomeRightControl adminHomeRightControl = new AdminHomeRightControl();
            //StudItrHomeBottomControl bottomControl = new StudItrHomeBottomControl();
            //RightPanel.Controls.Add(adminHomeRightControl);
            //BottomPanel.Controls.Add(bottomControl);    
        }

        public UserControl RightUserControlPage 
        { 
            get { return _rightUserControl; }
            set
            {
                if (_rightUserControl != null) TerminateRightUserControl();

                _rightUserControl = value;
                RightPanel.Controls.Add(value);
                _rightUserControl.BringToFront();
            }
        }

        public UserControl BottomUserControlPage
        {
            get { return _bottomUserControl; }
            set
            {
                if ( _bottomUserControl != null ) TerminateBottomUserControl();

                _bottomUserControl = value;
                BottomPanel.Controls.Add(value);
                _bottomUserControl.BringToFront();
            }
        }


        private UserControl _rightUserControl;
        private UserControl _bottomUserControl;
    }
}
