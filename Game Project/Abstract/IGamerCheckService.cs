using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Project.Entities;

namespace Game_Project.Abstract
{
    internal interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
