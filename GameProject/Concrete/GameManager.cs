using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine($"{game.Name} added");
        }

        public void GetAll()
        {
            Console.WriteLine("Games listed");
        }

        public void Remove(Game game)
        {
            Console.WriteLine($"{game.Name} removed");
        }

        public void Update(Game game)
        {
            Console.WriteLine($"{game.Name} updated");
        }
    }
}
