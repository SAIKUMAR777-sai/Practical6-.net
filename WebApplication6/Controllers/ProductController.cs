using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> products = new()
        {
            new Product
            {
                ProductId = 101,
                ProductName = "Laptop",
                Category = "Electronics",
                Description = "High-performance HP laptop",
                Price = 45000,
                Quantity = 5,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbKxiPF28Np1aEdzZhlaOpiGGpSxwG881MuVck0Bei0Q&s"
            },
            new Product
            {
                ProductId = 102,
                ProductName = "Keyboard",
                Category = "Accessories",
                Description = "USB mechanical keyboard",
                Price = 1500,
                Quantity = 20,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTfqufdwuOYBV0ZNHHLIjjEyWstiTTbgQLSfuswfT-YXQ&s"
            },
            new Product
            {
                ProductId = 103,
                ProductName = "Smart Watch",
                Category = "Wearables",
                Description = "Smart watch with fitness tracking",
                Price = 3500,
                Quantity = 12,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKdAHOjh9IYTOgkL3WKOpI9lfJVHPbZ7cZtYRV8dRuyQ&s"
            }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Details(int id)
        {
            Product? product = products.FirstOrDefault(
                p => p.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}