using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Volunteer_management_system.Models;

namespace Volunteer_management_system.Controllers
{
    public class CreateOpportunityController : Controller
    {
        private readonly ILogger<CreateOpportunityController> _logger;

        public CreateOpportunityController(ILogger<CreateOpportunityController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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