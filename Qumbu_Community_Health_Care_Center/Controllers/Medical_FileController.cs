﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;
using Qumbu_Community_Health_Care_Center.Models;

namespace Qumbu_Community_Health_Care_Center.Controllers
{
    public class Medical_FileController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Medical_FileController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult MyFile()
        {
            return View();
        }
        // GET: Medical_File
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Medical_File.Include(m => m.mainUser);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> My_Medical_File()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var applicationDbContext = _context.Medical_File.Where(a => a.PatientID ==user).Include(m => m.mainUser);
            ViewBag.File = _context.Medical_File.Where(a => a.PatientID ==user).Include(m => m.mainUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Medical_File/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Medical_File == null)
            {
                return NotFound();
            }

            var medical_File = await _context.Medical_File
                .Include(m => m.mainUser)
                .FirstOrDefaultAsync(m => m.fileId == id);
            if (medical_File == null)
            {
                return NotFound();
            }

            return View(medical_File);
        }
        public IActionResult Create_File()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.App = _context.Appointments.Where(a => a.PatientID == user).ToList();
            ViewBag.Patient = (from U in _context.Users
                               join UR in _context.UserRoles on U.Id equals UR.UserId
                               join R in _context.Roles on UR.RoleId equals R.Id
                               where R.Name == "Patient"
                               select U).ToList();

            return View();
        }

    
        // GET: Medical_File/Create
        public IActionResult Create()
        {
            ViewData["PatientID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create_File(Medical_File medical_File)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            medical_File.PatientID = user;
            if (ModelState.IsValid)
            {
                _context.Add(medical_File);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.file = _context.Medical_File.Where(a => a.PatientID == user).ToList();
            ViewData["PatientID"] = new SelectList(_context.Users, "Id", "Id", medical_File.PatientID);
            return View(medical_File);
        }

        // POST: Medical_File/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Medical_File medical_File)
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            medical_File.PatientID = user;
            if (ModelState.IsValid)
            {
                _context.Add(medical_File);
                await _context.SaveChangesAsync();
                TempData["File"] = "File Successfully Created ";
                return RedirectToAction(nameof(My_Medical_File));
            }
            ViewData["PatientID"] = new SelectList(_context.Users, "Id", "Id", medical_File.PatientID);
            return RedirectToAction("Create");
        }

        // GET: Medical_File/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Medical_File == null)
            {
                return NotFound();
            }

            var medical_File = await _context.Medical_File.FindAsync(id);
            if (medical_File == null)
            {
                return NotFound();
            }
            ViewData["PatientID"] = new SelectList(_context.Users, "Id", "Id", medical_File.PatientID);
            return View(medical_File);
        }

        // POST: Medical_File/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("fileId,PatientID,IDNumber,DateofBirth,Gender,Status,Address,Province,postalCode,NextfoKin,kinCell,Relationship,BloodType,Allergies,Surgery,extraNotes")] Medical_File medical_File)
        {
            if (id != medical_File.fileId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medical_File);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Medical_FileExists(medical_File.fileId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PatientID"] = new SelectList(_context.Users, "Id", "Id", medical_File.PatientID);
            return View(medical_File);
        }

        // GET: Medical_File/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Medical_File == null)
            {
                return NotFound();
            }

            var medical_File = await _context.Medical_File
                .Include(m => m.mainUser)
                .FirstOrDefaultAsync(m => m.fileId == id);
            if (medical_File == null)
            {
                return NotFound();
            }

            return View(medical_File);
        }

        // POST: Medical_File/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Medical_File == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Medical_File'  is null.");
            }
            var medical_File = await _context.Medical_File.FindAsync(id);
            if (medical_File != null)
            {
                _context.Medical_File.Remove(medical_File);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Medical_FileExists(int id)
        {
            return (_context.Medical_File?.Any(e => e.fileId == id)).GetValueOrDefault();
        }
    }
}
