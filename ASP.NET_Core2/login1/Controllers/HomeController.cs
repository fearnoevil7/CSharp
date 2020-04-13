using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using login1.Models;

namespace login1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult Register(Register reg)
        {
            if(ModelState.IsValid)
            {
                Register newUser = new Register()
                {
                    FirstName = reg.FirstName,
                    LastName = reg.LastName,
                    Email = reg.Email,
                    Password = reg.Password,
                };
                return RedirectToAction("Success");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpPost]
        [Route("/login")]
        public IActionResult Login(Login user)
        {
            if(ModelState.IsValid)
            {
                Login newUser = new Login()
                {
                    LoginEmail = user.LoginEmail,
                    LoginPassword = user.LoginPassword,
                };
                Console.WriteLine("*******Success*******");
                return RedirectToAction("Success");
                Console.WriteLine("*******Test*******");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("Success")]
        public string Success()
        {
            return "You have successfully submitted!";
        }
    }
}