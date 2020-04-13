using Microsoft.AspNetCore.Mvc;
namespace WordsArray
{
    public class HomeController : Controller
    {
        [HttpGet("")]

        public ViewResult getWords(){
            return View("WordsArray");
        }
    }
}