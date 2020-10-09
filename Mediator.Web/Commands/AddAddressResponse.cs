using System.Diagnostics;

namespace Mediator.Web.Commands
{
    public class AddAddressResponse
    {
        public AddAddressResponse()
        {
            Debug.WriteLine("AddAddressResponse constructor");
        }
        public string Message { get; set; } = "This is a AddAddressResponse";
    }
}