using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {   
        /*  SOLID
         *  Open Closed Principle
         *  Yaptığın yazılıma yeni bir özellik ekliyorsan
         *  Mevcuttaki hiçbir koduna dokunamazsın.
         *  
         */
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " / "+product.CategoryName);
            }


        }






        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
/*  
 *  abstract'ların içine referans tutucuları koyucaz.
 *  concrete'lere gerçek işlemleri yapanları koyucaz.
 */
