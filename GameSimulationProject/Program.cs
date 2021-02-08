using System;

namespace GameSimulationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Add(new Gamer {Id = 1, IdentityNumber = 123456, Birthyear = 1997, FirstName = "ECE NUR", LastName="DOĞAN"});

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { Id = 1, Name = "InnerSpace",Category= "Simulation", Price = 200, DiscountSalePrice = 100 });

            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.Order (new Campaign { Id = 1, Name = "50% off", Details = "Simulation Games"});
        }
    }
}
