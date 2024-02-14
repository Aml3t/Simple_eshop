using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Simple_Eshop.Models;

namespace Simple_Eshop.Pages
{
    public class CheckoutPageModel : PageModel
    {

        private readonly IOrderRepository _orderRepository;
        private readonly IShoppingCart _shoppingCart;

        public CheckoutPageModel(IOrderRepository orderRepository, IShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        public Order Order { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

        }
    }
}
