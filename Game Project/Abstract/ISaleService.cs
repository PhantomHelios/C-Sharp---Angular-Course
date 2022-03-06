using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Project.Entities;

namespace Game_Project.Abstract
{
    internal interface ISaleService
    {
        void Sale(Gamer gamer, Game game, Campaign campaign);
        void Return(Gamer gamer, Game game, Campaign campaign);
    }
}
