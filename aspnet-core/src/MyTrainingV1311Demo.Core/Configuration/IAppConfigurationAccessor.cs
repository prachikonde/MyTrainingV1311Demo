using Microsoft.Extensions.Configuration;

namespace MyTrainingV1311Demo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
