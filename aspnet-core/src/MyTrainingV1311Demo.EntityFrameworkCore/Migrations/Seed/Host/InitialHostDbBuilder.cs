using MyTrainingV1311Demo.EntityFrameworkCore;

namespace MyTrainingV1311Demo.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly MyTrainingV1311DemoDbContext _context;

        public InitialHostDbBuilder(MyTrainingV1311DemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
