using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Product product)
        {
            //ürünü eklemeden önceki kuralları geçerse ekleme işlemi yapılır.

            if (product.ProductName.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }
         
        public List<Product> GetAll()
        {
            //Burada gerekli iş kodlarının yazıldığını düşünüyoruz.
            //Ürünlere erişmeye yetkisi var.
            //artık verilere erişecek.

            return _productDal.GetAll();
        }
        
        public List<Product> GetAllByCategoryId(int id)
        {
            //gönderdiğim categoryId'sine göre filtrele demek.
            return _productDal.GetAll(p => p.CategoryId == id);
        }
        
        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }
        
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
        
        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
