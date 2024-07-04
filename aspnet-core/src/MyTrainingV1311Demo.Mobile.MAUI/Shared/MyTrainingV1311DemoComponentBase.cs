using Abp.ObjectMapping;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MyTrainingV1311Demo.Core.Dependency;
using MyTrainingV1311Demo.Mobile.MAUI.Services.UI;

namespace MyTrainingV1311Demo.Mobile.MAUI.Shared
{
    public abstract class MyTrainingV1311DemoComponentBase : ComponentBase
    {
        [Inject] protected IJSRuntime JS { get; set; }

        protected UserDialogsService UserDialogsService { get; set; }

        protected IObjectMapper ObjectMapper { get; set; }

        public MyTrainingV1311DemoComponentBase()
        {
            UserDialogsService = DependencyResolver.Resolve<UserDialogsService>();
            ObjectMapper = DependencyResolver.Resolve<IObjectMapper>();
        }

        public async Task SetBusyAsync(Func<Task> func)
        {
            await UserDialogsService.Block();
            try
            {
                await func();
            }
            finally
            {
                await UserDialogsService.UnBlock();
            }
        }

        public string L(string text)
        {
            return Localization.L.Localize(text);
        }

        public static string L(string text, params object[] args)
        {
            return Localization.L.Localize(text, args);
        }

        public static string LocalizeWithThreeDots(string text, params object[] args)
        {
            return Localization.L.LocalizeWithThreeDots(text, args);
        }

        public static string LocalizeWithParantheses(string text, object valueWithinParentheses, params object[] args)
        {
            return Localization.L.LocalizeWithParantheses(text, valueWithinParentheses, args);
        }
    }
}
