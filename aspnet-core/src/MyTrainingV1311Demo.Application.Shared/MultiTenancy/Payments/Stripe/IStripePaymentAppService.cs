using System.Threading.Tasks;
using Abp.Application.Services;
using MyTrainingV1311Demo.MultiTenancy.Payments.Dto;
using MyTrainingV1311Demo.MultiTenancy.Payments.Stripe.Dto;

namespace MyTrainingV1311Demo.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();
        
        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}