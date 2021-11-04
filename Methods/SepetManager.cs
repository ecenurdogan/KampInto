using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi+" Eklendi!!!");
        }
        public void Sil(Urun urun)
        {
            Console.WriteLine(urun.Adi+" Silindi!!!");
        }
    }
}
