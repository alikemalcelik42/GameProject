using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void GetAll();
        void Remove(Gamer gamer);
        void Update(Gamer gamer);
    }
}
