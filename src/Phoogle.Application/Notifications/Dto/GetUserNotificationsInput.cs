using Abp.Notifications;
using Phoogle.Dto;

namespace Phoogle.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}