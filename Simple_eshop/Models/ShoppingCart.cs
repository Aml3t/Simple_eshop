
namespace Simple_Eshop.Models
{
    public class ShoppingCart : IShoppingCart
    {
        public List<ShoppingCartItem> ShoppingCartItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddToCart(Pie pie)
        {
            throw new NotImplementedException();
        }

        public void ClearCart()
        {
            throw new NotImplementedException();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            throw new NotImplementedException();
        }

        public decimal GetShoppingCartTotal()
        {
            throw new NotImplementedException();
        }

        public void RemoveFromCart(Pie pie)
        {
            throw new NotImplementedException();
        }
    }
}
