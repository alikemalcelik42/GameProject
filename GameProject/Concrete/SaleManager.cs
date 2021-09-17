using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            game.Price -= campaign.DiscountPrice;
            Console.WriteLine($"{game.Name} salled to {gamer.FirstName} for {game.Price}");
        }
    }
}
