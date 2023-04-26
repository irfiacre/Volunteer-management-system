using Microsoft.AspNetCore.Mvc;
using Volunteer_management_system.Data;

namespace Volunteer_management_system.Controllers
{
    public class OpportunityController : Controller
    {
        private readonly AppDBContext _dbContext;

        public OpportunityController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var data = _dbContext.Opportunities.ToList();
            return View(data);
        }
    }
}
