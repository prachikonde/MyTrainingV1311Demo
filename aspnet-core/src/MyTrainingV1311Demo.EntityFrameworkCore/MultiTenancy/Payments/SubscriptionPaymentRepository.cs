﻿using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.Linq.Extensions;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using MyTrainingV1311Demo.EntityFrameworkCore;
using MyTrainingV1311Demo.EntityFrameworkCore.Repositories;

namespace MyTrainingV1311Demo.MultiTenancy.Payments
{
    public class SubscriptionPaymentRepository : MyTrainingV1311DemoRepositoryBase<SubscriptionPayment, long>,
        ISubscriptionPaymentRepository
    {
        public SubscriptionPaymentRepository(IDbContextProvider<MyTrainingV1311DemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<SubscriptionPayment> GetPaymentWithProducts(long id)
        {
            var entity = await (await GetAllIncludingAsync(sp => sp.SubscriptionPaymentProducts))
                .FirstOrDefaultAsync(sp => sp.Id == id);

            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(SubscriptionPayment), id);
            }

            return entity;
        }

        public async Task<SubscriptionPayment> GetByGatewayAndPaymentIdAsync(SubscriptionPaymentGatewayType gateway,
            string paymentId)
        {
            return await SingleAsync(p => p.ExternalPaymentId == paymentId && p.Gateway == gateway);
        }

        public async Task<SubscriptionPayment> GetLastCompletedPaymentOrDefaultAsync(int tenantId,
            SubscriptionPaymentGatewayType? gateway, bool? isRecurring)
        {
            var query = await GetAllAsync();
            return (await query
                    .Where(p => p.TenantId == tenantId)
                    .Where(p => p.Status == SubscriptionPaymentStatus.Completed)
                    .WhereIf(gateway.HasValue, p => p.Gateway == gateway.Value)
                    .WhereIf(isRecurring.HasValue, p => p.IsRecurring == isRecurring.Value)
                    .ToListAsync()
                )
                .OrderByDescending(x => x.Id)
                .FirstOrDefault();
        }

        public async Task<SubscriptionPayment> GetLastPaymentOrDefaultAsync(int tenantId,
            SubscriptionPaymentGatewayType? gateway, bool? isRecurring)
        {
            var query = await GetAllAsync();
            return (await query
                    .Where(p => p.TenantId == tenantId)
                    .WhereIf(gateway.HasValue, p => p.Gateway == gateway.Value)
                    .WhereIf(isRecurring.HasValue, p => p.IsRecurring == isRecurring.Value)
                    .ToListAsync()).OrderByDescending(x => x.Id
                )
                .FirstOrDefault();
        }
    }
}