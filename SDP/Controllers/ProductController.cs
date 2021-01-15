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

        public IActionResult UpdateProduct()
        {
            return View();
        }

        public IActionResult DeleteProduct()
        {
            return View();
        }

        public IActionResult SearchProduct()
        {

            return View(_context.products.ToList());
        }


    }
}
