using Microsoft.AspNetCore.Mvc;

namespace Qumbu_Community_Health_Care_Center.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin_Dashboard()
        {
            return View();
        }
    }
}
