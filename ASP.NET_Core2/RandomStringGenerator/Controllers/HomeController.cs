using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace RandomStringGenerator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            int count = 0;
            HttpContext.Session.SetInt32("count", count);
            return View("Index");
        }
        [HttpPost]
        [Route("/generate")]
        public IActionResult generate()
        {
            int? count = HttpContext.Session.GetInt32("count");
            count++;
            ViewBag.count = count;
            TempData["newCount"] = count;
            Random rando = new Random();
            string randomString = "";
            char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int i = 0; i < 15; i++)
            {
                randomString = randomString + chars[rando.Next(0, chars.Length)];
            }
            Console.WriteLine(randomString);
            return View("Index", randomString);
        }
    }
}