using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using DojoSurveyWithModels.Models;
namespace DojoSurveyWithModels.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]

        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("/post")]

        public IActionResult postData(User user) {
            User newUser = new User()
            {
                Name = user.Name,
                Location = user.Location,
                Language = user.Language,
                Comment = user.Comment,
            };
            return View("results", newUser);
        }
    }
}