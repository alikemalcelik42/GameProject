using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IValidationService
    {
        public bool Valide(Gamer gamer)
        {
            MernisService mernisService = new MernisService();
            return mernisService.Valide(gamer.FirstName, gamer.LastName, gamer.BornDate);
        }
    }
}
