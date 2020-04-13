using System;
using Microsoft.AspNetCore.Mvc;
namespace Home
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index(){
            DateTime currenttime = DateTime.Now;
            ViewBag.currenttime = currenttime;
            return View();
        }
    }
}