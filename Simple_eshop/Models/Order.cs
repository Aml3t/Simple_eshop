namespace Simple_Eshop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string AddressLine { get; set; } = string.Empty;
        public string? AddressLine2 { get; set; }
        public string ZipCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string? State { get; set; }
        public string Country { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

    }
}
