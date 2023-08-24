using Microsoft.AspNetCore.Mvc;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using Qumbu_Community_Health_Care_Center.Models;
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
		public IActionResult Index()
        {
            IEnumerable<ScreeningTool> objList = dbContext.Srcreening;
            return View(objList);
        }
        public IActionResult Indexscree()
        {
            return View();
        }
        public IActionResult IndexFee()
        {
            return View();
        }
        public IActionResult IndexAppo()
        {
            return View();
        }
        public IActionResult IndexRecord() 
        { 
            return View();
        }
        public IActionResult IndexReport()
        {
            return View();
        }
        public IActionResult IndexStock()
        {
            return View();
        }
        //public IActionResult IndexAppointment()
        //{
        //    IEnumerable<VaccsAppointment> objList = dbContext.VaccinationAppointment;
        //    return View(objList);

        //}
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(VaccsAppointment Appo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        dbContext.VaccinationAppointment.Add(Appo);
        //        dbContext.SaveChanges();
        //        return RedirectToAction("IndexAppointment");
        //    }
        //    return View(Appo);

        //}
        //public IActionResult Update(int? ID)
        //{
        //    if (ID == null || ID == 0)
        //    {
        //        return NotFound();
        //    }
        //    var obj = dbContext.VaccinationAppointment.Find(ID);

        //    if (ID == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(obj);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Update(VaccsAppointment appo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        dbContext.VaccinationAppointment.Update(appo);
        //        dbContext.SaveChanges();
        //        return RedirectToAction("IndexAppointment");
        //    }
        //    return View(appo);
        //}


        //This method adds data to the database using the ApplicationDBContext and Saves the data and redirects the user to the Index page
        //POST-Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(ScreeningTool scre)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        dbContext.Srcreening.Add(scre);
        //        dbContext.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(scre);

        //}


    }
}
