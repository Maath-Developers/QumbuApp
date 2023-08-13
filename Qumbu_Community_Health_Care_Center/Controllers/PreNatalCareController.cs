using Microsoft.AspNetCore.Mvc;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;

namespace Qumbu_Community_Health_Care_Center.Controllers
{
    public class PreNatalCareController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public PreNatalCareController(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult PatientDashboard()
        {
            return View();
        }
        public IActionResult Patient()
        {
            return View();
        }
        public IActionResult Admin_Clerk()
        {
            return View();
        }
        public IActionResult Nurse()
        {
            return View();
        }
        public IActionResult NurseDashboard()
        {
            return View();
        }
    }
}
