using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseGameSaleManager : IGameSaleService
    {
        public virtual void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("{0} campaign applied.", campaign.Name);
            Console.WriteLine("{0} game has been sold to {1}", game.GameName, gamer.UserName);
        }
    }
}
