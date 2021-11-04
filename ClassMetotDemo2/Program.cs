using System;

namespace ClassMetotDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdSoyad = "Ece Nur DOĞAN";
            musteri1.KartNumarasi = 123456789;

            Musteri musteri2 = new Musteri();
            musteri2.AdSoyad = "Nur Doğan";
            musteri2.KartNumarasi = 546457899;

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2};
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.AdSoyad);
            }
        }
    }
}
