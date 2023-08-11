using Microsoft.AspNetCore.Mvc;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using Qumbu_Community_Health_Care_Center.Models;


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
            if(ModelState.IsValid)
            {
                dbContext.Appointments.Add(appointment);
                dbContext.SaveChanges();
                return RedirectToAction("ViewAppointment");
            }
			return View(appointment);
		}


        public ActionResult ViewAppointment()
        {
            IEnumerable<Appointment>oblList=dbContext.Appointments;
            return View(oblList);
        } 
        public ActionResult VievContraceptives()
        {
            IEnumerable<Appointment>Contraceptives=dbContext.Appointments;
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
				return RedirectToAction("ViewAppointment");
			}
			return View(feedback);
		}


	}
}
