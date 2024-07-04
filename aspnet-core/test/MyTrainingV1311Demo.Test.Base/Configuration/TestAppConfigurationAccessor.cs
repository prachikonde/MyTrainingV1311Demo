using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using MyTrainingV1311Demo.Configuration;

namespace MyTrainingV1311Demo.Test.Base.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(MyTrainingV1311DemoTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
