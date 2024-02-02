using Microsoft.AspNetCore.Mvc;
using Simple_Eshop.Models;

namespace Simple_Eshop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly IShoppingCart _shoppingCart;
    }
}
