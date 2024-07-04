using System;
using Abp.Notifications;
using MyTrainingV1311Demo.Dto;

namespace MyTrainingV1311Demo.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}