using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Entities
{
    public class Campaign
    {
        public string CampaignName { get; set; }
        public double SaleRate { get; set; }

        public Campaign(string campaignName, double saleRate)
        {
            CampaignName = campaignName;
            SaleRate = saleRate;
        }
    }
}
