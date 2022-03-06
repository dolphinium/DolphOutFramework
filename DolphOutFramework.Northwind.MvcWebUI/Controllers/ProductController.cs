using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DolphOutFramework.Northwind.Business.Abstract;
using DolphOutFramework.Northwind.Entities.Concrete;
using DolphOutFramework.Northwind.MvcWebUI.Models;

namespace DolphOutFramework.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }

        public string Add()
        {
            _productService.Add(new Product
            {
                CategoryId = 1,
                ProductName = "Iphone 7 Plus",
                QuantityPerUnit = "1 in a box",
                UnitPrice = 7000
            });
            return "Added";
        }
    }
}