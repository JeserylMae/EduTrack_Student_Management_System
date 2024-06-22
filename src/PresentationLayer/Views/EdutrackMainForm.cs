//using PresentationLayer.Views.AppHelper;
using PresentationLayer.Views.AppHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EdutrackMainForm : Form
    {
        public EdutrackMainForm()
        {
            InitializeComponent();
            TopButtonFunction.IsAppMaximized = false;
        }

        public void FontIconButton(object sender, EventArgs e)
        {
            TopBarButtonHelper buttonHelper = new TopBarButtonHelper();
            bool ShouldNotTriggerClick = false;

            if (!(sender is Button clickedButton))  return;
            
            switch (clickedButton.Name)
            {
                case "ExitAppButton":
                    buttonHelper.TopBarButtonClicked += TopButtonFunction.ExitAppButton_Click;
                    break;
                case "MaximizeAppbutton":
                    buttonHelper.TopBarButtonClicked += TopButtonFunction.MaximizeAppButton_Click;
                    break;
                case "MinimizeAppButton":
                    buttonHelper.TopBarButtonClicked += TopButtonFunction.MinimizeAppButton_Click;
                    break;
                default:
                    ShouldNotTriggerClick = true;
                    break;
            }

            if (!ShouldNotTriggerClick) buttonHelper.Clicked(this);
        }

        private void EdutrackMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private Point mouseLocation;

        private void EdutrackMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation);
                Location = mousePose;
            }
        }
    }
}
