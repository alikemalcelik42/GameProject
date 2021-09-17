using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            gameManager.Add(new Game()
            {
                Id = 1,
                Name = "Minecraft",
                Price = 40.50m
            });

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(new Gamer()
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Demir",
                BornDate = new DateTime(2000, 4, 2)
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign()
            {
                Id = 1,
                CampaignName = "Winter Campaign",
                DiscountPrice = 10,
                FinishDate = new DateTime(2021, 9, 25)
            });

            SaleManager saleManager = new SaleManager();
            
            saleManager.Sale(new Gamer()
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Demir",
                BornDate = new DateTime(2000, 4, 2)
            },
            new Game()
            {
                Id = 1,
                Name = "Minecraft",
                Price = 40.50m
            },
            new Campaign()
            {
                Id = 1,
                CampaignName = "Winter Campaign",
                DiscountPrice = 10,
                FinishDate = new DateTime(2021, 9, 25)
            });

        }
    }
}
