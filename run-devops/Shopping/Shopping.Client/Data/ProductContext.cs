using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = "1",
                Name = "Laptop",
                Description = "Powerful laptop with high-performance specs.",
                Category = "Electronics",
                ImageFile = "laptop.jpg",
                Price = "999.99"
            },
            new Product
            {
                Id = "2",
                Name = "Smartphone",
                Description = "Latest smartphone with advanced features.",
                Category = "Electronics",
                ImageFile = "smartphone.jpg",
                Price = "799.99"
            },
            new Product
            {
                Id = "3",
                Name = "Book",
                Description = "Best-selling novel with an intriguing plot.",
                Category = "Books",
                ImageFile = "book.jpg",
                Price = "19.99"
            },
            new Product
            {
                Id = "4",
                Name = "Coffee Maker",
                Description = "Automatic coffee maker for brewing your favorite coffee.",
                Category = "Appliances",
                ImageFile = "coffeemaker.jpg",
                Price = "59.99"
            },
            new Product
            {
                Id = "5",
                Name = "Running Shoes",
                Description = "Comfortable running shoes for fitness enthusiasts.",
                Category = "Clothing",
                ImageFile = "runningshoes.jpg",
                Price = "79.99"
            },
            new Product
            {
                Id = "6",
                Name = "Desk Chair",
                Description = "Ergonomic desk chair for a comfortable workspace.",
                Category = "Furniture",
                ImageFile = "deskchair.jpg",
                Price = "129.99"
            },
        };
    }
}
