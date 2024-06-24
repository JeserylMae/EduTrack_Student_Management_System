using PresentationLayer.Presenters;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    partial class EdutrackMainForm
    {
        private void Clicked(Form form)
        {
            OnTopBarButtonClicked(form);
        }

        internal void Clicked(Form form, MouseEventArgs mouseEventArgs)
        {
            OnMouseCliked(form, mouseEventArgs);
        }

        protected virtual void OnTopBarButtonClicked(Form form)
        {
            _topBarButtonEventHandler?.Invoke(form, this, EventArgs.Empty);
        }

        protected virtual void OnMouseCliked(Form form, MouseEventArgs mouseEventArgs)
        {
            _mouseClickedEventHandler?.Invoke(form, this, mouseEventArgs);
        }

        private void ExitAppButton_Clicked(object sender, EventArgs e)
        {
            WindowExit += EdutrackMainFormPresenter.ExitAppButton_Click;
            Clicked(this);
        }
        private void MaximizedAppButton_Clicked(object sender, EventArgs e)
        {
            WindowMaximized += EdutrackMainFormPresenter.MaximizeAppButton_Click;
            Clicked(this);
            WindowMaximized -= EdutrackMainFormPresenter.MaximizeAppButton_Click;
        }
        private void MinimizedAppButton_Clicked(object sender, EventArgs e)
        {
            WindowMinimized += EdutrackMainFormPresenter.MinimizeAppButton_Click;
            Clicked(this);
            WindowMinimized -= EdutrackMainFormPresenter.MinimizeAppButton_Click;
        }

        private async Task AppMainPanelEventSubscriber()
        {
            await EdutrackMainFormPresenter.TopBarCreated.Task;

            EdutrackMainFormPresenter.MainForm = this;
            TopBarPanel.MouseDown += new MouseEventHandler(EdutrackMainFormPresenter.EdutrackMainForm_MouseDown);
            TopBarPanel.MouseMove += new MouseEventHandler(EdutrackMainFormPresenter.EdutrackMainForm_MouseMove);
        }
    }
}
