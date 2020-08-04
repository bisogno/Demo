using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DemoNotification
{
    public static class NotificationDepedencyInjection
    {
        public static IServiceCollection AddNotificationDepenciesInjection(this IServiceCollection services)
        {
            services.TryAddScoped<INotificationHandler, NotificationHandler>();
            return services;
        }

    }
}
