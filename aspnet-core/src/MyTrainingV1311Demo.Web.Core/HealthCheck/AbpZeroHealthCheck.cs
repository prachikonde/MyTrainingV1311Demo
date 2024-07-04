using Microsoft.Extensions.DependencyInjection;
using MyTrainingV1311Demo.HealthChecks;

namespace MyTrainingV1311Demo.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<MyTrainingV1311DemoDbContextHealthCheck>("Database Connection");
            builder.AddCheck<MyTrainingV1311DemoDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
