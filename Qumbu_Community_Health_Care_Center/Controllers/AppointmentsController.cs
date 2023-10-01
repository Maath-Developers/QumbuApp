using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using Qumbu_Community_Health_Care_Center.Models;
using System.Security.Claims;

namespace Qumbu_Community_Health_Care_Center.Controllers
{
    [Authorize]
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext Context;
        public AppointmentsController(ApplicationDbContext DbContext)
        {
            Context = DbContext;
        }
        //[Bind("AppointmentID,Date,Purpose,Status,PatientID,Date_Time")]
        public async Task<IActionResult> Index()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var applicationDbContext = Context.Appointments.Include(a => a.MainUser).Where(a => a.PatientID == user);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> All_Appointments()
        {
            var applicationDbContext = Context.Appointments.Include(a => a.MainUser);
            return View(await applicationDbContext.ToListAsync());
        }
        public IActionResult Create()
        {
			var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
			ViewBag.App = Context.Appointments.Where(a => a.PatientID == user).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Appointment appointments)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            appointments.PatientID = user;
            if (ModelState.IsValid)
            {
                Context.Appointment.Add(appointments);
                Context.SaveChanges();
                TempData["Success"] = "Succesfully booked";
                return RedirectToAction("Create");
            }
            ViewBag.App = Context.Appointments.Where(a => a.PatientID == user).ToList();
            ViewData["PatientID"] = new SelectList(Context.Users, "Id", "Id", appointments.PatientID);
            return View(appointments);
        }
    }
}
