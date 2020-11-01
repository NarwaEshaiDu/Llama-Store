using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LlamaStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace LlamaStore.Controllers
{
    public class ProductController : Controller
    {
        private  List<Product> products = new List<Product>
            {
                new Product {Id=1,Name="Fluffy Llama",Description="A fluffy Llama",Price=9.99M },
                new Product {Id=2,Name="Colorful Llama",Description="A Colorful Llama",Price=19.99M }
            };
        public IActionResult Index()
        {
            return View(products);
        }
        public IActionResult Details(int id)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    return View(product);
                }
            }
            return NotFound();
        }
    }
}
