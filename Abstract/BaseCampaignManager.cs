using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public class BaseCampaignManager : ICampaignService
    {
        public void About(Campaign campaign)
        {
            Console.WriteLine("Game Name : {0}", campaign.Name);
            Console.WriteLine("Game Price : {0}", campaign.DateOfStart);
            Console.WriteLine("Game Category : {0}", campaign.DateOfFinish);
        }

        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} new campaign has been added to the database.", campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} This campaign has been deleted from the database.", campaign.Name);
        }

        public void Finish(Campaign campaign)
        {
            Console.WriteLine("{0} named campaign finished", campaign.Name);
        }

        public void Start(Campaign campaign)
        {
            Console.WriteLine("{0} named campaign has been started", campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} named campaign is updated", campaign.Name);
        }
    }
}
