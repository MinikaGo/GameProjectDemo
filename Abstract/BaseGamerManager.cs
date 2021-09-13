using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    public class BaseGamerManager : IGamerService
    {

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Gamer's Account is Saved!!!" + "(" + gamer.UserName + ")");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer's Account is Deleted!!!" + "(" + gamer.UserName + ")");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer's Account is Updated!!!" + "(" + gamer.UserName + ")");
        }

        public void About(Gamer gamer)
        {
            Console.WriteLine("Firstname : {0}", gamer.UserName);
            Console.WriteLine("LastName : {0} {1}", gamer.FirstName, gamer.LastName);
            Console.WriteLine("Favorite Game : {0}", gamer.FavoriteGame);
            Console.WriteLine("Age : {0}", gamer.Age);
        }
    }
}
