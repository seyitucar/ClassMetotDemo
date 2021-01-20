using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " eklendi");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " silindi");
        }
        public void MusteriListele(List<Musteri> musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
            }
        }
    }
}
