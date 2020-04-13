using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using SurveyWithValidations.Models;

namespace SurveyWithValidations.Controllers
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
            if(ModelState.IsValid)
            {
                User newUser = new User()
                {
                    Name = user.Name,
                    Location = user.Location,
                    Language = user.Language,
                    Comment = user.Comment,
                };
                return View("Results", newUser);
            }
            else
            {
                return View("Index");
            }
        }
    }
}