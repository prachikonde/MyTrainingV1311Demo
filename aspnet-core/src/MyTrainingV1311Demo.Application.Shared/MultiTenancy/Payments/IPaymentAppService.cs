using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using MyTrainingV1311Demo.MultiTenancy.Payments.Dto;
using Abp.Application.Services.Dto;

namespace MyTrainingV1311Demo.MultiTenancy.Payments
{
    public interface IPaymentAppService : IApplicationService
    {
        Task<long> CreatePayment(CreatePaymentDto input);

        Task CancelPayment(CancelPaymentDto input);
        
        Task UpdatePayment(UpdatePaymentDto input);

        Task<PagedResultDto<SubscriptionPaymentListDto>> GetPaymentHistory(GetPaymentHistoryInput input);

        List<PaymentGatewayModel> GetActiveGateways(GetActiveGatewaysInput input);

        Task<SubscriptionPaymentDto> GetPaymentAsync(long paymentId);

        Task<SubscriptionPaymentDto> GetLastCompletedPayment();

        Task PaymentFailed(long paymentId);

        Task<bool> HasAnyPayment();
    }
}
