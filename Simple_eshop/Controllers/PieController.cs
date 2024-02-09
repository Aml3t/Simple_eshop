using Microsoft.AspNetCore.Mvc;
using Simple_Eshop.Models;
using Simple_Eshop.ViewModels;

namespace Simple_Eshop.Controllers
{
    public class PieController : Controller
    {
        private readonly IOrderRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IOrderRepository pieRepository, ICategoryRepository categoryRepository)
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

        public ViewResult List(string category)
        {
            IEnumerable<Pie> pies;
            string? currentCategory;

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


    }
}
