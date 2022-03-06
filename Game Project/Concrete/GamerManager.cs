using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game_Project.Abstract;
using Game_Project.Entities;

namespace Game_Project.Concrete
{
    public class GamerManager : IBaseService<Gamer>
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer added: " + gamer.Name + " " + gamer.Surname);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted: " + gamer.Name + " " + gamer.Surname);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated: " + gamer.Name + " " + gamer.Surname);
        }
    }
}
