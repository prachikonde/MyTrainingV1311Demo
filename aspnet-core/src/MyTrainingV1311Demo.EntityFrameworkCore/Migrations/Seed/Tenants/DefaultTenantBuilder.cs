using System.Linq;
using Abp.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using MyTrainingV1311Demo.Editions;
using MyTrainingV1311Demo.EntityFrameworkCore;

namespace MyTrainingV1311Demo.Migrations.Seed.Tenants
{
    public class DefaultTenantBuilder
    {
        private readonly MyTrainingV1311DemoDbContext _context;

        public DefaultTenantBuilder(MyTrainingV1311DemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.IgnoreQueryFilters().FirstOrDefault(t => t.TenancyName == MultiTenancy.Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                defaultTenant = new MultiTenancy.Tenant(AbpTenantBase.DefaultTenantName, AbpTenantBase.DefaultTenantName);

                var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
                if (defaultEdition != null)
                {
                    defaultTenant.EditionId = defaultEdition.Id;
                }

                _context.Tenants.Add(defaultTenant);
                _context.SaveChanges();
            }
        }
    }
}
