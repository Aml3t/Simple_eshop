using Microsoft.AspNetCore.Mvc;
using Simple_Eshop.Models;
using Simple_Eshop.ViewModels;

namespace Simple_Eshop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        ///Generic List method
        //public IActionResult List()
        //{
        //    PieListViewModel piesListViewModel = new PieListViewModel
        //        (_pieRepository.AllPies, "All Pies");
        //    return View(piesListViewModel);
        //}

        // Changed from ViewList to IActionResult to implement a basic
        // security principle to evade XSS 
        public IActionResult List(string category)
        {
            IEnumerable<Pie> pies;
            string? currentCategory;

            // Newly added counter method
            if (!IsValidCategory(category))
            {
                return RedirectToAction("Index", "Home");
            }

            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.Name);
                currentCategory = "All Pies";
            }
            else
            {
                pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.PieId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(
                    c => c.CategoryName == category)?.CategoryName;
            }
            
            return View(new PieListViewModel(pies, category));
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);

            if (pie == null)
            {
                return NotFound();
            }

            return View(pie);
        }


        // Newly added counter method
        private bool IsValidCategory(string category)
        {
            return _categoryRepository.AllCategories.Any(c => c.CategoryName == category);
        }

    }
}
