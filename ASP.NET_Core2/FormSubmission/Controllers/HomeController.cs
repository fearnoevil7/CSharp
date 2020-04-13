using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]

        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("/postData")]

        public IActionResult Create(User user)
        {
            Console.WriteLine("*******Testing!!!!!!!*******", ModelState.IsValid);
            if(ModelState.IsValid)
            {
                return RedirectToAction("results");
            }
            else
            {
                Console.WriteLine("*******Testing!!!!!!!*******", ModelState.IsValid);
                return View("Index");
            }
        }
        [HttpGet("/success")]
        public IActionResult results()
        {
            return View("Results");
        }
    }
}