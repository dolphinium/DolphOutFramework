using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DolphOutFramework.Core.DataAccess.NHibernate;
using DolphOutFramework.Northwind.DataAccess.Abstract;
using DolphOutFramework.Northwind.Entities.Concrete;

namespace DolphOutFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal:NhEntityRepositoryBase<Product>,IProductDal
    {
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
