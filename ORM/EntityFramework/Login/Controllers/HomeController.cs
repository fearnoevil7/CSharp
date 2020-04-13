using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Login.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                if(dbContext.Users.Any(user1 => user1.email == user.email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                }
                PasswordHasher <User> Hasher = new PasswordHasher<User>();
                User newUser = new User()
                {
                    firstName = user.firstName,
                    lastName = user.lastName,
                    email = user.email,
                    password = Hasher.HashPassword(user, user.password),
                };
                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
                
            }
            else
            {
                Console.WriteLine("Registration failed!");
                return View("Index");
            }
        }

        [HttpPost]
        [Route("/session/create")]
        public IActionResult Login(LoginUser usersubmission)
        {
            if (ModelState.IsValid)
            {
                var userInDB = dbContext.Users.FirstOrDefault(user => user.email == usersubmission.email);
                if (userInDB == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email");
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(usersubmission, userInDB.password, usersubmission.password);
                if (result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid Password");
                    return View("Index");
                }
                // User user1 = dbContext.Users.FirstOrDefault(user => user.email == usersubmission.email);
                Console.WriteLine(result);
                Console.WriteLine("*******!!!!!!!!!!!!!*******", result);
                HttpContext.Session.SetInt32("UserId", userInDB.id);
                int? id = HttpContext.Session.GetInt32("UserId");
                Console.WriteLine(id);
                return View("Success");

            }
            else
            {
                Console.WriteLine("*******ModelState IsValid failed*******");
                return View("Index");
            }
            
            
        }
        [HttpGet]
        [Route("/login")]
        public ViewResult Login()
        {
            return View();
        }

        [HttpGet]
        [Route("/success")]
        public IActionResult Success()
        {
            int? currentIdInSession = HttpContext.Session.GetInt32("UserId");
            if (currentIdInSession != null)
            {
                return View("Success");
            }
            else
            {
                ModelState.AddModelError("id", "User not in session");
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        [Route("/logout")]
        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}