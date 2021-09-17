using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void GetAll();
        void Remove(Game game);
        void Update(Game game);
    }
}
