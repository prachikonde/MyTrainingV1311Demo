using Abp.Application.Services.Dto;

namespace MyTrainingV1311Demo.Notifications.Dto
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}