using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//Core katmanı diğer katmanları referans almaz.
//Eğer alırsa diğer katmanlara bağımlı hale geliyor
//Core katmanı evrensel bir katmandır.

namespace Core.DataAccess
{
    //generic constraint - kısıtlama
    //class : referans tip olabilir.
    //IEntity dediğimizde de sadece IEntity olabilir.
    //yada IEntity implemente eden bir nesne olabilir.
    //new'lenebilir olmalı. IEntity

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //filter = null, filtre vermeyebiliriz. 
        List<T> GetAll(Expression<Func<T,bool>>filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
