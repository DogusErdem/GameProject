using GameProject.Absrtact;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concerte
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"Kampanyası eklendi. İndirim yüzdeniz = %"
                +campaign.Discount*0,01);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
