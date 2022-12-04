using Microsoft.AspNetCore.Mvc;

namespace about_me_csharp
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
