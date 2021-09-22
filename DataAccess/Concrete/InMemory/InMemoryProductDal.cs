using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //bellek üzerinde ürünle ilgili veri erişim kodlarının yazıldığı yer.
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //global değişken denir.
        public InMemoryProductDal()
        {
            /*  Şuan simüle ediyoruz.
             *  Projemiz çalıştığında bu bilgiler bir veri kaynağından
             *  geliyormuş gibi düşünüyoruz.
             */
            _products = new List<Product> {
                new Product{ProductId = 1,CategoryId =1,ProductName = "Bardak",UnitPrice = 15,UnitsInStock = 15},
                new Product{ProductId = 2,CategoryId =2,ProductName = "Kamer",UnitPrice = 500,UnitsInStock = 3},
                new Product{ProductId = 3,CategoryId =2,ProductName = "Telefon",UnitPrice = 1500,UnitsInStock = 2},
                new Product{ProductId = 4,CategoryId =2,ProductName = "Klavye",UnitPrice = 150,UnitsInStock = 65},
                new Product{ProductId = 5,CategoryId =2,ProductName = "Fare",UnitPrice = 85,UnitsInStock = 1}
            };

        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // _products.Remove(product);
            /*  bu kullanım hatalıdır.
             *  Console'dan gönderilen product'ın referans numarası
             *  silinecek olan nesnenin referans numarasına eşit değildir.
             */


            Product productToDelete;

            /*
            productToDelete = null;
            foreach (var p in _products)
            {
                if(p.ProductId == product.ProductId)
                {
                    productToDelete = p;
                    break;
                }
            }
            _products.Remove(productToDelete);

             */

            //LINQ - Language Integrated Query
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //tek bir eleman bulmaya yarar.
            //59. satırdaki kod, 46. satırdaki foeach koduyla aynı görevi yapmakta.
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }


        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //tek bir eleman bulmaya yarar.
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
            /*  _products listesini dolaş. Her bir elemanın categoryId sine bak  
             *   bize parametre olarak gönderilen categoryId'ye bak.
             *  eşleşenleri bul ve liste halinde bana döndür.
             */
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
