using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Engin";
            musteri1.LastName = "Demiroğ";
            musteri1.Rating = 99;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);

            Musteri[] musteriler = new Musteri[] {musteri1 };
            musteriManager.List(musteriler);

        }
    }
}
