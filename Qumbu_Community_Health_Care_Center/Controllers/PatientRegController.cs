using Microsoft.AspNetCore.Mvc;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using Qumbu_Community_Health_Care_Center.Models;

namespace Qumbu_Community_Health_Care_Center.Controllers
{
    public class PatientRegController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public PatientRegController(ApplicationDbContext dBD)
        {
            dbContext= dBD;
        }
        public IActionResult fileList()
        {
            IEnumerable<PatientReg> list = dbContext.PatientReg;
            return View(list);
        }
        public IActionResult Create_File()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create_File(PatientReg patientReg)
        {
            if (ModelState.IsValid)
            {
                dbContext.PatientReg.Add(patientReg);
                dbContext.SaveChanges();
                return RedirectToAction("patentList");
            }
            return View(patientReg);
        }
    }
}
