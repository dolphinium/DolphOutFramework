using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DolphOutFramework.Core.DataAccess;
using DolphOutFramework.Northwind.Entities.Concrete;

namespace DolphOutFramework.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
