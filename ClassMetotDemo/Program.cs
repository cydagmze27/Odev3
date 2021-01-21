using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Ceyda";
            musteri1.Id = 27;
            musteri1.MusteriTc = 54556777555;
            musteri1.TelNumarasi = 5555666454;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Gamze";
            musteri2.Id = 12;
            musteri2.MusteriTc = 54456787555;
            musteri2.TelNumarasi = 5535066454;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Leyla";
            musteri3.Id = 22;
            musteri3.MusteriTc = 54456787234;
            musteri3.TelNumarasi = 5535062554;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriAdi = "Gizem";
            musteri4.Id = 20;
            musteri4.MusteriTc = 545567767555;
            musteri4.TelNumarasi = 5555666454;

            Musteri musteri5 = new Musteri();
            musteri5.MusteriAdi = "Noyan";
            musteri5.Id = 7;
            musteri5.MusteriTc = 54498787555;
            musteri5.TelNumarasi = 5533576454;

            Musteri musteri6 = new Musteri();
            musteri3.MusteriAdi = "Görkem";
            musteri3.Id = 06;
            musteri3.MusteriTc = 58856787234;
            musteri3.TelNumarasi = 5535066654;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine("---------------------------");
                Console.WriteLine(musteri.Id);
                Console.WriteLine("---------------------------");
                Console.WriteLine(musteri.MusteriTc);
                Console.WriteLine("---------------------------");
                Console.WriteLine(musteri.TelNumarasi);
                Console.WriteLine("---------------------------");

            }

            Console.WriteLine("-----------------Metotlar-----------------");

            MusteriManager musterimanager = new MusteriManager();

            musterimanager.Ekle(musteri1);
            musterimanager.Silme(musteri1);
            musterimanager.Listeleme(musteri1);

            musterimanager.Ekle(musteri2);
            musterimanager.Silme(musteri2);
            musterimanager.Listeleme(musteri2);

            musterimanager.Ekle(musteri3);
            musterimanager.Silme(musteri3);
            musterimanager.Listeleme(musteri3);

            musterimanager.Ekle(musteri4);
            musterimanager.Silme(musteri4);
            musterimanager.Listeleme(musteri4);

            musterimanager.Ekle(musteri5);
            musterimanager.Silme(musteri5);
            musterimanager.Listeleme(musteri5);

            musterimanager.Ekle(musteri6);
            musterimanager.Silme(musteri6);
            musterimanager.Listeleme(musteri6);
















        }
    }
}
