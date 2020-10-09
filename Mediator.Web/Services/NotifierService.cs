using System.Diagnostics;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Mediator.Web.Services
{
    public interface INotifierService
    {
        Task Notify(string message);
    }
    public class NotificationMessage : INotification
    {
        public string Message { get; set; }
    }

    public class NotifierService : INotifierService
    {
        public IMediator Mediator { get; }
        public NotifierService(IMediator mediator)
        {
            Mediator = mediator;
        }

        public async Task Notify(string message)
        {
            var notificationMessage = new NotificationMessage {Message = "This is a notification text"};
            Debug.WriteLine(notificationMessage.Message);
            await Mediator.Publish(notificationMessage);
        }
    } 
}
