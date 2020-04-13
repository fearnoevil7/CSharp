using Microsoft.AspNetCore.Mvc;
namespace Project
{
    public class ProjectController : Controller
    {
        [HttpGet("/projects")]

        public ViewResult projectHome(){
            return View("Project");
        }
    }
}