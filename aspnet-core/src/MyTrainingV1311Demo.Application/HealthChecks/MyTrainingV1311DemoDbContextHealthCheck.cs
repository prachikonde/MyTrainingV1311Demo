using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using MyTrainingV1311Demo.EntityFrameworkCore;

namespace MyTrainingV1311Demo.HealthChecks
{
    public class MyTrainingV1311DemoDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public MyTrainingV1311DemoDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("MyTrainingV1311DemoDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("MyTrainingV1311DemoDbContext could not connect to database"));
        }
    }
}
