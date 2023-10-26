﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using Qumbu_Community_Health_Care_Center.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Qumbu_Community_Health_Care_Center.Controllers
{
    public class PreNatalCareController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        public PreNatalCareController(ApplicationDbContext _dbContext, IWebHostEnvironment _webHostEnvironment)
        {
            dbContext = _dbContext;
            webHostEnvironment = _webHostEnvironment;
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
        public IActionResult NurseDashboard()
        {
            return View();
        }
        public async Task<IActionResult> Report()
        {
            ViewBag.Date = DateTime.Now.ToString("dd/mmmm/yyyy");
            ViewBag.Time = DateTime.Now.ToString("HH:MM");
            var applicationDbContext = dbContext.Ultrasounds.Include(a => a.MainUser).ToList();
            return View(applicationDbContext);
        }
        public  IActionResult IndexRecord()
        {
            IEnumerable<HealthRecord> objList = dbContext.HealthRecords.Include(a => a.MainUser);
            return View(objList);
        }
        [HttpGet]
        public IActionResult CreateRecord()
        {
            ViewBag.Patients = (from U in dbContext.Users
                                join UR in dbContext.UserRoles on U.Id equals UR.UserId
                                join R in dbContext.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRecord(HealthRecord record)
        {
            if (ModelState.IsValid)
            {
                dbContext.HealthRecords.Add(record);
                dbContext.SaveChanges();
                return RedirectToAction("IndexRecord");
            }

            ViewBag.Patients = (from U in dbContext.Users
                                join UR in dbContext.UserRoles on U.Id equals UR.UserId
                                join R in dbContext.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();

            return View(record);
        }
        public IActionResult UpdateRecord(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var obj = dbContext.HealthRecords.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }
             ViewBag.Patients = (from U in dbContext.Users
                                join UR in dbContext.UserRoles on U.Id equals UR.UserId
                                join R in dbContext.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateRecord(HealthRecord record)
        {
            dbContext.HealthRecords.Update(record);
            dbContext.SaveChanges();
            return RedirectToAction("IndexRecord");
        }
        public IActionResult IndexUltrasoundAppointment()
        {
            IEnumerable<UltrasoundAppointment> objList = dbContext.Ultrasounds.Include(a => a.MainUser);
            return View(objList);

        }
        public IActionResult CreateUltrasoundAppointment()
        {
            ViewBag.Patients = (from U in dbContext.Users
                                join UR in dbContext.UserRoles on U.Id equals UR.UserId
                                join R in dbContext.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUltrasoundAppointment(UltrasoundAppointment ultrasound)
        {
            if (ModelState.IsValid)
            {
                if (ultrasound.ImageFile != null)
                {
                    string folder = "UploadedFiles/FetalImage/";
                    folder += Guid.NewGuid().ToString() + ultrasound.ImageFile.FileName;
                    ultrasound.UltrasoundImagePath = "/" + folder;
                    string serverFolder = Path.Combine(webHostEnvironment.WebRootPath, folder);
                    ultrasound.ImageFile.CopyTo(new FileStream(serverFolder, FileMode.Create));

                    dbContext.Ultrasounds.Add(ultrasound);
                    dbContext.SaveChanges();
                    return RedirectToAction("IndexUltrasoundAppointment", "PrenatalCare");
                } 

            }
            ViewBag.Patients = (from U in dbContext.Users
                                join UR in dbContext.UserRoles on U.Id equals UR.UserId
                                join R in dbContext.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
            return View();

        }
        [HttpGet]
        public IActionResult UpdateUltrasound(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var obj = dbContext.Ultrasounds.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }
            ViewBag.Patients = (from U in dbContext.Users
                                join UR in dbContext.UserRoles on U.Id equals UR.UserId
                                join R in dbContext.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateUltrasound(UltrasoundAppointment ultrasound)
        {
            if (ultrasound.ImageFile != null)
            {
                string folder = "UploadedFiles/FetalImage/";
                folder += Guid.NewGuid().ToString() + ultrasound.ImageFile.FileName;
                ultrasound.UltrasoundImagePath = "/" + folder;
                string serverFolder = Path.Combine(webHostEnvironment.WebRootPath, folder);
                ultrasound.ImageFile.CopyTo(new FileStream(serverFolder, FileMode.Create));

                dbContext.Ultrasounds.Update(ultrasound);
                dbContext.SaveChanges();
                return RedirectToAction("IndexUltrasoundAppointment", "PrenatalCare");
            }
            ViewBag.Patients = (from U in dbContext.Users
                                join UR in dbContext.UserRoles on U.Id equals UR.UserId
                                join R in dbContext.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
            return View();
        }
        public IActionResult DeleteUltrasound(int? ID)
        {
            var obj = dbContext.Ultrasounds.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            dbContext.Ultrasounds.Remove(obj);
            dbContext.SaveChanges();
            return RedirectToAction("IndexUltrasoundAppointment", "PrenatalCare");

            //var Ultrasound =  dbContext.Ultrasounds.Find(ID);
            //var folder = Path.Combine(webHostEnvironment.WebRootPath, "UploadedFiles/FetalImage/", Ultrasound.UltrasoundImagePath);
            //if (System.IO.File.Exists(folder))
            //    dbContext.Ultrasounds.Remove(Ultrasound);
            //dbContext.SaveChanges();
            //return RedirectToAction("IndexUltrasoundAppointment", "PrenatalCare");
        }
        public IActionResult IndexEducation()
        {
            IEnumerable<PrenatalEducation> objList = dbContext.prenatalEducation;
            return View(objList);
        }
        public IActionResult CreateEducation()
        {
            ViewBag.Patients = (from U in dbContext.Users
                                join UR in dbContext.UserRoles on U.Id equals UR.UserId
                                join R in dbContext.Roles on UR.RoleId equals R.Id
                                where R.Name == "Patient"
                                select U).ToList();
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEducation(PrenatalEducation prenatalEducation)
        {
            if (ModelState.IsValid)
            {
                if (prenatalEducation.CoverImage != null)
                {
                    string folder = "UploadedFiles/FetalImage/";
                    folder += Guid.NewGuid().ToString() + prenatalEducation.ContentPdf.FileName;
                    prenatalEducation.ImageUrl = "/" + folder;
                    string serverFolder = Path.Combine(webHostEnvironment.WebRootPath, folder);
                    prenatalEducation.CoverImage.CopyTo(new FileStream(serverFolder, FileMode.Create));
                }
                if (prenatalEducation.ContentPdf != null)
                {
                    string folder = "UploadedFiles/Pdf/";
                    folder += Guid.NewGuid().ToString() + prenatalEducation.ContentPdf.FileName;
                    prenatalEducation.PdfUrl = "/" + folder;
                    string serverFolder = Path.Combine(webHostEnvironment.WebRootPath, folder);
                    prenatalEducation.ContentPdf.CopyTo(new FileStream(serverFolder, FileMode.Create));

                    dbContext.prenatalEducation.Add(prenatalEducation);
                    dbContext.SaveChanges();
                    return RedirectToAction("IndexEducation", "PrenatalCare");
                }
            }
             

            return View();
        }
        public IActionResult EducationDetails(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var obj = dbContext.prenatalEducation.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        public IActionResult UpdatePrenatalEducation(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var obj = dbContext.prenatalEducation.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePrenatalEducation(PrenatalEducation prenatalEducation)
        {

            if (prenatalEducation.CoverImage != null)
            {
                string folder = "UploadedFiles/FetalImage/";
                folder += Guid.NewGuid().ToString() + prenatalEducation.ContentPdf.FileName;
                prenatalEducation.ImageUrl = "/" + folder;
                string serverFolder = Path.Combine(webHostEnvironment.WebRootPath, folder);
                prenatalEducation.CoverImage.CopyTo(new FileStream(serverFolder, FileMode.Create));
            }
            if (prenatalEducation.ContentPdf != null)
            {
                string folder = "UploadedFiles/Pdf/";
                folder += Guid.NewGuid().ToString() + prenatalEducation.ContentPdf.FileName;
                prenatalEducation.PdfUrl = "/" + folder;
                string serverFolder = Path.Combine(webHostEnvironment.WebRootPath, folder);
                prenatalEducation.ContentPdf.CopyTo(new FileStream(serverFolder, FileMode.Create));

                dbContext.prenatalEducation.Update(prenatalEducation);
                dbContext.SaveChanges();
                return RedirectToAction("IndexEducation", "PrenatalCare");
            }


            return View();
        }
        public IActionResult DeletePrenatalEducation(int? ID)
        {
            var obj = dbContext.prenatalEducation.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            dbContext.prenatalEducation.Remove(obj);
            dbContext.SaveChanges();
            return RedirectToAction("IndexEducation", "PrenatalCare");
        }
    }
}
