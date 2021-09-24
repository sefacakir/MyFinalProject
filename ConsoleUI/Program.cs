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
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            /*foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }*/

            /*foreach (var product in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(product.ProductName);
            }*/
        }
    }
}
//abstract'ların içine referans tutucuları koyucaz.
//concrete'lere gerçek işlemleri yapanları koyucaz.