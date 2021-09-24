using Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()
        where TContext: DbContext, new()
    {
        public void Add(TEntity entity)
        {

            /*  IDisposable pattern  implementation of c#
            *   Sistemin daha iyi çalışması için.
            *   using bittiği anda garbage collector gelip topluyor.
            */
            using (TContext context = new TContext())
            {
                //burda referansı yakalıyoruz.
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                //burda eklenecek olarak bildiriyoruz.
                context.SaveChanges();
                //burda da ekleme işlemi yapılıyor.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                //burda referansı yakalıyoruz.
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                //burda silinecek olarak bildiriyoruz.
                context.SaveChanges();
                //burda da gerekli işlemi yapılıyor.
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                /*  Veri tabanındaki product tablosuna yerleş ve 
                 *  oradaki verileri bana döndür.
                 *  eğer filter null değil ise, 
                 *  istenilen filtreye göre verileri liste haline getir
                 *  ve bana döndür
                 */
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
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