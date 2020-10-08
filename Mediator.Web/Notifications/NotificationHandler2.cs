using System.Threading;
using System.Threading.Tasks;
using Mediator.Web.Commands;
using MediatR;

namespace Mediator.Web.Notifications
{
    public class NotificationHandler2 : INotificationHandler<AddressAddedNotification>
    {
        public Task Handle(AddressAddedNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}