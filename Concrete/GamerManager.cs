using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        private ICheckService _checkService;

        public GamerManager(ICheckService gamerCheckService)
        {
            _checkService = gamerCheckService;
        }

        public override void Save(Gamer gamer)
        {
            if (_checkService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("not a valid Customer");
            }
        }
    }
}
