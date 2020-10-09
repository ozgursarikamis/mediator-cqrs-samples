using System.Diagnostics;
using System.Threading.Tasks;
using Mediator.Web.Commands;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mediator.Web.Models;
using MediatR;

namespace Mediator.Web.Controllers
{
    public class HomeController : Controller
    {
        public ILogger<HomeController> Logger { get; }
        public IMediator Mediator { get; }

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            Logger = logger;
            Mediator = mediator;
        }

        public async Task<IActionResult> Index()
        { 
            var addAddressCommand = new AddAddressCommand { City = "VAN", PostalCode = "65000", StreetAddress = "Metmanis", UserId = 1 };
            var response = await Mediator.Send(addAddressCommand);
            Debug.WriteLine(response.Message);
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
