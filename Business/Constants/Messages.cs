﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Eklendi.";
        public static string CarNameInvalid = "Araba adı geçersiz.";
        public static string Listed = "Listelendi.";
        public static string Deleted = "Silindi.";
        public static string Updated = "Guncellendi.";
        public static string CarInvalid = "Araba şuan başka müşterimizde olduğu için kiralama işlemi gerçekleştirilemedi.";
        internal static string CarPicturesLimitExceed="Arabaya eklenecek fotoğraf sayısı aşıldı!";
    }
}
