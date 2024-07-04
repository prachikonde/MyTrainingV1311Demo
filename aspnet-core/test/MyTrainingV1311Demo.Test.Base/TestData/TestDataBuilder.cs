using MyTrainingV1311Demo.EntityFrameworkCore;

namespace MyTrainingV1311Demo.Test.Base.TestData
{
    public class TestDataBuilder
    {
        private readonly MyTrainingV1311DemoDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(MyTrainingV1311DemoDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();
            new TestEditionsBuilder(_context).Create();

            _context.SaveChanges();
        }
    }
}
