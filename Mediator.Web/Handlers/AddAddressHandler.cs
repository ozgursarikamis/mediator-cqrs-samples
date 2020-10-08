using System.Threading;
using System.Threading.Tasks;
using Mediator.Web.Commands;
using MediatR;

namespace Mediator.Web.Handlers
{
    public class AddAddressHandler : IRequestHandler<AddAddressCommand, AddAddressResponse>
    {
        public IMediator Mediator { get; }

        public AddAddressHandler(IMediator mediator)
        {
            Mediator = mediator;
        }

        public async Task<AddAddressResponse> Handle(AddAddressCommand request, CancellationToken cancellationToken)
        {
            // save to the database
            await Mediator.Publish(new AddressAddedNotification(), cancellationToken);
            return new AddAddressResponse();
        }
    }
}