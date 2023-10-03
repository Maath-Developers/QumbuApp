using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using Qumbu_Community_Health_Care_Center.Models;
using System.Security.Claims;

namespace Qumbu_Community_Health_Care_Center.Controllers
{
    public class FamilyPlanController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public FamilyPlanController(ApplicationDbContext dbC)
        {
            dbContext = dbC;
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
        public IActionResult NoAccess()
        {
            return View();
        }
        public IActionResult CreateAppointment()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAppointment(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                dbContext.Appointments.Add(appointment);
                dbContext.SaveChanges();
                return RedirectToAction("ViewAppointment");
            }
            return View(appointment);
        }


        public ActionResult ViewAppointment()
        {
            IEnumerable<Appointment> oblList = dbContext.Appointments;
            return View(oblList);
        }




        public ActionResult VievContraceptives()
        {
            IEnumerable<Appointment> Contraceptives = dbContext.Appointments;
            return View(Contraceptives);
        }
        public ActionResult CreateScreening()
        {
            return View();
        }


        public ActionResult CreateFeedback()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateFeedback(Feedbacks feedback)
        {
            if (ModelState.IsValid)
            {
                dbContext.Feedbacks.Add(feedback);
                dbContext.SaveChanges();
                return RedirectToAction("ViewFeedback");
            }
            return View(feedback);
        }
        public ActionResult ViewFeedback()
        {
            IEnumerable<Feedbacks> feedlist = dbContext.Feedbacks;
            return View(feedlist);
        }
        public IActionResult CreateFamilyReg()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> CreateFamilyReg( FamilyReg familyReg)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
			familyReg.PatientID = user;
            int totalReg = 0;
			if (ModelState.IsValid)
            {
                totalReg += Convert.ToInt32(familyReg.intercourse);
                totalReg += Convert.ToInt32(familyReg.period);
                totalReg += Convert.ToInt32(familyReg.child);
                totalReg += Convert.ToInt32(familyReg.experience);
                totalReg += Convert.ToInt32(familyReg.allaegies);
                totalReg += Convert.ToInt32(familyReg.medication);
                totalReg += Convert.ToInt32(familyReg.contraceptives);
                totalReg += Convert.ToInt32(familyReg.condom);
                totalReg += Convert.ToInt32(familyReg.smoke);
                totalReg += Convert.ToInt32(familyReg.normal);
                if(totalReg == 30)
                {
                   TempData["Result"]= "Pill";
                }
                else if( totalReg == 40)
                {
                    TempData["Result"] = "1 month";
                }
                else if (totalReg == 50)
                {
                    TempData["Result"] = "3 months";
                }
                else if (totalReg == 60)
                {
                    TempData["Result"] = "1 implant";
                }
                else if (totalReg == 70)
                {
                    TempData["Result"] = "3 loop";
                }
                else if (totalReg == 80)
                {
                    TempData["Result"] = "Viginal Ring";
                }


                dbContext.FamilyReg.Add(familyReg);
                dbContext.SaveChanges();
                return RedirectToAction("ViewFamilyReg");

            }
			ViewData["PatientID"] = new SelectList(dbContext.Users, "Id", "Id", familyReg.PatientID);
			return View(familyReg);
		}

        public async Task <IActionResult> ViewFamilyReg()
        {
            var ApplicationDbContext = dbContext.FamilyReg.Include(f => f.MainUser);
            return View(await ApplicationDbContext.ToListAsync());
			//IEnumerable<FamilyReg> list = dbContext.FamilyReg;
			//return View(list);
		}
        public IActionResult ListFamilyRegNurse()
        {
            IEnumerable<FamilyReg> list = dbContext.FamilyReg;
            return View(list);
        }

		public ActionResult NurseAppointment()
		{
			IEnumerable<Appointment> oblList = dbContext.Appointments;
			return View(oblList);
		}
		public IActionResult updateAppointment(int? ID)
		{
			if (ID == null || ID == 0)
			{
				return NotFound();

			}
			var list = dbContext.Appointments.Find(ID);
			if (list == null)
			{
				return NotFound();
			}
			return View(list);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult updateAppointment(Appointment appointment)
		{
			dbContext.Appointments.Update(appointment);
			dbContext.SaveChanges();
			return RedirectToAction("ViewAppointment");
		}

		public IActionResult DeleteAppointment(int? ID)
		{
			var list = dbContext.Appointments.Find(ID);
			if (list == null)
			{
				return NotFound();
			}
			dbContext.Appointments.Remove(list);
			dbContext.SaveChanges();
			return RedirectToAction("ViewAppointment");

		}
        public ActionResult ViewReports()
        {
            return View();
        }

    }
}
