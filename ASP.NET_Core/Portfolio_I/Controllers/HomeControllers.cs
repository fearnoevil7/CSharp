using Microsoft.AspNetCore.Mvc;
namespace HelloAsp
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]

        public string Index() {
            return "This is my index!!!!!!";
        }

        
        [HttpGet("projects")]

        public string ProjectIndex() {
            return "These are my projects!!!!!";
        }

        [HttpGet("contact")]

        public string ContactIndex() {
            return "This is my contact info!";
        }
    }
}