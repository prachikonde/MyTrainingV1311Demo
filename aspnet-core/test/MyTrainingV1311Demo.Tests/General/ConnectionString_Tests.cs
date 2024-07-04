using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace MyTrainingV1311Demo.Tests.General
{
    // ReSharper disable once InconsistentNaming
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=MyTrainingV1311Demo; Trusted_Connection=True;");
            csb["Database"].ShouldBe("MyTrainingV1311Demo");
        }
    }
}
