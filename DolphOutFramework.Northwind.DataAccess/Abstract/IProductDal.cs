using DolphOutFramework.Core.DataAccess;
using DolphOutFramework.Northwind.Entities.ComplexTypes;
using DolphOutFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace DolphOutFramework.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
