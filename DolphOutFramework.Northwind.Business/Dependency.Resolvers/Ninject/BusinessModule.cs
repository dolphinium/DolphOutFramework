using DolphOutFramework.Core.DataAccess;
using DolphOutFramework.Core.DataAccess.EntityFramework;
using DolphOutFramework.Core.DataAccess.NHibernate;
using DolphOutFramework.Northwind.Business.Abstract;
using DolphOutFramework.Northwind.Business.Concrete.Managers;
using DolphOutFramework.Northwind.DataAccess.Abstract;
using DolphOutFramework.Northwind.DataAccess.Concrete.EntityFramework;
using DolphOutFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Ninject.Modules;
using System.Data.Entity;
using DolphOutFramework.Northwind.DataAccess.Concrete.NHibernate;

namespace DolphOutFramework.Northwind.Business.Dependency.Resolvers.Ninject
{
	public class BusinessModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IProductService>().To<ProductManager>().InSingletonScope();
			Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

			Bind<IUserService>().To<UserManager>().InSingletonScope();
			Bind<IUserDal>().To<EfUserDal>().InSingletonScope();

			Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
			Bind<DbContext>().To<NorthwindContext>();
			Bind<NHibernateHelper>().To<SqlServerHelper>();
		}
	}
}
