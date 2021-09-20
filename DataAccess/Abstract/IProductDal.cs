using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Product'la ilgili veri tabanına yapacağım operasyonları içeren interface
    //Ekle, sil, güncelle işlemleri = operasyonlar

    //interface'in operasyonları public'tir, ama kendisi değildir.
    /*
     *  DataAccess, Entities'e bağlı olduğu için 
     *  DataAccess-Add-Project Reference ve ordan Entities'i seçiyoruz.
     *  Seçtiğimizi de DataAccess içerisndeki Dependencies'ten görebiliriz.
     *  
     */

    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);

    }
}
