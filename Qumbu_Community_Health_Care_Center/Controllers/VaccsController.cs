using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using Qumbu_Community_Health_Care_Center.Models;
using System.Security.Claims;
//using Qumbu_Community_Health_Care_Center.Data;
namespace Qumbu_Community_Health_Care_Center.Controllers
{
	public class VaccsController : Controller
	{
        private readonly ApplicationDbContext dbContext;

        public VaccsController(ApplicationDbContext dBD)
        {
            dbContext = dBD;
        }
        public IActionResult Patient()
		{
			return View();
		}
		public IActionResult Admin_Clerk()
		{
			return View();
		}
		public IActionResult Doctor()
		{
			return View();
		}
        public IActionResult Nurse()
        {
            return View();
        }
        public IActionResult Unit_Manager()
		{
			return View();
		}
        public IActionResult NoAccess()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }

        public async Task<IActionResult> Indexscree()
        {
            var ApplicationDbContext = dbContext.Srcreening.Include(f => f.MainUser);
            return View(await ApplicationDbContext.ToListAsync());
        }
        public IActionResult Screen()
		{

            
            return View();

        }
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Screen(ScreeningTool Scree)
		{
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Scree.PatientID = user;
            int Total = 0;
			if (ModelState.IsValid)
			{
				Total = Convert.ToInt32(Scree.Question1);
				Total = Convert.ToInt32(Scree.Question2);
				Total = Convert.ToInt32(Scree.Question3);
				Total = Convert.ToInt32(Scree.Question4);
				Total = Convert.ToInt32(Scree.Question5);
				Total = Convert.ToInt32(Scree.Question6);
				//if (Total <= 30)
				//{
				//	TempData["Result"] = "  ";
				//	TempData["_Image"] = "1";
				//}

				dbContext.Srcreening.Add(Scree);
				dbContext.SaveChanges();
				return RedirectToAction("Indexscree");
			}
            ViewData["PatientID"] = new SelectList(dbContext.Users, "Id", "Id", Scree.PatientID);
            return View(Scree);

		}
        public IActionResult UpdateScreening(int? ScreeningID)
        {
            if (ScreeningID == null || ScreeningID == 0)
            {
                return NotFound();
            }
            var obj = dbContext.Srcreening.Find(ScreeningID);

            if (ScreeningID == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateScreening(ScreeningTool Scree)
        {
            if (ModelState.IsValid)
            {
                dbContext.Srcreening.Update(Scree);
                dbContext.SaveChanges();
                return RedirectToAction("IndexScree");
            }
            return View(Scree);
        }
        public IActionResult DeleteScreen(int? ScreeningID)
        {
            var obj = dbContext.Srcreening.Find(ScreeningID);

            if (obj == null)
            {
                return NotFound();
            }
            dbContext.Srcreening.Remove(obj);
            dbContext.SaveChanges();
            return RedirectToAction("IndexScree");
        }
        public IActionResult IndexFeedback()
        {
            IEnumerable<FeedbackV> objList = dbContext.VaccinationFeedback;
            return View(objList);
        }
        public IActionResult VaccineFeedback()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult VaccineFeedback(FeedbackV Fee)
        {
           
            if (ModelState.IsValid)
            {
                dbContext.VaccinationFeedback.Add(Fee);
                dbContext.SaveChanges();
                return RedirectToAction("IndexFeedback");
            }
            return View(Fee);

        }


        public IActionResult IndexEducation()
		{
			IEnumerable<VaccinationEducation> objList = dbContext.VaccineEducation;
			return View(objList);
		}
		public IActionResult Education()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Education(VaccinationEducation Edu)
		{
			if (ModelState.IsValid)
			{
				dbContext.VaccineEducation.Add(Edu);
				dbContext.SaveChanges();
				return RedirectToAction("IndexEducation");
			}
			return View(Edu);

		}
        public IActionResult IndexAppo()
        {
            return View();
        }
        public IActionResult IndexRecord() 
        {
            IEnumerable<Vaccine_MadicalRecord> objList = dbContext.vaccinerecord;
            return View(objList);
        }
        public IActionResult Record()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Record(Vaccine_MadicalRecord reco)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            reco.NurseID = user;
            if (ModelState.IsValid)
            {
                dbContext.vaccinerecord.Add(reco);
                dbContext.SaveChanges();
                return RedirectToAction("IndexRecord");
            }
            ViewData["PatientID"] = new SelectList(dbContext.Users, "Id", "Id", reco.NurseID);
            return View(reco);
        }

        public IActionResult IndexReport()
        {

			IEnumerable<Vaccine_MadicalRecord> objList = dbContext.vaccinerecord;
			return View(objList);
			
        }
        public IActionResult IndexStock()
        {
            return View();
        }
        public IActionResult IndexOrder()
        {
            return View();
        }
    }
}
