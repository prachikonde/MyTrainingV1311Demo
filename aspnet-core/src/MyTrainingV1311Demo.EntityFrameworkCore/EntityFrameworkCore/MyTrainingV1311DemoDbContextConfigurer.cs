using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyTrainingV1311Demo.EntityFrameworkCore
{
    public static class MyTrainingV1311DemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyTrainingV1311DemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyTrainingV1311DemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}