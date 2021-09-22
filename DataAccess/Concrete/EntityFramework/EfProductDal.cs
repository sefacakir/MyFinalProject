using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {

            /*  IDisposable pattern  implementation of c#
            *   Sistemin daha iyi çalışması için.
            *   using bittiği anda garbage collector gelip topluyor.
            */
            using (NorthwindContext context = new NorthwindContext())
            {
                //burda referansı yakalıyoruz.
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                //burda eklenecek olarak bildiriyoruz.
                context.SaveChanges();
                //burda da ekleme işlemi yapılıyor.
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //burda referansı yakalıyoruz.
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                //burda silinecek olarak bildiriyoruz.
                context.SaveChanges();
                //burda da gerekli işlemi yapılıyor.
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                /*  Veri tabanındaki product tablosuna yerleş ve 
                 *  oradaki verileri bana döndür.
                 *  eğer filter null değil ise, 
                 *  istenilen filtreye göre verileri liste haline getir
                 *  ve bana döndür
                 */
                return filter == null
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //burda referansı yakalıyoruz.
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                //burda güncellenecek olarak bildiriyoruz.
                context.SaveChanges();
                //burda da gerekli işlemi yapılıyor.
            }
        }
    }
}