using System;
using System.Collections.Generic;
using System.Text;
using Game_Project.Entities;
using Game_Project.Abstract;

namespace Game_Project.Adapter
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return gamer.Name.Equals("Isa") && gamer.Surname.Equals("Karahan") && gamer.birthDate.Year == 2000 && gamer.NationalityID == 11111111111;
        }
    }
}