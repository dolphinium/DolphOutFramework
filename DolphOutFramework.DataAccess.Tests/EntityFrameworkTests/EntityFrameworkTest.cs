using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DolphOutFramework.Northwind.DataAccess.Concrete.EntityFramework;

namespace DolphOutFramework.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(81,result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList(p=>p.ProductName.Contains("ab"));

            Assert.AreEqual(5, result.Count);
        }
    }
}
