namespace Simple_Eshop.Models
{
    public interface IShoppingCart
    {
        void AddToCart(Pie pie);
        void RemoveFromCart(Pie pie);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
        List<ShoppingCartItem> ShoppingCartItems { get; set; }

    }
}
