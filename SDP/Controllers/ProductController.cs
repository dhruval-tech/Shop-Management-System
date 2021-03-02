using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SDP.Data;
using SDP.Models;
using SDP.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace SDP.Controllers
{
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public ProductController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        [Authorize]
        public IActionResult AddProduct()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddProduct(ProductViewModel model)
        {
            HttpContext.Session.Remove("ProductName");
            ViewBag.PName = null;
            if (ModelState.IsValid) {
                string uniqueFileName = null;
                if (model.Photo != null){
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string FilePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(FilePath, FileMode.Create));
                }

                product newProduct = new product {

                    Name = model.Name,
                    Category = model.Category,
                    originalPrice = model.originalPrice,
                    MRP = model.MRP,
                    Quantity = model.Quantity,
                    Photopath = uniqueFileName
                };

                _context.Add(newProduct);
                _context.SaveChanges();
                HttpContext.Session.SetString("ProductName", model.Name);
                ViewBag.PName = model.Name;
                return RedirectToAction("ViewProducts", "Product");
            }
           
            return View();
        }
        static string photoPath = "";
        [HttpGet]
        public async Task<IActionResult>  UpdateProduct(int ?id)
        {
            product pd = await _context.products.FindAsync(id);
            photoPath = ""+pd.Photopath;
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
                    pd.Photopath = photoPath;
                    Console.WriteLine(photoPath);
                    //product newProduct = new product
                    //{

                    //    Name = pd.Name,
                    //    Category = pd.Category,
                    //    originalPrice = pd.originalPrice,
                    //    MRP = pd.MRP,
                    //    Quantity = pd.Quantity,
                    //    Photopath = photoPath
                    //};
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
        
        public IActionResult ViewProducts()
        {
            ViewBag.Email = null;
            ViewBag.Email = (HttpContext.Session.GetString("Email"));
            var productsList = _context.products.ToList();
            ViewBag.ProductName = (HttpContext.Session.GetString("ProductName"));
            return View(productsList);
        }

        
        public IActionResult SearchProduct()
        {

            return View(_context.products.ToList());
        }


    }
}
