using OpenSooq.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenSooq.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using OpenSooq.Data;
using System.Security.Cryptography;
using System.Text;

namespace OpenSooq.Controllers
{
    public class AccountController : Controller
    {

        public AppDbContext db;
        public AccountController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Address = model.Address,
                    CreationDate = DateTime.Now,
                    Email = model.Email,
                    RoleId =1,
                    IsActive = true,
                    IsDeleted = false,
                    Mobile = model.Mobile,
                    Password = HashPassword(model.Password),
                    UserName = model.UserName
                };
                
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(model);
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LogInViewModel model)
        {
            if (ModelState.IsValid)
            {
                var data = db.Users.Where(x => x.UserName == model.UserName && x.Password == HashPassword(model.Password));
                if (data.Any())
                {
                    HttpContext.Session.SetString("name", model.UserName);
                    HttpContext.Session.SetInt32("RoleId", data.SingleOrDefault().RoleId);
                    HttpContext.Session.SetInt32("UserId", data.SingleOrDefault().UserId);
                    return RedirectToAction("Index", "Home", new { area = "Dashboard" });
                }

                ViewBag.err = "Invalid UserName/Password";
                return View(model);

            }

            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        string HashPassword(string password)
        {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(password);
            var hashpassword = sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hashpassword);
        }
    }
}
