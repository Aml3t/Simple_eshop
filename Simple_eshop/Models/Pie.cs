namespace Simple_Eshop.Models
{
    public class Pie
    {
        public int PieId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? AllergyInformation { get; set; }
        public decimal Price { get; set; }


    }
}
