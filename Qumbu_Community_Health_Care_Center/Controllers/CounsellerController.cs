using Microsoft.AspNetCore.Mvc;

namespace Qumbu_Community_Health_Care_Center.Controllers
    private readonly DbContext Context;
    public CounsellorController ()
{
    public class CounsellerController : Controller
    {
        public IActionResult Patient()
        {
            return View();
        }
        public IActionResult Admin_Clerk()
        {
            return View();
        }
        public IActionResult Counsellor()
        {
            return View();
        }
        public IActionResult NoAccess()
        {
            return View();
        }
        public IActionResult Booking() 
        {
            IEnumerable<Bookings> book=
        }
    }
}
