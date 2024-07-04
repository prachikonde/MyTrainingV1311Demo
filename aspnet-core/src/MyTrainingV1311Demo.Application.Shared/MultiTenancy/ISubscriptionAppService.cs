using System.Threading.Tasks;
using Abp.Application.Services;
using MyTrainingV1311Demo.MultiTenancy.Dto;
using MyTrainingV1311Demo.MultiTenancy.Payments.Dto;

namespace MyTrainingV1311Demo.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
        
        Task<long> StartExtendSubscription(StartExtendSubscriptionInput input);
        
        Task<StartUpgradeSubscriptionOutput> StartUpgradeSubscription(StartUpgradeSubscriptionInput input);
        
        Task<long> StartTrialToBuySubscription(StartTrialToBuySubscriptionInput input);
    }
}
