using Abp.Localization;
using Microsoft.AspNetCore.Components;
using MyTrainingV1311Demo.ApiClient;
using MyTrainingV1311Demo.Authorization.Users.Dto;
using MyTrainingV1311Demo.Authorization.Users.Profile;
using MyTrainingV1311Demo.Core.Dependency;
using MyTrainingV1311Demo.Core.Threading;
using MyTrainingV1311Demo.Mobile.MAUI.Services.Account;
using MyTrainingV1311Demo.Mobile.MAUI.Services.UI;
using MyTrainingV1311Demo.Mobile.MAUI.Shared;


namespace MyTrainingV1311Demo.Mobile.MAUI.Pages.MySettings
{
    public partial class LanguageSwitch : MyTrainingV1311DemoComponentBase
    {
        protected LanguageService LanguageService { get; set; }

        private IApplicationContext _applicationContext;
        private readonly IProfileAppService _profileAppService;
        private List<LanguageInfo> _languages;
        private string _selectedLanguage;

        [Parameter] public EventCallback OnSave { get; set; }

        public LanguageSwitch()
        {
            _applicationContext = DependencyResolver.Resolve<IApplicationContext>();
            _profileAppService = DependencyResolver.Resolve<IProfileAppService>();
            LanguageService = DependencyResolver.Resolve<LanguageService>();

            _languages = _applicationContext.Configuration.Localization.Languages;
            _selectedLanguage = _languages.FirstOrDefault(l => l.Name == _applicationContext.CurrentLanguage.Name).Name;
        }

        public List<LanguageInfo> Languages
        {
            get => _languages;
            set => _languages = value;
        }

        public string SelectedLanguage
        {
            get => _selectedLanguage;
            set
            {
                _selectedLanguage = value;
                AsyncRunner.Run(ChangeLanguage());
            }
        }

        private async Task ChangeLanguage()
        {
            var selectedLanguage = _languages?.FirstOrDefault(l => l.Name == _selectedLanguage);
            _applicationContext.CurrentLanguage = selectedLanguage;

            await SetBusyAsync(async () =>
            {
                if (_applicationContext.LoginInfo is null)
                {
                    await UserConfigurationManager.GetAsync();
                    await OnSave.InvokeAsync();
                    LanguageService.ChangeLanguage();

                    return;
                }

                await WebRequestExecuter.Execute(async () =>
                {
                    await _profileAppService.ChangeLanguage(new ChangeUserLanguageDto
                    {
                        LanguageName = _selectedLanguage
                    });
                }, async () =>
                {
                    await UserConfigurationManager.GetAsync();
                    await OnSave.InvokeAsync();
                    LanguageService.ChangeLanguage();
                });
            });
        }
    }
}