using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using GameProjectDemo.MernisServiceReference1;

namespace GameProjectDemo.Adapters
{
    public class MernisServiceAdapter : ICheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.NationalId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), Convert.ToInt32(gamer.DateOfBirth.Year));

            //return true;
        }
    }
}
