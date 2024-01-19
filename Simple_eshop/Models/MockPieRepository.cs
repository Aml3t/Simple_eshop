
namespace Simple_Eshop.Models
{
    public class MockPieRepository : IPieRepository
    {
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie{PieId = 1, Name = "Test Pie", CategoryId = 1 }
            };
            

        public IEnumerable<Pie> PiesOfTheWeek => throw new NotImplementedException();

        public Pie? GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
