using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary <int, string> customers = new MyDictionary<int, string>();

            customers.Add(1, "Ece Nur DOĞAN");
          
            customers.Add(5, "Mehmet YILDIZ");
            
            customers.Add(3, "Eda KARA");
           

            foreach (var customer in customers.keys)
            {
                Console.WriteLine(customer);
            }
            foreach (var customer in customers.values)
            {
                Console.WriteLine(customer);
            }



        }
    }
}
