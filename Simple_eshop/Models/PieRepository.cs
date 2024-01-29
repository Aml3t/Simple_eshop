
using Microsoft.EntityFrameworkCore;

namespace Simple_Eshop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;

        public PieRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
        {
            _bethanysPieShopDbContext = bethanysPieShopDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _bethanysPieShopDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _bethanysPieShopDbContext.Pies.Include(c=> c.Category).Where(c => c.IsPieOfTheWeek == true);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            get
            {
                return _bethanysPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
            }
        }
    }
}
