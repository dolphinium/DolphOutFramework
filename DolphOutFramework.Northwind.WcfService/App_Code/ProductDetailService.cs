using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DolphOutFramework.Northwind.Business.Abstract;
using DolphOutFramework.Northwind.Business.Dependency.Resolvers.Ninject;
using DolphOutFramework.Northwind.Business.ServiceContracts.Wcf;
using DolphOutFramework.Northwind.Entities.Concrete;

/// <summary>
/// Summary description for ProductDetailService
/// </summary>
public class ProductDetailService:IProductDetailService
{
    public ProductDetailService()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private IProductService _productService = InstanceFactory.GetInstance<IProductService>();
    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }
}