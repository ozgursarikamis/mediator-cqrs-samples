using MediatR;

namespace Mediator.Web.Commands
{
    public class AddAddressCommand : IRequest<AddAddressResponse>
    {
        public int UserId { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string StreetAddress { get; set; }
    }

    public class AddAddressResponse { }

    public class AddressAddedNotification : INotification
    {
        public AddressAddedNotification()
        {

        }
    }

    #region Notification Handlers

    #endregion
}
