using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyTrainingV1311Demo.ApiClient;
using MyTrainingV1311Demo.Mobile.MAUI.Core.ApiClient;

namespace MyTrainingV1311Demo
{
    [DependsOn(typeof(MyTrainingV1311DemoClientModule), typeof(AbpAutoMapperModule))]

    public class MyTrainingV1311DemoMobileMAUIModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            Configuration.ReplaceService<IApplicationContext, MAUIApplicationContext>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyTrainingV1311DemoMobileMAUIModule).GetAssembly());
        }
    }
}