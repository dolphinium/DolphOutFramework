using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DolphOutFramework.Core.DataAccess.EntityFramework;
using DolphOutFramework.Northwind.DataAccess.Abstract;
using DolphOutFramework.Northwind.Entities.Concrete;

namespace DolphOutFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,NorthwindContext>,IUserDal
    {
    }
}
