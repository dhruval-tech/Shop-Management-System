using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddProduct(ProductViewModel model)
        {
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
                return RedirectToAction("ViewProducts", "Product");
            }
           
            return View();
        }

        public IActionResult UpdateProduct()
        {
            return View();
        }

        public IActionResult DeleteProduct()
        {
            return View();
        }
        
        public IActionResult ViewProducts()
        {
            var productsList = _context.products.ToList();
            return View(productsList);
        }
        public IActionResult SearchProduct()
        {

            return View(_context.products.ToList());
        }


    }
}
