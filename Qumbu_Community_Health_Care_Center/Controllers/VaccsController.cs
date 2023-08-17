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
