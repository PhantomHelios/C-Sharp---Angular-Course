using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game_Project.Abstract;
using Game_Project.Adapter;
using Game_Project.Concrete;
using Game_Project.Entities;

namespace Game_Project
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Gamer gamer = new Gamer("Isa", "Karahan", new DateTime(2000,7,5), "TR", 11111111111);
            Gamer gamer2 = new Gamer("Veli", "Koc", new DateTime(1999, 7, 12), "TR", 12345678900);


            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer);
            gamerManager.Add(gamer2);
            gamerManager.Delete(gamer2);

            Game game = new Game("GTA V", "You know this game...", 100);

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            Console.WriteLine();

            Campaign campaign = new Campaign("GTA is on sale...", 0.8);

            SaleManager saleManager = new SaleManager(new MernisServiceAdapter());
            saleManager.Sale(gamer, game, campaign);
            saleManager.Return(gamer, game, campaign);

            Console.WriteLine();

            SaleManager saleManager2 = new SaleManager(new GamerCheckManager());
            saleManager2.Sale(gamer2, game, campaign);
        }
    }
}
