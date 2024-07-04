using System.Threading.Tasks;
using Abp.Webhooks;

namespace MyTrainingV1311Demo.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
