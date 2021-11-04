using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class MusteriManager
    {
        public void Listele(Musteri musteri)
        {   
            Console.WriteLine(musteri.AdSoyad);
        }
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.AdSoyad+"isimli müşteri sisteme eklenmiştir...");
        }
        public void Sil(Musteri musteri)
        {

            Console.WriteLine(musteri.AdSoyad + "isimli müşteri silinmiştir eklenmiştir...");
        }
    }
}
