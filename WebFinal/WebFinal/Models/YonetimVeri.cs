﻿namespace WebFinal.Models
{
    public class YonetimVeri
    {
        public static List<Yonetim> Yöneticiler = new List<Yonetim>()
        {
            new Yonetim()
            {
                Id = 1,
                Ad = "Muhsin Esad",
                Soyad = "İlhan",
                Gorevi = "Calısan",
                YonetimTip11 ="yok",
                YonetimTip12 ="yok",
                YonetimTip13 ="Öğrenci isleri",

            },
            new Yonetim()
            {
                Id = 2,
                Ad = "Enner",
                Soyad = "Valencia",
                Gorevi = "Calısan",
                YonetimTip11 ="yok",
                YonetimTip12 ="yok",
                YonetimTip13 ="Ögrenci isleri" ,
            },
            new Yonetim()
            {
                Id = 3,
                Ad = "Emrah",
                Soyad = "Sarı",
                Gorevi = "Öğretmen",
                YonetimTip11 ="yok",
                YonetimTip12 ="Öğretmen",
                YonetimTip13 ="yok" ,
            },
            new Yonetim()
            {
                Id = 4,
                Ad = "Mert Hakan",
                Soyad = "Yandaş",
                 Gorevi = "Calısan",
                YonetimTip11 ="İdare",
                YonetimTip12 ="yok",
                YonetimTip13 ="yok" ,
            },
        };
    }
}
