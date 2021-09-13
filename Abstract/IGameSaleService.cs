using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Gamer gamer, Game game, Campaign campaign);
    }
}
