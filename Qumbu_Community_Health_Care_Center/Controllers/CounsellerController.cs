using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using Qumbu_Community_Health_Care_Center.Models;
using System.IO;


namespace Qumbu_Community_Health_Care_Center.Controllers

{
    public class CounsellerController : Controller
    {
        private readonly ApplicationDbContext Context;
        public CounsellerController(ApplicationDbContext DbContext)
        {
            Context = DbContext;
        }
        public IActionResult Patient()
        {
            return View();
        }
        public IActionResult Admin_Clerk()
        {
            return View();
        }
        public IActionResult Counsellor()
        {
            return View();
        }
        public IActionResult NoAccess()
        {
            return View();
        }
        public IActionResult Booking()
        {
            IEnumerable<Bookings> book = Context.Bookings;
            return View(book);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Bookings book)
        {
            if (ModelState.IsValid)
            {
                Context.Bookings.Add(book);
                Context.SaveChanges();
                return RedirectToAction("Booking");
            }
            return View(book);
        }
        public IActionResult PatientC()
        {
            IEnumerable<PatientReg> pat = Context.PatientReg;
            return View(pat);
        }
        public IActionResult CreateR()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateR(PatientReg pat)
        {
            if (ModelState.IsValid)
            {
                Context.PatientReg.Add(pat);
                Context.SaveChanges();
                return RedirectToAction("PatientC");
            }
            return View(pat);
        }
        public IActionResult Record()
        {
            IEnumerable<PatientReg> pat = Context.PatientReg;
            return View(pat);
        }
        public IActionResult CreateRe()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRe(Profiling pro)
        {
            if (ModelState.IsValid)
            {
                Context.Profiling.Add(pro);
                Context.SaveChanges();
                return RedirectToAction("IndRec");
            }
            return View(pro);
        }
        public IActionResult Update(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var obj = Context.PatientReg.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }
        //POST-Update updating the current data we have 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(PatientReg pat)
        {
            Context.PatientReg.Update(pat);
            Context.SaveChanges();
            return RedirectToAction("PatientC");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? ID)
        {
            var obj = Context.Profiling.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            Context.Profiling.Remove(obj);
            Context.SaveChanges();
            return RedirectToAction("Profile");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteRef(int? ID)
        {
            var obj = Context.Profiling.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            Context.Profiling.Remove(obj);
            Context.SaveChanges();
            return RedirectToAction("Referral");
        }
        public IActionResult UpdateRe(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var obj = Context.Profiling.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }
        //POST-Update updating the current data we have 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateRe(PatientReg pat)
        {
            Context.PatientReg.Update(pat);
            Context.SaveChanges();
            return RedirectToAction("Record");
        }
        public IActionResult CreateF()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateF(Referral referral)
        {
            if (ModelState.IsValid)
            {
                Context.Referral.Add(referral);
                Context.SaveChanges();
                return RedirectToAction("Referral");
            }
            return View(referral);
        }
        public IActionResult Referral()
        {
            IEnumerable<Referral> Referrals = Context.Referral;
            return View(Referrals);
        }
        public ActionResult Reports()
        {
            IEnumerable<Profiling> profilings = Context.Profiling;
            return View(profilings);
        }
        public IActionResult Profile()
        {
            IEnumerable<Profiling> profilings = Context.Profiling;
            return View(profilings);
        }
        public IActionResult CreateP() 
        { 
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateP(Profiling pro) 
        {
            if (ModelState.IsValid)
            {
                Context.Profiling.Add(pro);
                Context.SaveChanges();
                return RedirectToAction("Profile");
            }
            return View(pro);
        }
        public IActionResult CreateConf()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateConf(Profiling pro)
        {
            if (ModelState.IsValid)
            {
                Context.Profiling.Add(pro);
                Context.SaveChanges();
                return RedirectToAction("Profile");
            }
            return View(pro);
        }
        public IActionResult CreateG()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateG(Profiling pro)
        {
            if (ModelState.IsValid)
            {
                Context.Profiling.Add(pro);
                Context.SaveChanges();
                return RedirectToAction("Profile");
            }
            return View(pro);
        }
        public IActionResult CreatePat()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePat(Profiling pro)
        {
            if (ModelState.IsValid)
            {
                Context.Profiling.Add(pro);
                Context.SaveChanges();
                return RedirectToAction("VisitRec");
            }
            return View(pro);
        }
        public IActionResult IndRec()
        {
            IEnumerable<Profiling> profilings = Context.Profiling;
            return View(profilings);
        }
        public IActionResult VisitRec()
        {
            IEnumerable<Profiling> profilings = Context.Profiling;
            return View(profilings);
        }


    }
}

