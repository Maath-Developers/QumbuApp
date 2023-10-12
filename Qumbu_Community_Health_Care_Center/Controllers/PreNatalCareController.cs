using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        //public IActionResult PatientDashboard()
        //{
        //    return View();
        //}
        public IActionResult NurseDashboard()
        {
            return View();
        }
        public IActionResult IndexRecord()
        {
            IEnumerable<HealthRecord> objList = dbContext.HealthRecords;
            return View(objList);
        }
        public IActionResult IndexAppointment()
        {
            IEnumerable<Appointment> objList = dbContext.Appointments;
            return View(objList);
        }
        [HttpGet]
        public IActionResult CreateRecord()
        {
            // Display a form for users to input health data
            return View();
        }
        [HttpGet]
        public IActionResult CreateAppointment()
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
                return RedirectToAction("IndexRecord"); // Redirect to dashboard
            }
            return View(record);
        }
        public IActionResult CreateAppointment(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                // Save the recorded health data to the database
                dbContext.Appointments.Add(appointment);
                dbContext.SaveChanges();
                return RedirectToAction("IndexAppointment"); // Redirect to dashboard
            }
            return View(appointment);
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
        public IActionResult UpdateAppointment(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var obj = dbContext.Appointments.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
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

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateAppointment(Appointment appointment)
        {
            dbContext.Appointments.Update(appointment);
            dbContext.SaveChanges();
            return RedirectToAction("IndexAppointment");
        }
        public IActionResult Delete(int? ID)
        {
            var obj = dbContext.Appointments.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            dbContext.Appointments.Remove(obj);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult IndexUltrasoundAppointment()
        {
            IEnumerable<UltrasoundAppointment> objList = dbContext.Ultrasounds;
            //return View(dbContext.ultrasounds.ToList());
            return View(objList);

        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult CreateUltrasoundAppointment(UltrasoundAppointment ultrasound)
        {
            string uniqueFileName = null;
            if (ultrasound.ImageFile != null)
            {
                string ImageUploadedFolder = Path.Combine
                    (webHostEnvironment.WebRootPath, "UploadedImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + ultrasound.ImageFile.FileName;

                string filepath = Path.Combine(ImageUploadedFolder, uniqueFileName);

                using (var fileStream = new FileStream(filepath, FileMode.Create))
                {
                    ultrasound.ImageFile.CopyTo(fileStream);
                }
                ultrasound.UltrasoundImagePath = "~/wwwroot/UploadedImages";
                ultrasound.FileName = uniqueFileName;

                dbContext.Ultrasounds.Add(ultrasound);
                dbContext.SaveChanges();
                return RedirectToAction("IndexUltrasoundAppointment", "PrenatalCare");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateUltrasound(UltrasoundAppointment ultrasound)
        {
            string uniqueFileName = null;
            if (ultrasound.ImageFile != null)
            {
                string ImageUploadedFolder = Path.Combine
                    (webHostEnvironment.WebRootPath, "UploadedImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + ultrasound.ImageFile.FileName;

                string filepath = Path.Combine(ImageUploadedFolder, uniqueFileName);

                using (var fileStream = new FileStream(filepath, FileMode.Create))
                {
                    ultrasound.ImageFile.CopyTo(fileStream);
                }
                ultrasound.UltrasoundImagePath = "~/wwwroot/UploadedImages";
                ultrasound.FileName = uniqueFileName;

                dbContext.Ultrasounds.Update(ultrasound);
                dbContext.SaveChanges();
                return RedirectToAction("IndexUltrasoundAppointment", "PrenatalCare");
            }
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
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeleteUltrasound(UltrasoundAppointment ultrasound)
        //{
        //    string uniqueFileName = null;
        //    if (ultrasound.ImageFile != null)
        //    {
        //        string ImageUploadedFolder = Path.Combine
        //            (webHostEnvironment.WebRootPath, "UploadedImages");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + ultrasound.ImageFile.FileName;

        //        string filepath = Path.Combine(ImageUploadedFolder, uniqueFileName);

        //        using (var fileStream = new FileStream(filepath, FileMode.Create))
        //        {
        //            ultrasound.ImageFile.CopyTo(fileStream);
        //        }
        //        ultrasound.UltrasoundImagePath = "~/wwwroot/UploadedImages";
        //        ultrasound.FileName = uniqueFileName;

        //        dbContext.Ultrasounds.Remove(ultrasound);
        //        dbContext.SaveChanges();
        //        return RedirectToAction("IndexUltrasoundAppointment", "PrenatalCare");
        //    }
        //    return View();
        //}
        public IActionResult IndexEducation()
        {
            IEnumerable<PrenatalEducation> objList = dbContext.prenatalEducation;
            return View(objList);
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult CreateEducation(PrenatalEducation prenatalEducation)
        {
            string uniqueFileName = null;
            if (prenatalEducation.CoverImage != null)
            {
                string ImageUploadedFolder = Path.Combine
                    (webHostEnvironment.WebRootPath, "UploadedImages");
                uniqueFileName = Guid.NewGuid().ToString() + " " + prenatalEducation.CoverImage.FileName;

                string filepath = Path.Combine(ImageUploadedFolder, uniqueFileName);

                using (var fileStream = new FileStream(filepath, FileMode.Create))
                {
                    prenatalEducation.CoverImage.CopyTo(fileStream);
                }
                prenatalEducation.CoverImagePath = "~/wwwroot/UploadedImages";
                prenatalEducation.FileName = uniqueFileName;

                dbContext.prenatalEducation.Add(prenatalEducation);
                dbContext.SaveChanges();
                return RedirectToAction("IndexEducation", "PrenatalCare");
            }
            return View();
        }
        public IActionResult EducationDetails(int? ID)
        {
            if(ID == null || ID == 0)
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
    }
}
