using demo_dotnet_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_dotnet_mvc.Controllers
{
    public class TriangleController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(TriangleAreaSolver myTriangle)
        {
            if (!ModelState.IsValid)
            {
                return View(myTriangle); // If the model state is not valid, return the view with the current model to display validation errors.
            }
            else
            {
                ViewBag.Hypotenuse = myTriangle.CalculateArea(); // Calculate the area using the model and pass it to the view.
            }
            return View(myTriangle);
        }
    }
}
