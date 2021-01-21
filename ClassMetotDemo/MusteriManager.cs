using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Adı Eklendi:"+ musteri.MusteriAdi);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Müşteri Id Eklendi:"+ musteri.Id);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Müşteri TC Eklendi:"+ musteri.MusteriTc);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Müşteri TelNumarası Eklendi:"+ musteri.TelNumarasi);
            Console.WriteLine("----------------------------------------------------");

        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesinden Silindi:"+ musteri.MusteriAdi);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Müşteri Listesinden Silindi:" +musteri.Id);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Müşteri Listesinden Silindi:"+ musteri.MusteriTc);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Müşteri Listesinden Silindi:"+musteri.TelNumarasi);
            Console.WriteLine("----------------------------------------------------");

        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi:"+ musteri.MusteriAdi);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Müşteri Listelendi:" +musteri.Id);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Müşteri Listelendi:"+ musteri.MusteriTc);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Müşteri Listelendi:"+ musteri.TelNumarasi);
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
    