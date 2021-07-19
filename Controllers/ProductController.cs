using Microsoft.AspNetCore.Mvc;
using TestWeb.Models;
using System.Collections.Generic;

namespace TestWeb.Controllers
{
    public class ProductController : Controller
    {
        public List<ProductModel> product = new List<ProductModel>()
        {
            new ProductModel(){id = 1, Name = "Product 1", Available = true, Price = 10000, PromotionPrice = 8000},
            new ProductModel(){id = 2, Name = "Product 2", Available = true, Price = 18000, PromotionPrice = 6000},
            new ProductModel(){id = 3, Name = "Product 3", Available = false, Price = 16000, PromotionPrice = 3000}

        };
        public IActionResult Index()
        {
            return View(product);
        }
        //Fail: http://localhost:5001/product/edit
        //Ok: http://localhost:5001/product/modify

        // [ActionName("modify")]

        //[Route("Product/modify")]

        //[NonAction]

        // [HttpGet]
        // public string Edit(string id)
        // {
        //     return "Hello from Edit method ProductController";
        // }

        // [HttpPost]
        // public IActionResult Edit(ProductModel model)
        // {
        //     return RedirectToAction("Index", controllerName: "Product");
        // }

        // //GET: product/test
        // [HttpGet("{id}")]
        // public List<ProductModel> GetById(string id)
        // {
        //     return new List<ProductModel>();
        // }

        // //POST: product
        // [HttpPost()]
        // public IActionResult Create(ProductModel product)
        // {
        //     //TODO: Create a product in DB
        //     return Ok();
        // }

        // //PUT: product/10
        // [HttpPut("{id}")]
        // public IActionResult Update(string id, [FromBody] ProductModel product)
        // {
        //     //TODO: Create a product in DB
        //     return Ok();
        // }

        // //DELETE: product/10
        // [HttpDelete("{id}")]
        // public IActionResult Update(string id)
        // {
        //     //TODO: Create a product in DB
        //     return Ok();
        // }
    }
}