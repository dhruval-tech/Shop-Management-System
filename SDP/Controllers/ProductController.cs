using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SDP.Data;
using SDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SDP.Controllers
{
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult AddProduct()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddProduct(product pd)
        {
            _context.Add(pd);
            _context.SaveChanges();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult>  UpdateProduct(int ?id)
        {
            product pd = await _context.products.FindAsync(id);

            if (pd == null)
            {
                return NotFound();
            }

            return View(pd);
        }
        [HttpPost]

        public async Task<IActionResult> UpdateProduct(product pd)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pd);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(SearchProduct));
            }

            return View(pd);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteProduct(int ?id)
        {
            if (id == null)
            {
                return NotFound();
            }
            product pd = await _context.products.FindAsync(id);
            if (pd == null)
            {
                return NotFound();
            }

            return View(pd);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var pd = await _context.products.FindAsync(id);
            _context.products.Remove(pd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(SearchProduct));
        }

        
        public IActionResult SearchProduct()
        {

            return View(_context.products.ToList());
        }


    }
}
