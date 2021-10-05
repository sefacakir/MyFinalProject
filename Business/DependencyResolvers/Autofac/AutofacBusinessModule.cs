using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            //birisi IProductService isterse ProductManager instance'ı ver.
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            //IProductDal isterse, EfProductDal referansı veriyor.
        }
    }
}
