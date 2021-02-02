using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo
{
    class MusteriManager
    {
        public static void Eklemek(Musteri kisiler)
        {
            Console.WriteLine(kisiler.MusteriAd + " " + kisiler.MusteriSoyad + " " +"eklendi");
        }
        public static void Listelemek(Musteri kisiler)
        {
            Console.WriteLine(kisiler.MusteriAd + " " + kisiler.MusteriSoyad +" "+ "bilgileri");
            Console.WriteLine("müşteri tc:" + " " + kisiler.MusteriTc);
            Console.WriteLine("müşteri hesaptaki para:" + " " + kisiler.HesaptakiPara);
            Console.WriteLine("müşteri maas:" + " " + kisiler.Maas);
            double toplam = kisiler.HesaptakiPara + kisiler.Maas;
            Console.WriteLine("müşteri tolam hesaptaki para:" + " " + toplam+" " +"tl");

        }
        public static void Silmek(Musteri kisiler)
        {
            Console.WriteLine(kisiler.MusteriAd + " " + kisiler.MusteriSoyad + " " + "silindi");
        }
    }
}
