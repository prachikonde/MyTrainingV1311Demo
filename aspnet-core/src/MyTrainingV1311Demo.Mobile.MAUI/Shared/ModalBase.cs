using MyTrainingV1311Demo.Core.Dependency;
using MyTrainingV1311Demo.Mobile.MAUI.Services.UI;

namespace MyTrainingV1311Demo.Mobile.MAUI.Shared
{
    public abstract class ModalBase : MyTrainingV1311DemoComponentBase
    {
        protected ModalManagerService ModalManager { get; set; }

        public abstract string ModalId { get; }

        public ModalBase()
        {
            ModalManager = DependencyResolver.Resolve<ModalManagerService>();
        }

        public virtual async Task Show()
        {
            await ModalManager.Show(JS, ModalId);
            StateHasChanged();
        }

        public virtual async Task Hide()
        {
            await ModalManager.Hide(JS, ModalId);
        }
    }
}
