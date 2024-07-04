using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyTrainingV1311Demo.Configuration;
using MyTrainingV1311Demo.Web;

namespace MyTrainingV1311Demo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyTrainingV1311DemoDbContextFactory : IDesignTimeDbContextFactory<MyTrainingV1311DemoDbContext>
    {
        public MyTrainingV1311DemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyTrainingV1311DemoDbContext>();

            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            MyTrainingV1311DemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyTrainingV1311DemoConsts.ConnectionStringName));

            return new MyTrainingV1311DemoDbContext(builder.Options);
        }
    }
}
