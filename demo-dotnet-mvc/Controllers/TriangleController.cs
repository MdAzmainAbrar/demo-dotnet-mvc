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
    }
}
