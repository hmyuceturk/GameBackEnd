using GameBackEnd.Abstract;
using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi : " + campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi : " + campaign.Name);
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi : " + campaign.Name);
        }
    }
}
