
using System;
using System.Windows.Forms;
using PresentationLayer.UserControls.MainControls;
using PresentationLayer.UserControls.AdminSubControls;


namespace PresentationLayer.Presenters
{
    public class AdminModifyInfoPresenter
    {
        public AdminModifyInfoPresenter(IAdminModifyInfoControl adminModifyInfoControl)
        {
            _adminModifyInfoControl = adminModifyInfoControl;

            _adminModifyInfoControl.ViewAddForm    += OpenAddFormButton_Clicked;
            _adminModifyInfoControl.ViewUpdateForm += OpenModifyFormButton_Clicked;
        }

        private void OpenAddFormButton_Clicked(object sender, EventArgs e)
        {
            IPersonalInfoControl personalInfoControl = new PersonalInfoControl();
            personalInfoControl.ShowAddButton();

            _adminModifyInfoControl.MainControlHolderControl = (UserControl)personalInfoControl;
        }

        private void OpenModifyFormButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private IAdminModifyInfoControl _adminModifyInfoControl;
    }
}
