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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create(Bookings book)
        {
            if (ModelState.IsValid)
            {
                Context.Bookings.Add(book);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}
