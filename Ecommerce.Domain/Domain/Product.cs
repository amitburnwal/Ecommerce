namespace Ecommerce.Domain.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Followers { get; set; }
        public string CategoryName { get; set; }
    }
}