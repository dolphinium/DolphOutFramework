using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DolphOutFramework.Northwind.Business.Abstract;
using DolphOutFramework.Northwind.DataAccess.Abstract;
using DolphOutFramework.Northwind.Entities.Concrete;

namespace DolphOutFramework.Northwind.Business.Concrete.Managers
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName == userName & u.Password == password);
        }
    }
}
