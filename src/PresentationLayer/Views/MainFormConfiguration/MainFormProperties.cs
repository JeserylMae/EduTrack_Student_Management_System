
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views.MainFormConfiguration
{
    internal partial class MainFormProperties
    {
        internal delegate void MouseClickedEventHandler (Form form, object sender, MouseEventArgs e);

        internal event MouseClickedEventHandler MouseClicked;

        internal void Clicked(Form form, MouseEventArgs mouseEventArgs)
        {
            OnMouseCliked(form, mouseEventArgs);
        }

        protected virtual void OnMouseCliked(Form form, MouseEventArgs mouseEventArgs)
        {
            MouseClicked?.Invoke(form, this, mouseEventArgs);
        }

        internal static void OnTopBarPanelCreated(Panel TopBarPanel)
        {
            if (TopBarPanel != null)
                MainFormProperties.TopBarCreated.TrySetResult(true);
        }

        internal static TaskCompletionSource<bool> TopBarCreated = new TaskCompletionSource<bool>();
    }
}
