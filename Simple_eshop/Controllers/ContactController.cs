using Microsoft.AspNetCore.Mvc;

namespace Simple_Eshop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
