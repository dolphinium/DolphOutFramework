using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DolphOutFramework.Core.CrossCuttingConcerns.Validation.FluentValidation;
using DolphOutFramework.Northwind.Business.Abstract;
using DolphOutFramework.Northwind.Business.ValidationRules.FluentValidation;
using DolphOutFramework.Northwind.DataAccess.Abstract;
using DolphOutFramework.Northwind.Entities.Concrete;
using DolphOutFramework.Core.Aspects.PostSharp;
using DolphOutFramework.Core.Aspects.PostSharp.CacheAspects;
using DolphOutFramework.Core.Aspects.PostSharp.LogAspects;
using DolphOutFramework.Core.Aspects.PostSharp.TransactionAspects;
using DolphOutFramework.Core.Aspects.PostSharp.ValidationAspects;
using DolphOutFramework.Core.CrossCuttingConcerns.Caching.Microsoft;
using DolphOutFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using DolphOutFramework.Core.DataAccess;

namespace DolphOutFramework.Northwind.Business.Concrete.Managers
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [LogAspect(typeof(DatabaseLogger))]
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            // Business codes
            _productDal.Update(product2);
        }
    }
}
