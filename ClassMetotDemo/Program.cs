using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 1;
            musteri1.musteriAdi = "Burak";
            musteri1.musteriSoyadi ="Özdemir";
            musteri1.musteriCinsiyeti = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 2;
            musteri2.musteriAdi = "Ayşenur";
            musteri2.musteriSoyadi = "Aykurt";
            musteri2.musteriCinsiyeti = "Kadın";

            Musteri musteri3 = new Musteri();
            musteri3.musteriId = 3;
            musteri3.musteriAdi = "Buket";
            musteri3.musteriSoyadi = "Özdemir";
            musteri3.musteriCinsiyeti = "Kadın";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.List(musteriler);
        }
    }
}
