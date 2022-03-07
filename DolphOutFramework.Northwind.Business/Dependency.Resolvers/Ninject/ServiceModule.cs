using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DolphOutFramework.Core.Utilities.Common;
using DolphOutFramework.Northwind.Business.Abstract;
using Ninject.Modules;

namespace DolphOutFramework.Northwind.Business.Dependency.Resolvers.Ninject
{
    public class ServiceModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().ToConstant(WcfProxy<IProductService>.CreateChannel());
        }
    }
}
