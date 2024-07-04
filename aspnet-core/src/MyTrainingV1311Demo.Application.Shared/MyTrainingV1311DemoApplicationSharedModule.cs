using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyTrainingV1311Demo
{
    [DependsOn(typeof(MyTrainingV1311DemoCoreSharedModule))]
    public class MyTrainingV1311DemoApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyTrainingV1311DemoApplicationSharedModule).GetAssembly());
        }
    }
}