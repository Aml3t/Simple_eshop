using Microsoft.AspNetCore.Mvc;
using Simple_Eshop.Models;

namespace Simple_Eshop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IShoppingCart _shoppingCart;

        public OrderController(IOrderRepository pieRepository, IShoppingCart shoppingCart)
        {
            _orderRepository = pieRepository;
            _shoppingCart = shoppingCart;
        }
    }
}
