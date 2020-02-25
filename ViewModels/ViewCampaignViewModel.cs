using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCRM.Models;


namespace SimpleCRM.ViewModels
{
    public class ViewCampaignViewModel
    {
        public Campaign Campaign { get; set; }

        public string CampaignCode { get; set; }

        public IList<Transactions> Gifts { get; set; }
    }
}
