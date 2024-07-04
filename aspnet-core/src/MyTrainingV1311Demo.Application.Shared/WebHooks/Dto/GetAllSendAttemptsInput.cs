using MyTrainingV1311Demo.Dto;

namespace MyTrainingV1311Demo.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
