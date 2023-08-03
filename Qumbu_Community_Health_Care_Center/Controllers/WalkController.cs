using Microsoft.AspNetCore.Mvc;

namespace Qumbu_Community_Health_Care_Center.Controllers
{
    public class WalkController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult Nurse()
        {
            return View();
        }
        public IActionResult Layout()
        {
            return View();
        }
        public IActionResult Doctor()
        {
            return View();
        }
        public IActionResult Patient()
        {
            return View();
        }
    }
}
