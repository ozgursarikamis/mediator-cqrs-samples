using System.Threading.Tasks;
using Mediator.RazorPages.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Mediator.RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public ILogger<IndexModel> Logger { get; }
        public IMediator Mediator { get; }

        public IndexModel(ILogger<IndexModel> logger, IMediator mediator)
        {
            Logger = logger;
            Mediator = mediator;
        }

        public void OnGet()
        {

        }

        public async Task OnPostAsync()
        {
            var addAddressCommand = new AddAddressCommand {City = "VAN", PostalCode = "65000", StreetAddress = "Metmanis", UserId = 1};
            await Mediator.Send(addAddressCommand);
        }
    }
}
