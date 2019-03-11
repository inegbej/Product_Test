using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarveyNichols.Data.Entities;
using HarveyNichols.Data.Repository;
using HarveyNichols.Product.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HarveyNichols.Product.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productrepository;

        public ProductController(IProductRepository productrepo)
        {
            _productrepository = productrepo;
        }
        
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = new Products();
                product.Style = model.Style;
                product.Colour = model.Colour;
                product.Sku = model.Sku;
                product.Title = model.Title;
                product.Price = model.Price;
                product.Stock = model.Stock;

                _productrepository.Add(product);

                TempData["PROD"] = "You have added a new product!";
            }
            return View();
        }
    }
}