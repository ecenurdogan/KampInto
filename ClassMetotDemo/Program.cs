using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.TcKimlikNo = 123456789;
            musteri1.Id = 1;
            musteri1.AdSoyad = "Ece Nur DOGAN";
            musteri1.SubeNo = 1;
            musteri1.SubeAdi = "Cankaya";
            musteri1.IslemiGerceklestiren = "Calisan 1";

            Musteri musteri2 = new Musteri();
            musteri2.TcKimlikNo = 987654321;
            musteri2.Id = 2;
            musteri2.AdSoyad = "Ayşenur YILDIZ";
            musteri2.SubeNo = 2;
            musteri2.SubeAdi = "Kizilay";
            musteri2.IslemiGerceklestiren = "Calisan 1";



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            Console.WriteLine("Müşteri Listesi\n");
            Console.WriteLine("Müşteri No" + "    Müşteri Adı" + "   Tc Kimlik Numarası"+" " +
                               "    Şube Adı" + "      İşlemi Gerçekleştiren");
            Console.WriteLine("___________________________________________________________________________________________________");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + ".           "+ musteri.AdSoyad + "      "+ musteri.TcKimlikNo +
                    "            "+ musteri.SubeAdi +"            "+ musteri.IslemiGerceklestiren);
            }

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Listele();
           
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nGüncel Müşteri Listesi\n\n");

            Musteri musteri3 = new Musteri();
            musteri3.TcKimlikNo = 555555555;
            musteri3.Id = 3;
            musteri3.AdSoyad = "Ahmet Ali KARA";
            musteri3.SubeNo = 1;
            musteri3.SubeAdi = "Cankaya";
            musteri3.IslemiGerceklestiren = "Calisan 3";

            Musteri[] musteriler2 = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteri in musteriler2)
            {
                Console.WriteLine(musteri.Id + ".        " + musteri.AdSoyad + "      " + musteri.TcKimlikNo +
                    "            " + musteri.SubeAdi + "            " + musteri.IslemiGerceklestiren);
            }
            musterimanager.Ekle();
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nGüncel Müşteri Listesi\n\n");

             foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + ".        "+ musteri.AdSoyad + "      "+ musteri.TcKimlikNo +
                    "            "+ musteri.SubeAdi +"            "+ musteri.IslemiGerceklestiren);
            }
            musterimanager.Sil();

        }
    }
}
