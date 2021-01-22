using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SDP.ViewModels;
using SDP.Models;
using SDP.Data;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.Collections;
using Microsoft.Data.SqlClient;

namespace SDP.Controllers
{
    public class CustomerController : Controller
    {
        

        private readonly ApplicationDbContext _context;
        
        private readonly IHostingEnvironment hostingEnvironment;
        ArrayList productlist = new ArrayList();
        int qty;
        int pro_id;
        string Email;

        public CustomerController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GenerateInvoice()
        {
          //  int i = 0;
            int length = productlist.Count;
            SqlConnection cnn;
            String connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-SDP-CC54433E-7C52-476B-9D44-F833439FB6B2;Trusted_Connection=True;MultipleActiveResultSets=true";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            String query = "SELECT customerId FROM Customers WHERE email =   '" + "hg@gmail.com" + "' ";
            SqlCommand command = new SqlCommand(query , cnn);
            SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader.GetValue(1));
            //}
            Console.WriteLine(reader.GetValue(0));
            

            //for (i=0; i< length; i++)
            //{

            //}

            return View();
        }

        [HttpGet]
        public IActionResult PurchaseProduct( )
        {
            return View();
        }

        [HttpPost]
        public IActionResult PurchaseProduct(PurchaseProductViewModel model)
        {
            PurchaseProduct pp = new PurchaseProduct()
            {
                ProductCategory = model.ProductCategory,
                ProductName = model.ProductName,
                ProductQuantity = model.ProductQuantity
            };
            
            SqlConnection cnn;
            String connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-SDP-CC54433E-7C52-476B-9D44-F833439FB6B2;Trusted_Connection=True;MultipleActiveResultSets=true";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            System.Diagnostics.Debug.WriteLine("hello");
            String sql = "SELECT * FROM Products WHERE Category = + '" + model.ProductCategory + "'   and Name =  '" + model.ProductName +"'";
            SqlCommand command = new SqlCommand(sql,cnn);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                //  Console.WriteLine(reader.GetValue(0) + " " + reader.GetValue(1) + " "+ reader.GetValue(2) + " " + reader.GetValue(3) + " " +reader.GetValue(4) + " " + reader.GetValue(5));
                qty = (int)reader.GetValue(5);
                pro_id = (int)reader.GetValue(0);
            }
            cnn.Close();
            //int i;
            if ( qty >= pp.ProductQuantity)
            {
                //for(i=0; i<pp.ProductQuantity; i++)
                //{
                    productlist.Add(pp.ProductCategory);
                    productlist.Add(pp.ProductName);
                    productlist.Add(pp.ProductQuantity);

                //}
                
            }
            else
            {
                ViewBag.quantity = "Available Quantity :" + qty;
                ViewBag.ErrorMessage = "Not enough Quantity";
            }
            int i;
            for (i = 0; i< productlist.Count; i++)
            {
                Console.WriteLine(productlist[i]);
            }
            


            return View();
        }

        // [Authorize]

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

      
        [HttpPost]
        public IActionResult AddCustomer(CustomerViewModel model)
        {
            if (ModelState.IsValid) { 
                    customer newcustomer = new customer
                    {
                        Name = model.Name,
                        email = model.email,
                        contact = model.contact,
                        address = model.address
                    };
                     Email = model.email;
               
                    _context.Add(newcustomer);
                    _context.SaveChanges();


                    return RedirectToAction("PurchaseProduct","Customer");
            }
            return View();
        }
    }
}
