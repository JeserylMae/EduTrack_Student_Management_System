
using PresentationLayer.Views.MainFormConfiguration;
using System;
using System.Drawing;

using System.Windows.Forms;
using System.Windows.Input;

namespace PresentationLayer
{
    public partial class EdutrackMainForm : Form
    {
        public EdutrackMainForm()
        {
            InitializeComponent();
            TopBarButtonFunction.IsAppMaximized = false;
        }

        public void FontIconButton(object sender, EventArgs e)
        {
            TopBarButtonFunction topBarButtonFunction = new TopBarButtonFunction();
            bool ShouldNotTriggerClick = false;

            if (!(sender is Button clickedButton))  return;
            
            switch (clickedButton.Name)
            {
                case "ExitAppButton":
                    topBarButtonFunction.TopBarButtonClicked += TopBarButtonFunction.ExitAppButton_Click;
                    break;
                case "MaximizeAppbutton":
                    topBarButtonFunction.TopBarButtonClicked += TopBarButtonFunction.MaximizeAppButton_Click;
                    break;
                case "MinimizeAppButton":
                    topBarButtonFunction.TopBarButtonClicked += TopBarButtonFunction.MinimizeAppButton_Click;
                    break;
                default:
                    ShouldNotTriggerClick = true;
                    break;
            }

            if (!ShouldNotTriggerClick) topBarButtonFunction.Clicked(this);
        }

        private void DragMainForm(object sender, MouseEventArgs e)
        {
            MainFormProperties mainFormProperties = new MainFormProperties();

            if (!(e.button is MouseButtons.Left)) return;

            if (e.Clicks > 0)
            {
                mainFormProperties.MouseClicked += MainFormProperties.EdutrackMainForm_MouseDown;
            }
            else
            {
                mainFormProperties.MouseClicked += MainFormProperties.EdutrackMainForm_MouseMove;
            }

            mainFormProperties.Clicked(this, e);
        }
    }
}
