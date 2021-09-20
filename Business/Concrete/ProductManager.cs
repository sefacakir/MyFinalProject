using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            //Burada gerekli iş kodlarının yazıldığını düşünüyoruz.
            //Ürünlere erişmeye yetkisi var.
            //artık verilere erişecek.

            return _productDal.GetAll();
        }
    }
}
