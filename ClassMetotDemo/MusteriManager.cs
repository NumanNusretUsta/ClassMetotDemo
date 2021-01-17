using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi "+musteri.Name + " "+musteri.LastName);
        }
        public void Remove(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi " + musteri.Name + " " + musteri.LastName);
        }
        public void List(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id+" "+musteri.Name+" "+musteri.LastName+" "+musteri.Rating);
            }
        }
    }
}
