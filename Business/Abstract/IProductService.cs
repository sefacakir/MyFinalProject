﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        /*  
         *  Business, işlemleri yaparken Entities'e erişmek isteyecek
         *  Gerekli işlemleri yazdıktan sonra da DataAccess'e iletecek
         *  Dolayısıyla referansları eklemeyi unutmuyoruz.
         */
        List<Product> GetAll();
    }
}
