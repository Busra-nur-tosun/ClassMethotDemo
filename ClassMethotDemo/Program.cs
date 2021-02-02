using System;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriAd = "Büşra Nur ";
            musteri.MusteriSoyad = "Tosun";
            musteri.HesaptakiPara = 3600;
            musteri.Maas = 8000;
            musteri.MusteriTc = 264375;


            Musteri musteri2 = new Musteri();
            musteri2.MusteriAd = "AYŞE  ";
            musteri2.MusteriSoyad = "YILMAZ";
            musteri2.HesaptakiPara = 2000;
            musteri2.Maas = 2000;
            musteri2.MusteriTc = 26495;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAd = "DİLEK  ";
            musteri3.MusteriSoyad = "KOCA";
            musteri3.HesaptakiPara = 50.000;
            musteri3.Maas = 15300.90;
            musteri.MusteriTc = 1764375;




            MusteriManager.Eklemek(musteri);
            MusteriManager.Listelemek(musteri);
            MusteriManager.Silmek(musteri);
            Console.WriteLine("------------");


            MusteriManager.Eklemek(musteri2);
            MusteriManager.Listelemek(musteri2);
            MusteriManager.Silmek(musteri2);
            Console.WriteLine("------------");

            MusteriManager.Eklemek(musteri3);
            MusteriManager.Listelemek(musteri3);
            MusteriManager.Silmek(musteri3);
            Console.WriteLine("------------");

        }
    }
}
