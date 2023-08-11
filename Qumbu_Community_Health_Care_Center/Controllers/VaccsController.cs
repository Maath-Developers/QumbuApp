using Microsoft.AspNetCore.Mvc;
using Qumbu_Community_Health_Care_Center.Models;
//using Qumbu_Community_Health_Care_Center.Data;
namespace Qumbu_Community_Health_Care_Center.Controllers
{
	public class VaccsController : Controller
	{
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

    }
}
