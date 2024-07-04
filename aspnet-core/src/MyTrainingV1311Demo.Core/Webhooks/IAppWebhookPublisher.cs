using System.Threading.Tasks;
using MyTrainingV1311Demo.Authorization.Users;

namespace MyTrainingV1311Demo.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
