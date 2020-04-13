using Microsoft.AspNetCore.Mvc;
namespace Home
{
    public class HomeController : Controller
    {
        [HttpGet("")]

        public ViewResult Index(){
            return View();
        }

        [HttpGet("contact")]

        public ViewResult ContactPage()
        {
            return View("Contact");
        }
    }
}