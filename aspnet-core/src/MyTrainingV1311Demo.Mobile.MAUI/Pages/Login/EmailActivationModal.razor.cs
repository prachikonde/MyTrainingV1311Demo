using Microsoft.AspNetCore.Components;
using MyTrainingV1311Demo.Authorization.Accounts;
using MyTrainingV1311Demo.Authorization.Accounts.Dto;
using MyTrainingV1311Demo.Core.Dependency;
using MyTrainingV1311Demo.Core.Threading;
using MyTrainingV1311Demo.Mobile.MAUI.Models.Login;
using MyTrainingV1311Demo.Mobile.MAUI.Shared;

namespace MyTrainingV1311Demo.Mobile.MAUI.Pages.Login
{
    public partial class EmailActivationModal : ModalBase
    {
        public override string ModalId => "email-activation-modal";

        [Parameter] public EventCallback OnSave { get; set; }

        public EmailActivationModel emailActivationModel { get; set; } = new EmailActivationModel();

        private readonly IAccountAppService _accountAppService;

        public EmailActivationModal()
        {
            _accountAppService = DependencyResolver.Resolve<IAccountAppService>();
        }

        protected virtual async Task Save()
        {
            await SetBusyAsync(async () =>
            {
                await WebRequestExecuter.Execute(
                async () =>
                    await _accountAppService.SendEmailActivationLink(new SendEmailActivationLinkInput
                    {
                        EmailAddress = emailActivationModel.EmailAddress
                    }),
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
