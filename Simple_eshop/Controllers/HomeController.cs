using Microsoft.AspNetCore.Mvc;
using Simple_Eshop.Models;
using Simple_Eshop.ViewModels;

namespace Simple_Eshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            //PieListViewModel piesListViewModel = new PieListViewModel
            //    (_pieRepository.AllPies, "Cheese cakes");
            //return View(piesListViewModel);
        }

    }
}
