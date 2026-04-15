using Microsoft.AspNetCore.Mvc;

namespace demo_dotnet_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
