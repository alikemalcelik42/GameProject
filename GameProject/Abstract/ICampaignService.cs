using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign game);
        void GetAll();
        void Remove(Campaign game);
        void Update(Campaign game);
    }
}
