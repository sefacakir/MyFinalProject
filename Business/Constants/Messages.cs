﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        /*
         * static yazdığımız için bu class'ı newlemiyoruz.
         * zaten heryerden erişim aynı olucak.
         * 
         */
        /*
         * kullanabilmek için static kelimesiyle belirtmemiz gerekiyor.
         */
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün var.";
        internal static string CategoryLimitExceded = "Kategori sayısı 15'ten fazla olamaz.";
    }
}
