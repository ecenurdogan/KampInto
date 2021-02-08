using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;
        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }


        public void Order(Campaign campaign)
        {
            
            if (_campaignService.Validate(campaign)==true)
            {
                Console.WriteLine("Simülasyon Oyunlarında Geçerli %50 indirimden yararlandınız... ");
            }
            else
            {
                Console.WriteLine("Seçtiğiniz Oyun Kategorisinde Herhangi Bir İndirim Bulunmamaktadır...");
            }
          
        }

 
    }
}
