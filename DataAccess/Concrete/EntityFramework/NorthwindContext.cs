using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    //Entity Framework ile base bir sınıf olan DbContext'te geliyor.
    public class NorthwindContext:DbContext
    {
        //burada veritabanının adresini göstericez.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*  @ işareti \ işaretini alt satıra geçme imleci
             *  olarak anlamasını engellemek için.
             *  ayrıca \ yerine \\ tane konur.  
             *  Trusted_Connection = true, bağlanırken  
             *  şifre falan sormaması için  
             */

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");

        }

        //burda tablo eşleştirmelerini belirtiyorum.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
