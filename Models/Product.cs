namespace FlavourlinesWebApp.Models
{
    public class Product
    {

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }

        public int CategoryId { get; set; } // Foreign key for Category
        public Category Category { get; set; }

        // Default Constructor
        public Product() { }

        // Parameterized Constructor
        public Product(int productId, string name, decimal price, int stock, string image, string description, string sku, int categoryId)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Stock = stock;
            Image = image;
            Description = description;
            Sku = sku;
            CategoryId = categoryId;
        }

    }
}
