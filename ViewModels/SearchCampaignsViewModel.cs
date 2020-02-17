using SimpleCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRM.ViewModels
{
    public class SearchCampaignsViewModel
    {
        public List<Campaign> Campaigns { get; set; }

        [Display(Name = "Search by Campaign Code")]
        public string CampaignCode { get; set; } = "";

        [Display(Name ="Search by Campaign Description")]
        public string Description { get; set; } = "";
    }
}
