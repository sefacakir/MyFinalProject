using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    /*  DataAccess ürünü ekliyicek.
    *   Business kontrol edecek.
    *   console göterecek
    
    *   Bir class'ın default'u internal'dır.
    *   İnternal kendi katmanında herkes ona erişebilir demektir.
    *   public bu class'a diğer katmanların ulaşabilmesini sağlar.
    */
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
