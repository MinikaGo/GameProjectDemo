using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseGameManager : IGameService
    {
        public void About(Game game)
        {
            Console.WriteLine("Game Name : {0}", game.GameName);
            Console.WriteLine("Game Price : {0}", game.GamePrice);
            Console.WriteLine("Game Category : {0}", game.GameCategory);
        }

        public virtual void Add(Game game)
        {
            Console.WriteLine("Game Has Been Added to DataBase" + "(" + game.GameName + ")");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game Has Been Added to DataBase" + "(" + game.GameName + ")");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game Has Been Added to DataBase" + "(" + game.GameName + ")");
        }
    }
}
