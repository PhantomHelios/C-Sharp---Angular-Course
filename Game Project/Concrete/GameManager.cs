using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game_Project.Entities;
using Game_Project.Abstract;

namespace Game_Project.Concrete
{
    public class GameManager : IBaseService<Game>
    {
        public void Add(Game item)
        {
            Console.WriteLine("Game added: " + item.Name);
        }

        public void Delete(Game item)
        {
            Console.WriteLine("Game deleted: " + item.Name);
        }

        public void Update(Game item)
        {
            Console.WriteLine("Game updated: " + item.Name);
        }
    }
}
