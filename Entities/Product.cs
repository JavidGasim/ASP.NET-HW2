namespace Asp_HW2.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }

        public Product()
        {

        }

        public Product(int ProductId, string Name, string Description, double Price, int Discount)
        {
            this.ProductId = ProductId;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Discount = Discount;
        }
    }
}
