using System.Diagnostics;
using System.Threading.Tasks;
using Mediator.Web.Commands;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mediator.Web.Models;
using Mediator.Web.Services;
using MediatR;

namespace Mediator.Web.Controllers
{
    public class HomeController : Controller
    {
        public ILogger<HomeController> Logger { get; }
        public IMediator Mediator { get; }
        public INotifierService NotifierService { get; }

        public HomeController(ILogger<HomeController> logger, IMediator mediator, INotifierService notifierService)
        {
            Logger = logger;
            Mediator = mediator;
            NotifierService = notifierService;
        }

        public async Task<IActionResult> Index()
        { 
            var addAddressCommand = new AddAddressCommand { City = "VAN", PostalCode = "65000", StreetAddress = "Metmanis", UserId = 1 };
            var response = await Mediator.Send(addAddressCommand);
            Logger.LogInformation(response.Message);

            await NotifierService.Notify("This is a notification service message");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
