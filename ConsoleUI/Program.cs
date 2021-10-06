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
            CategoryTest();

           /*ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " / "+product.CategoryName);
            }*/


        }






        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
/*  
 *  abstract'ların içine referans tutucuları koyucaz.
 *  concrete'lere gerçek işlemleri yapanları koyucaz.
 */
