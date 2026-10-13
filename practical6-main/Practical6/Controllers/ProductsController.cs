using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practical6.Models;

namespace Practical6.Controllers
{
    public class ProductsController : Controller
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    Name = "Laptop",
                    Description = "HP Laptop with 8GB RAM",
                    Price = 50000,
                    Category = "Electronics",
                    Img = "laptop.jpg"
                },

                new Product
                {
                    ProductId = 2,
                    Name = "Mobile",
                    Description = "Android Smartphone",
                    Price = 25000,
                    Category = "Electronics",
                    Img = "mobile.jpg"
                },

                new Product
                {
                    ProductId = 3,
                    Name = "Headphones",
                    Description = "Wireless Bluetooth Headphones",
                    Price = 2000,
                    Category = "Accessories",
                    Img = "headphones.jpg"
                }
            };

            return products;
        }


        // GET: Products
        public ActionResult Index()
        {
            var products = GetProducts();

            return View(products);
        }


        // GET: Products/Details/2
        public ActionResult Details(int id)
        {
            var products = GetProducts();

            Product product = products.FirstOrDefault(x => x.ProductId == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}