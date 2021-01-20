using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri { Id = 1, Ad = "Seyit", Soyad = "Uçar", MusteriNo = 11 };
            Musteri musteri2 = new Musteri { Id = 2, Ad = "Zeynep", Soyad = "Uçar", MusteriNo = 22 };

            List<Musteri> musteriler = new List<Musteri> { musteri1, musteri2 };
            
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);

            musteriManager.MusteriListele(musteriler);

        }
    }
}
