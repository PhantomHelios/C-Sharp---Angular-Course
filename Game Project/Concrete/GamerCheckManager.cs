using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game_Project.Abstract;
using Game_Project.Entities;

namespace Game_Project.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return gamer.Name.Equals("Isa") && gamer.Surname.Equals("Karahan") && gamer.birthDate.Year == 2000 && gamer.NationalityID == 11111111111;
        }
    }
}
