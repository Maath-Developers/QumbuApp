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
<<<<<<< HEAD
        public IActionResult patientList()
        {
            IEnumerable<PatientReg> list = dbContext.PatientReg;
            return View(list);
        }
=======
>>>>>>> bbaa07f14c9e1dfd5a2a9b23006839eed12aa88a
        public IActionResult Create_File()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
=======

>>>>>>> bbaa07f14c9e1dfd5a2a9b23006839eed12aa88a
        public IActionResult Create_File(PatientReg patientReg)
        {
            if (ModelState.IsValid)
            {
                dbContext.PatientReg.Add(patientReg);
                dbContext.SaveChanges();
<<<<<<< HEAD
                return RedirectToAction("fileList");
=======
                return RedirectToAction("patentList");
>>>>>>> bbaa07f14c9e1dfd5a2a9b23006839eed12aa88a
            }
            return View(patientReg);
        }
    }
}
