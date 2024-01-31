using Microsoft.AspNetCore.Mvc;

namespace Simple_Eshop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
