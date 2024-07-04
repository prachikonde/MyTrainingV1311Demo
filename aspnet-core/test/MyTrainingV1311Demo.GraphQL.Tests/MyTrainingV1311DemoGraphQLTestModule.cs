using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using MyTrainingV1311Demo.Configure;
using MyTrainingV1311Demo.Startup;
using MyTrainingV1311Demo.Test.Base;

namespace MyTrainingV1311Demo.GraphQL.Tests
{
    [DependsOn(
        typeof(MyTrainingV1311DemoGraphQLModule),
        typeof(MyTrainingV1311DemoTestBaseModule))]
    public class MyTrainingV1311DemoGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyTrainingV1311DemoGraphQLTestModule).GetAssembly());
        }
    }
}