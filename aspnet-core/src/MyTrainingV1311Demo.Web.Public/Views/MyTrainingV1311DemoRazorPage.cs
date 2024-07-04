using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MyTrainingV1311Demo.Web.Public.Views
{
    public abstract class MyTrainingV1311DemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyTrainingV1311DemoRazorPage()
        {
            LocalizationSourceName = MyTrainingV1311DemoConsts.LocalizationSourceName;
        }
    }
}
