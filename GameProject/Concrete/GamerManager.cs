using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IValidationService validationService;

        public GamerManager(IValidationService validationService)
        {
            this.validationService = validationService;
        }

        public void Add(Gamer gamer)
        {
            if(validationService.Valide(gamer))
                Console.WriteLine($"{gamer.FirstName} added");
            else
                Console.WriteLine("User infos not valid");
        }

        public void GetAll()
        {
            Console.WriteLine("Gamers listed");
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName} removed");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName} updated");
        }
    }
}
