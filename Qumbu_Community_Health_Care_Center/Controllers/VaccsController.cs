using Microsoft.AspNetCore.Mvc;

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

	}
}
