using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DolphOutFramework.Northwind.Business.ValidationRules.FluentValidation;
using DolphOutFramework.Northwind.Entities.Concrete;
using FluentValidation;
using Ninject.Modules;

namespace DolphOutFramework.Northwind.Business.Dependency.Resolvers.Ninject
{
    public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
        }
    }
}
