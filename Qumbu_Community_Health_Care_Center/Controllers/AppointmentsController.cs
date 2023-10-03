using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
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
        private readonly IEmailSender email;
        public AppointmentsController(ApplicationDbContext DbContext,IEmailSender _email)
        {
            email = _email;
            Context = DbContext;
        }
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
        public async Task <IActionResult> Create(Appointment appointments)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            appointments.PatientID = user;
            if (ModelState.IsValid)
            {
                Context.Appointment.Add(appointments);
                await Context.SaveChangesAsync();
                TempData["Success"] = "Succesfully booked";
    //            try
    //            {
    //                string supportEmail = "Qumbu_Community_Health_Care_Center.healthcare@gmail.com";
    //                var email = User.FindFirstValue(ClaimTypes.Email);
    //               email./*SendEmailAsync*/(email, "Appointment Created",
    //                    $"<html><head> <style>.body {{font-family: Arial, sans-serif; }} " +
    //                    $"h1 {{ color: #00342C; }}" +
    //                    $".cta-button {{ background-color: #00C2CC; color: white" +
    //                    $"padding: 10px 20px;" +
    //                    $"text-decoration: none; border-radius: 5px; }}" +
    //                    $"footer{{ margin-top: 20px; font-size: 12px; color: #888;}}" +
    //                    $"cta-button: hover {{background-color: #00C2C; }}" +
    //                    $"</style>" +
    //                    $"</head>" +
    //                    $"</body>" +
    //                    $"" +
    //                    $"<h1>Qumbu healthcare Center</h1>" +
    //                    $"<p></p>" +
    //                    $"<p> This is a notification email about your appointment</p>" +
    //                    $"<strong>Appointment Date: {appointments.Date_Time}</p></strong>" +
    //                    $"<p>Kindly note that your appointment has been succesfully scheduled</P>" +

    //                    $"<p>For any questions or queries, please contact our support team at {supportEmail}.</p>" +
    //                    $"<div class='footer'>" +
    //                    $"<p>Thank you.</p>" +
    //                    $"<p>Qumbu Healthcare Team</p>" +
    //                    $"</div>" +
    //                    $"</body>" +
    //                    $"</html>");
    //            }
    //            catch ( Exception ex ) 
    //            {
				//	TempData["Success"] = "Succesfully booked but email notification failed.";
				//}
                return RedirectToAction("Create");
            }
            ViewBag.App = Context.Appointments.Where(a => a.PatientID == user).ToList();
            ViewData["PatientID"] = new SelectList(Context.Users, "Id", "Id", appointments.PatientID);
            return View(appointments);
        }
        public IActionResult Accept(int? id)
        {
            var appointments = Context.Appointments.Find(id);
            if (appointments != null)
            {
                appointments.Status = "Accepted";
                Context.Appointments.Update(appointments);
                Context.SaveChanges();
                var patient = Context.Users.Where(a => a.Id == appointments.PatientID).FirstOrDefault();
                //try
                //{
                //    email.SendEmailAsync(patient.Email, "Appointment Accepted");
                //}
                return RedirectToAction("All_Appointments");
            }
            ViewData["PatientID"] = new SelectList(Context.Users, "Id", "Id", appointments.PatientID);
            return View(appointments);

        }
    }
}
