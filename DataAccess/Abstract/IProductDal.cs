using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
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

    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

//Code refactoring : Kodun iyileştirilmesi
