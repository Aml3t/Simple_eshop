using Microsoft.EntityFrameworkCore;

namespace Simple_Eshop.Models
{
    public class BethanysPieShopDbContext : DbContext
    {
        public BethanysPieShopDbContext(DbContextOptions<BethanysPieShopDbContext> 
            options) : base(options)
        {
                
        }
    }
}
