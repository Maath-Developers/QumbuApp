using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using Qumbu_Community_Health_Care_Center.Models;

namespace Qumbu_Community_Health_Care_Center.Controllers
{
    public class PreNatalCareController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public PreNatalCareController(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
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
        public IActionResult PatientDashboard()
        {
            return View();
        }
        public IActionResult NurseDashboard()
        {
            return View();
        }
        public IActionResult IndexRecord()
        {
            IEnumerable<HealthRecord> objList = dbContext.HealthRecords;
            return View(objList);
        }
        [HttpGet]
        public IActionResult CreateRecord()
        {
            // Display a form for users to input health data
            return View();
        }
        [HttpPost]
        public IActionResult CreateRecord(HealthRecord record)
        {
            if (ModelState.IsValid)
            {
                // Save the recorded health data to the database
                dbContext.HealthRecords.Add(record);
                dbContext.SaveChanges();
                return RedirectToAction("RecordIndex"); // Redirect to dashboard
            }
            return View(record);
        }
    }
}
