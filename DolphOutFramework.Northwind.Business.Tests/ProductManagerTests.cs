using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DolphOutFramework.Northwind.Business.Concrete.Managers;
using DolphOutFramework.Northwind.DataAccess.Abstract;
using DolphOutFramework.Northwind.Entities.Concrete;
using FluentValidation;
using Moq;

namespace DolphOutFramework.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);
            productManager.Add(new Product());
        }
    }
}
