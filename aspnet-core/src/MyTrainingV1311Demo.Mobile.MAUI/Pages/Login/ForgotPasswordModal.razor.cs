using Microsoft.AspNetCore.Components;
using MyTrainingV1311Demo.Authorization.Accounts;
using MyTrainingV1311Demo.Authorization.Accounts.Dto;
using MyTrainingV1311Demo.Core.Dependency;
using MyTrainingV1311Demo.Core.Threading;
using MyTrainingV1311Demo.Mobile.MAUI.Models.Login;
using MyTrainingV1311Demo.Mobile.MAUI.Shared;

namespace MyTrainingV1311Demo.Mobile.MAUI.Pages.Login
{
    public partial class ForgotPasswordModal : ModalBase
    {
        public override string ModalId => "forgot-password-modal";
       
        [Parameter] public EventCallback OnSave { get; set; }
        
        public ForgotPasswordModel forgotPasswordModel { get; set; } = new ForgotPasswordModel();

        private readonly IAccountAppService _accountAppService;

        public ForgotPasswordModal()
        {
            _accountAppService = DependencyResolver.Resolve<IAccountAppService>();
        }

        protected virtual async Task Save()
        {
            await SetBusyAsync(async () =>
            {
                await WebRequestExecuter.Execute(
                async () =>
                    await _accountAppService.SendPasswordResetCode(new SendPasswordResetCodeInput { EmailAddress = forgotPasswordModel.EmailAddress }),
                    async () =>
                    {
                        await OnSave.InvokeAsync();
                    }
                );
            });
        }

        protected virtual async Task Cancel()
        {
            await Hide();
        }
    }
}
