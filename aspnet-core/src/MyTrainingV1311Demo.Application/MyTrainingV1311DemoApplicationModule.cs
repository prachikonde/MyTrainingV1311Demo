using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyTrainingV1311Demo.Authorization;

namespace MyTrainingV1311Demo
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(MyTrainingV1311DemoApplicationSharedModule),
        typeof(MyTrainingV1311DemoCoreModule)
        )]
    public class MyTrainingV1311DemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyTrainingV1311DemoApplicationModule).GetAssembly());
        }
    }
}