using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRM.Models
{
    public class Campaign
    {
        public int ID { get; set; }
        public string CampaignCode {get; set;}
        public string CampaignDescription { get; set; }
    }
}
