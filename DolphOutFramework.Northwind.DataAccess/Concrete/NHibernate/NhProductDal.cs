﻿using DolphOutFramework.Core.DataAccess.NHibernate;
using DolphOutFramework.Northwind.DataAccess.Abstract;
using DolphOutFramework.Northwind.Entities.ComplexTypes;
using DolphOutFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DolphOutFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>() on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 CategoryName = c.CategoryName,
                                 ProductName = p.ProductName
                             };
                return result.ToList();
            }
        }
    }
}
