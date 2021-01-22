using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SDP.Data;
using SDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.Controllers
{
    public class StaffController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public StaffController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddStaff(staff model)
        {

            if (ModelState.IsValid)
            {
                staff st = new staff
                {
                    email = model.email,
                    name = model.name,
                    contact = model.contact,
                    salary = model.salary,
                    address = model.address,
                    role = model.role
                };

                _context.Add(st);
                _context.SaveChanges();
                return RedirectToAction("ViewStaff","Staff");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateStaff(int? id)
        {
            staff st = await _context.staffs.FindAsync(id);

            if (st == null)
            {
                return NotFound();
            }

            return View(st);
        }
        [HttpPost]

        public async Task<IActionResult> UpdateStaff(staff st)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(st);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(ViewStaff));
            }

            return View(st);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteStaff(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            staff st = await _context.staffs.FindAsync(id);
            if (st == null)
            {
                return NotFound();
            }

            return View(st);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            var st = await _context.staffs.FindAsync(id);
            _context.staffs.Remove(st);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ViewStaff));
        }

        public IActionResult ViewStaff()
        {
            return View(_context.staffs.ToList());
        }
    }
}
