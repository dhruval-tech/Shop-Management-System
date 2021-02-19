using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SDP.ViewModels;
using SDP.Models;
using SDP.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http;

namespace SDP.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
                                SignInManager<IdentityUser> signInManager, 
                                ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _context = context;

        }
        // GET: AccountController
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email, EmailConfirmed= true };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                    //return RedirectToAction("index1", "home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            ViewBag.Email = null;
            if (ModelState.IsValid)
            {
                if (model.Role == "Admin")
                {
                    var user = await userManager.FindByEmailAsync(model.Email);
                    if (user != null && !user.EmailConfirmed)
                    {
                        ModelState.AddModelError("message", "Email not confirmed yet");
                        return View();

                    }
                    var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        //HttpContext.Session.SetString("Role", model.Role);
                        return RedirectToAction("index", "home");
                    }
                    else {
                        ViewBag.Message = "Admin not Exist!!!";
                        ModelState.AddModelError("", "Invalid Login Attempt");
                        return View();
                    }

                    
                }
                else {
                    SqlConnection cnn;
                    String connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-SDP-CC54433E-7C52-476B-9D44-F833439FB6B2;Trusted_Connection=True;MultipleActiveResultSets=true";
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    String query = "SELECT * FROM customers WHERE email = '" + model.Email + "' ";
                    Console.WriteLine(query);
                    SqlCommand command = new SqlCommand(query, cnn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        HttpContext.Session.SetString("Email", model.Email);
                        return RedirectToAction("index", "customer");

                    }
                    else
                    {
                        HttpContext.Session.Remove("Email");
                        ViewBag.Message = "Customer not Exist!!!";
                        return View();

                    }
                }
                

            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {

            await signInManager.SignOutAsync();
            HttpContext.Session.Remove("Email");
            return RedirectToAction("index", "customer");
        }

    }
}
