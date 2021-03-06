using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DolphOutFramework.Northwind.DataAccess.Concrete.EntityFramework;
using DolphOutFramework.Northwind.DataAccess.Concrete.NHibernate;
using DolphOutFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;

namespace DolphOutFramework.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList();

            Assert.AreEqual(81, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList(p => p.ProductName.Contains("ab"));

            Assert.AreEqual(5, result.Count);
        }
    }
}
