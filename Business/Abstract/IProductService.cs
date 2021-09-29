using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
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
        IDataResult GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
        Product GetById(int productId);
        IResult Add(Product product);

    }
}
