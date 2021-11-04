using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList
{
    class ListManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine(product.Name+" Ürünü Listenize Eklenmiştir!!!");
        }
        public void Listele(Product product)
        {
            Console.WriteLine(product.Name+product.Price + "Listenizdeki Ürünler Listelenmiştir!!!");
        }
        public void Sil(Product product)
        {
            Console.WriteLine(product.Name + " Ürünü Listenizden Silmiştir!!!");
        }
    }
}
