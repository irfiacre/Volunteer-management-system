using Microsoft.AspNetCore.Mvc;
using Volunteer_management_system.Data;
using Volunteer_management_system.Data.Services;
using Volunteer_management_system.Models;

namespace Volunteer_management_system.Controllers
{
    public class OpportunityController : Controller
    {
        private readonly IOpportunitiesService _service;

        public OpportunityController(IOpportunitiesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ID,CoverURL,Title,Description,Organization,Vacancies,UserId,StartDate,EndDate")]Opportunities opportunity)
        {
            if (ModelState.IsValid)
            {
                return View(opportunity);
            }
            Random rnd = new Random();
            opportunity.ID = $"{
                (opportunity.Title.Length > 10?opportunity.Title.Substring(0, 10): opportunity.Title) 
              }-{(opportunity.Organization != null ? opportunity.Organization: "NoOrg")}-{rnd.Next()}";
            opportunity.UserId = 1;

            await _service.Add(opportunity);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(string id)
        {
            var OpportunityDetails = await _service.GetById(id);
            if (OpportunityDetails == null) return View("NotFound");
            return View(OpportunityDetails);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var OpportunityDetails = await _service.GetById(id);
            if (OpportunityDetails == null) return View("NotFound");
            return View(OpportunityDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id ,[Bind("ID,CoverURL,Title,Description,Organization,Vacancies,UserId,StartDate,EndDate")] Opportunities opportunity)
        {
            if (ModelState.IsValid)
            {
                return View(opportunity);
            }
            opportunity.UserId = 1; 
            await _service.Update(id,opportunity);
            return RedirectToAction(nameof(Index));
        }
    }
}
