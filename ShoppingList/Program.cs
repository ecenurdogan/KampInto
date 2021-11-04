using System;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elbise";
            product1.Category = "Giyim";
            product1.Price = 50;

            Product product2 = new Product();
            product2.Name = "Hırka";
            product2.Category = "Giyim";
            product2.Price = 100;

            Product[] products = new Product[] { product1, product2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
            }

            ListManager listManager = new ListManager();
            listManager.Ekle(product1);
            listManager.Ekle(product2);
            listManager.Listele(product1);
            listManager.Listele(product2);
            listManager.Sil(product1);
        }
    }
}
