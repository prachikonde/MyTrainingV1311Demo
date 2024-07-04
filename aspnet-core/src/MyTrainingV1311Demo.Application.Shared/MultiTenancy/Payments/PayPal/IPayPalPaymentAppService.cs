using System.Threading.Tasks;
using Abp.Application.Services;
using MyTrainingV1311Demo.MultiTenancy.Payments.PayPal.Dto;

namespace MyTrainingV1311Demo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
