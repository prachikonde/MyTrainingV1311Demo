using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyTrainingV1311Demo.Web.Public.Views
{
    public abstract class MyTrainingV1311DemoViewComponent : AbpViewComponent
    {
        protected MyTrainingV1311DemoViewComponent()
        {
            LocalizationSourceName = MyTrainingV1311DemoConsts.LocalizationSourceName;
        }
    }
}