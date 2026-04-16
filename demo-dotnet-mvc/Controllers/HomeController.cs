using demo_dotnet_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_dotnet_mvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //ViewBag.Name = "Welcome to Pythagorean Theorem Solver!"; // Set a message to be displayed in the view.
                                                                        // Here, we are using ViewBag to pass a message to the
                                                                        // view, which can be accessed and displayed in the
                                                                        // corresponding Razor view (Index.cshtml).
                                                                        // we can also use ViewData or a strongly-typed model
                                                                        // to pass data to the view, but in this case, we are
                                                                        // using ViewBag for simplicity. The message
                                                                        // "Welcome to Pythagorean Theorem Solver!"
                                                                        // will be displayed on the home page when the user
                                                                        // navigates to the Index action of the HomeController.
            return View();
        }
        [HttpPost]
                public IActionResult Index(PythagoreanSolver myTriangle)
        {
            ViewBag.Hypotenuse = myTriangle.CalculateHypotenuse(); // Calculate the hypotenuse using the model and pass it to the view.
            return View(myTriangle);
        }
    }
}
