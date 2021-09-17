using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {

        public void Add(Campaign campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} added");
        }

        public void GetAll()
        {
            Console.WriteLine("Campaigns listed");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} removed");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} updated");
        }
    }
}
