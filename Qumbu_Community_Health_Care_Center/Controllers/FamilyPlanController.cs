using Microsoft.AspNetCore.Mvc;

namespace Qumbu_Community_Health_Care_Center.Controllers
{
    public class FamilyPlanController : Controller
    {
        
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
        public IActionResult NoAccess()
        {
            return View();
        }

    }
}
