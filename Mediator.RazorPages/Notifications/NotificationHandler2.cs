using System.Threading;
using System.Threading.Tasks;
using Mediator.RazorPages.Commands;
using MediatR;

namespace Mediator.RazorPages.Notifications
{
    public class NotificationHandler2 : INotificationHandler<AddressAddedNotification>
    {
        public Task Handle(AddressAddedNotification notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}