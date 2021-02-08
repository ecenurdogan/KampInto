using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }

        public bool Validate(Campaign campaign)
        {
            if (campaign.Id==1 && campaign.Name=="50% off"  
                && campaign.Details== "Simulation Games")
            {   
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
