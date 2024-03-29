﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir Kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Böyle bir İsim zaten var";
        public static string CategoryLimitExceded ="Kategori limiti doldu";
    }
}
