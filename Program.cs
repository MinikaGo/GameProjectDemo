using System;
using GameProjectDemo.Entities;
using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;
using GameProjectDemo.Adapters;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer 
            { 
                Id = 1, 
                UserName = "proGamerX", 
                Email = "gamerProx@msi.com", 
                FirstName="gogo", 
                LastName = "Laasto", 
                DateOfBirth = new DateTime(1990,12,12), 
                NationalId = "24937031166",
                Age = "12",
                FavoriteGame = "The Witcher 3"
            };

            Game game1 = new Game
            {
                Id = 1,
                GameCategory = "RPG",
                GameName = "The Witcher 3",
                GamePrice = 39.90,
                UnitsInStock = 21

            };

            Campaign campaign1 = new Campaign
            {
                Id = 1,
                Name = "Blackfriday",
                Percentage = 10,
                DateOfStart = new DateTime(2021, 9, 9),
                DateOfFinish = new DateTime(2021, 10, 9)

            };

            //MernisServiceAdapter mernisServiceAdapter = new MernisServiceAdapter();
            //mernisServiceAdapter.Check(customer1);

            BaseGamerManager gamerManager = new GamerManager(new CustomerCheckService());
            gamerManager.Save(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.About(gamer1);

            Console.WriteLine("---------------------------------");

            BaseGameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);
            gameManager.About(game1);

            Console.WriteLine("---------------------------------");

            BaseCampaignManager campaignManager = new BaseCampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Start(campaign1);
            campaignManager.Finish(campaign1);
            campaignManager.About(campaign1);
            campaignManager.Delete(campaign1);

            Console.WriteLine("---------------------------------");

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(gamer1, game1, campaign1);


        }
    }
}
