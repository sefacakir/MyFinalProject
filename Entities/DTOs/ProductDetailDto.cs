using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    /*
     * IEntity miras alabilir miyiz?
     * Bu bir veri tabanı tablosu olmadığından IEntity'yi miras olarak veremeyiz.
     * Sen bir DTO'sun.
     */
    

    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
