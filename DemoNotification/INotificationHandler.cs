using System.Collections.Generic;
using static DemoNotification.NotificationHandler;

namespace DemoNotification
{
    public interface INotificationHandler
    {
        NotificationBuilder DefaultBuilder();
        List<NotificationEvent> GetAllNotifications();
        void ClearNotifications();
        bool HasNotification();
    }
}
