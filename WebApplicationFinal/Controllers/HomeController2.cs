using Microsoft.AspNetCore.Mvc;

namespace WebApplicationFinal.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
