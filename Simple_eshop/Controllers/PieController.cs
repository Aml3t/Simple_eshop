using Microsoft.AspNetCore.Mvc;
using Simple_Eshop.Models;

namespace Simple_Eshop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public PieController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Action()
        {

        }
    }
}
