using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission2.Models;

namespace FormSubmission2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/postData")]

        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid) {
                Console.WriteLine("*******Error!!!!!!!*******");
                return View("Index");
            } else
            {
                User newUser = new User()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Age = user.Age,
                };
                Console.WriteLine("Success");
                return View("Results", newUser);
            }
        }

        [HttpGet("success")]
        public IActionResult results()
        {
            return View("Results");
        }


        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
