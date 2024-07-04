using Abp.AspNetCore.Mvc.Views;

namespace MyTrainingV1311Demo.Web.Views
{
    public abstract class MyTrainingV1311DemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MyTrainingV1311DemoRazorPage()
        {
            LocalizationSourceName = MyTrainingV1311DemoConsts.LocalizationSourceName;
        }
    }
}
