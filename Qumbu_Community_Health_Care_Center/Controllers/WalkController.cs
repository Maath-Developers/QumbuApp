using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using System.Security.Claims;

namespace Qumbu_Community_Health_Care_Center.Controllers
{
    [Authorize]
    public class WalkController : Controller
    {
        private readonly ApplicationDbContext _context;
        public WalkController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult Nurse_Dashboard()
        {
            return View();
        }
        public IActionResult Nurse_Cons()
        {
            return View();
        }
        public IActionResult Nurse_Appointment()
        {
            return View();
        }
        public IActionResult Medical_Record()
        {
            return View();
        }
        public IActionResult Doctor_Availability()
        {
            return View();
        }
        public IActionResult Cons_Report()
        {
            return View();
        }
        public IActionResult FeedBack()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Layout()
        {
            return View();
        }
        public IActionResult Doctor_Dash()
        {
            return View();
        }
        public IActionResult Doctor_diagnose()
        {
            return View();
        }
        public IActionResult Patient()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            try
            {
                var File = _context.Medical_File.Where(a => a.PatientID == user).FirstOrDefault();
                if(File != null ){ 
                TempData["FileFound"] = "Found" ;
                }

            }catch(Exception ex)
            {

            }
            return View();
        }
        public IActionResult NoAccess()
        {
            return View();
        }
    }
}
