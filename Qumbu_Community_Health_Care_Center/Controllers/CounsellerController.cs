﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using Qumbu_Community_Health_Care_Center.Models;
using System.IO;
using System.Security.Claims;

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
            ViewBag.Patients = (from U in Context.Users
                                join UR in Context.UserRoles on U.Id equals UR.UserId
                                join R in Context.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRe([Bind("ProfileID,PatientID,Background,CounsellingApproach,Goals,comments,recom")] Profiling pro)
        {
            //var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //pro.PatientID = user;
            if (ModelState.IsValid)
            {
                ViewBag.Date = DateTime.Now.ToString("dd/mm/yyyy");
                ViewBag.Time = DateTime.Now.ToString("HH:MM");
                Context.Profiling.Add(pro);
                Context.SaveChanges();
                TempData["Success"] = "Succesfully added a new record";
                return RedirectToAction("IndRec");
            }
            ViewBag.Patients = (from U in Context.Users
                                join UR in Context.UserRoles on U.Id equals UR.UserId
                                join R in Context.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
            return View(pro);
        }
        public IActionResult NewUpdate(int? ID)
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
            ViewBag.Patients = (from U in Context.Users
                                join UR in Context.UserRoles on U.Id equals UR.UserId
                                join R in Context.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
            return View(obj);

        }
        //POST-Update updating the current data we have 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewUpdate(Profiling pro)
        {
            Context.Profiling.Update(pro);
            Context.SaveChanges();
            TempData["Success"] = "Details Succesfully Updated";
            return RedirectToAction("NewUpdate");
        }
        public IActionResult DeleteReferrals(int? ID)
        {
            var obj = Context.Referral.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }
            Context.Referral.Remove(obj);
            Context.SaveChanges();
            TempData["Success"] = "A referral has been deleted";
            return RedirectToAction("Referral");

        }
        public IActionResult DeleteLogs(int? ID)
        {
            var obj = Context.Profiling.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }
            Context.Profiling.Remove(obj);
            Context.SaveChanges();
            TempData["Success"] = "A log has been deleted";
            return RedirectToAction("CreatePat");

        }
        public IActionResult UpdateReferral(int? ID)
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
            ViewBag.Patients = (from U in Context.Users
                                join UR in Context.UserRoles on U.Id equals UR.UserId
                                join R in Context.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
            return View(obj);

        }
        //POST-Update updating the current data we have 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateReferral(PatientReg pat)
        {
            Context.PatientReg.Update(pat);
            Context.SaveChanges();
            return RedirectToAction("Referral");
        }
        public IActionResult CreateF()
        {
            ViewBag.Patients = (from U in Context.Users
                                join UR in Context.UserRoles on U.Id equals UR.UserId
                                join R in Context.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateF(Referrals referral)
        {
            if (ModelState.IsValid)
            {
                Context.Referral.Add(referral);
                Context.SaveChanges();
                TempData["Success"] = "A referral has been added";
                return RedirectToAction("CreateF");
            }
            return View(referral);
        }
        public IActionResult Referral()
        {
            IEnumerable<Referrals> Referrals = Context.Referral.Include(a => a.MainUser);
            return View(Referrals);
        } 
        public IActionResult PatientReferral()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IEnumerable<Referrals> Referrals = Context.Referral.Where(a => a.PatientID == user).Include(a => a.MainUser);
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
              ViewBag.Patients = (from U in Context.Users
                                join UR in Context.UserRoles on U.Id equals UR.UserId
                                join R in Context.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
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
                return RedirectToAction("GroupRec");
            }
            return View(pro);
        }
        public IActionResult CreatePat()
        {
            ViewBag.Patients = (from U in Context.Users
                                join UR in Context.UserRoles on U.Id equals UR.UserId
                                join R in Context.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
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
            IEnumerable<Profiling> profilings = Context.Profiling.Include(a => a.MainUser);
            return View(profilings);
        } 
        public IActionResult PatientRec()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IEnumerable<Profiling> profilings = Context.Profiling.Where(a => a.PatientID == user).Include(a => a.MainUser);
            return View(profilings);
        }  
        public IActionResult PatientVisitRec()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IEnumerable<Profiling> profilings = Context.Profiling.Where(a => a.PatientID == user).Include(a => a.MainUser);
            return View(profilings);
        } 
        public IActionResult VisitRec()
        {
            IEnumerable<Profiling> profilings = Context.Profiling.Include(a => a.MainUser);
            return View(profilings);
        }  
        public IActionResult IndividualRec()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var applicationDbContext = Context.Profiling.Where(a => a.PatientID == user).Include(a => a.MainUser).FirstOrDefault();
            ViewBag.Patients = (from U in Context.Users
                                join UR in Context.UserRoles on U.Id equals UR.UserId
                                join R in Context.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
            return View(applicationDbContext);
        }

    }
}

