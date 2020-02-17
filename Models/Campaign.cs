using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SimpleCRM.Models
{
    public class Campaign
    {
        public int ID { get; set; }
        public string CampaignCode {get; set;}
        public string CampaignDescription { get; set; }

        public string CampaignYear { get; set; }
        public string CampaignMonth { get; set; }
    }
}
