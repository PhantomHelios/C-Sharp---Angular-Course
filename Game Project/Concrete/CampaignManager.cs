using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game_Project.Abstract;
using Game_Project.Entities;

namespace Game_Project.Concrete
{
    public class CampaignManager : IBaseService<Campaign>
    {
        public void Add(Campaign item)
        {
            Console.WriteLine("Campaign added: " + item.CampaignName);
        }

        public void Delete(Campaign item)
        {
            Console.WriteLine("Campaign deleted: " + item.CampaignName);
        }

        public void Update(Campaign item)
        {
            Console.WriteLine("Campaign updated: " + item.CampaignName);
        }
    }
}
