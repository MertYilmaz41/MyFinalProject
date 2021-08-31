using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten bir ürün var";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
