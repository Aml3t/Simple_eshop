using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Simple_Eshop.Models;

namespace Simple_Eshop.Pages
{
    public class CheckoutPageModel : PageModel
    {
        public Order Order { get; set; }
        public void OnGet()
        {
        }
    }
}
