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
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product); //geriye data dönmediği için sadece mesaj verecek.
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);
    }
}
