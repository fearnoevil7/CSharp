using Microsoft.AspNetCore.Mvc;
using System;
namespace Home
{
    public class HomeController : Controller
    {
        [HttpGet("")]

        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/postData")]

        public ViewResult postData(string name, string location, string language, string comments)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comments = comments;
            Console.WriteLine(name);
            Console.WriteLine(language);
            return View("result");
        }
    }
}