using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game_Project.Abstract;
using Game_Project.Entities;

namespace Game_Project.Concrete
{
    internal class SaleManager : ISaleService
    {
        private IGamerCheckService _gamerCheckService;

        public SaleManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Return(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Refund has been made.");
        }

        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
                Console.WriteLine("{0} {1} bought {2} with the campaign {3}. Total cost: {4}", gamer.Name, gamer.Surname, game.Name, campaign.CampaignName, game.Price * campaign.SaleRate);
            else
                Console.WriteLine("Not a valid person.");
        }
    }
}
