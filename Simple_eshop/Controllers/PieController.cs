using Microsoft.AspNetCore.Mvc;

namespace Simple_Eshop.Controllers
{
    public class PieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
