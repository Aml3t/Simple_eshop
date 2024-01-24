using Simple_Eshop.Models;

namespace Simple_Eshop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; }

        public string? CurrentCategory { get; set; }

        public PieListViewModel(IEnumerable<Pie> pies, string currentCategory)
        {
            Pies = pies;
            CurrentCategory = currentCategory;
        }
    }
}
