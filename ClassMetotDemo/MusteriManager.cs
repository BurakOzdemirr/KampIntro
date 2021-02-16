using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Musteri Başarıyla Eklendi : " + musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + musteri.musteriCinsiyeti);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Musteri Başarıyla Silindi : " + musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + musteri.musteriCinsiyeti);
        }

        public void List(Musteri[] musteri)
        {
            foreach (var item in musteri)
            {
                Console.WriteLine("Musteri Adı : " + item.musteriAdi);
                Console.WriteLine("Musteri Soyadı : " + item.musteriSoyadi);
                Console.WriteLine("Müsteri Cinsiyeti : " + item.musteriCinsiyeti);
            }
        }
    }
}