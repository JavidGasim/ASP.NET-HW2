using Asp_HW2.Entities;
using Asp_HW2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_HW2.Controllers
{
    public class HomeController : Controller
    {
        public static List<Product> products { get; set; } = new List<Product>()
        {
            new Product(1, "Coca-Cola", "This is non-alcohol drink. It is recommended that you drink it cool", 1.00, 20),
            new Product(2, "Fanta", "This is non-alcohol drink. It is recommended that you drink it cool", 1.00, 20),
            new Product(3, "Bizon", "This is non-alcohol drink. Drinking too much of it is harmful to health", 0.70, 10),
        };

        public IActionResult Index()
        {
            var productViewModel = new ProductViewModel(products);
            return View(productViewModel);
        }

        public IActionResult DeleteProduct(int id)
        {
            var product = products.SingleOrDefault(p => p.ProductId == id);

            if (product != null)
            {
                products.Remove(product);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var product = products.SingleOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                var updateViewModel = new UpdateViewModel()
                {
                    Product = product,
                };
                return View(updateViewModel);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateProduct(UpdateViewModel up)
        {
            var product = products.SingleOrDefault(p => p.ProductId == up.Product.ProductId);

            product.Name = up.Product.Name;
            product.Description = up.Product.Description;
            product.Price = up.Product.Price;
            product.Discount = up.Product.Discount;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            var addViewModel = new AddViewModel()
            {
                Product = new Product()
            };

            return View(addViewModel);
        }

        [HttpPost]
        public IActionResult AddProduct(AddViewModel ap)
        {
            Random random = new Random();
            ap.Product.ProductId = random.Next(10, 100);
            products.Add(ap.Product);

            return RedirectToAction("Index");
        }
    }
}
