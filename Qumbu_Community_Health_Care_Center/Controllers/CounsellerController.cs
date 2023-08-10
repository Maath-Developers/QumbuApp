using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using Qumbu_Community_Health_Care_Center.Models;


namespace Qumbu_Community_Health_Care_Center.Controllers
 
{
    public class CounsellerController : Controller
    {
        private readonly ApplicationDbContext Context;
        public CounsellerController(ApplicationDbContext DbContext)
        {
            Context = DbContext;
        }
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
            IEnumerable<Bookings> book = Context.Bookings;
            return View(book);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Bookings book)
        {
            if (ModelState.IsValid)
            {
                Context.Bookings.Add(book);
                Context.SaveChanges();
                return RedirectToAction("Booking");
            }
            return View(book);
        }
        public IActionResult PatientC()
        {
            IEnumerable<PatientReg> pat = Context.PatientReg;
            return View(pat);
        }
        public IActionResult CreateR()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateR(PatientReg pat)
        {
            if (ModelState.IsValid)
            {
                Context.PatientReg.Add(pat);
                Context.SaveChanges();
                return RedirectToAction("PatientC");
            }
            return View(pat);
        }
    }
}
