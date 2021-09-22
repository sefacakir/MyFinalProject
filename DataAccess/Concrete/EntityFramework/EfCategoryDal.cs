using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        /*
         * Entity Framework microsoftun bir ürünü,
         * Linq destekli çalışıyor
         * OREM : Object Relational Mapping
         * Linq destekli çalışıyor.
         * OREM veri tabanındaki tabloyu sanki class'mış 
         * gibi ilişkilendirip, tüm operasyonları 
         * yani SQL'leri
         * linq ile yaptığımız bir ortam.
         * OREM veritabanı nesneleri ve kodlar arasında 
         * bir bağ kurup veri tabanı işlerini yapma süreci.
         */

        /*
         * Başkalarının yazdığı paketleri de kullanabiliriz.
         * Bu paketlere Nuget'i kullanarak erişebiliriz.
         * DataAccess üzerinde sağ tıklayıp
         * Manage NuGet Packages'a tıklayıp entityframeworkcore.sql
         * yazıp gelenler arsında .sqlserver olanı yazıyoruz.
         */

        /*
         * Bizim Entity'deki classlarımz, customer, category 
         * ve product sql'deki tablolara denk gelmektedir.
         * bu tabloları birbiri ile ilişkilendirelim.
         * Bunun için context dediğimiz bir yapı kuruyoruz.
         * context demek veri tabanı ile kendi classlarımızı 
         * ilişkilendirdiğimiz class'tır.
         * Bu class'ın ismini NorthwindContext olarak belirledik.
         */
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
