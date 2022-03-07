using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DolphOutFramework.Northwind.Business.Abstract;
using DolphOutFramework.Northwind.Entities.Concrete;

namespace DolphOutFramework.Northwind.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Get()
        {
            return _productService.GetAll();
        }
    }
}
