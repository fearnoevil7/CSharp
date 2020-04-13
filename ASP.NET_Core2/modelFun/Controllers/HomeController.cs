using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using modelFun.Models;
namespace modelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]

        public IActionResult Index()
        {
            string message = "Hello friend welcome to my modelFun coding dojo assignment/project!";
            return View("Index", message);
        }

        [HttpGet("/numbers")]
        public IActionResult Numbers()
        {
            string[] numbers = new string[]
            {
                "7", "16", "25", "34", "43", "52", "61", "70", "88", "97"
            };
            return View("Numero", numbers);
        }

        [HttpGet("/users")]
        public IActionResult Users()
        {
            User Jonathon = new User()
            {
                FirstName = "Jonathon",
                LastName = "Song",
            };
            User Tess = new User()
            {
                FirstName = "Tess",
                LastName = "Song",
            };
            User Mikey = new User()
            {
                FirstName = "Mikey",
                LastName = "Choi",
            };
            User Jae = new User()
            {
                FirstName = "Jae",
                LastName = "Song",
            };
            User Randy = new User()
            {
                FirstName = "Randy",
                LastName = "Song",
            };
            List<User> users = new List<User>()
            {
                Jonathon, Tess, Mikey, Jae, Randy
            };
            return View("Users", users);
        }

        [HttpGet("/user")]
        public IActionResult user()
        {
            User user = new User()
            {
                FirstName = "Ezra",
                LastName = "Song",
            };
            return View("User", user);
        }
    }
}