using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SimpleCRM.Models;

namespace SimpleCRM.ViewModels
{
    public class AddCampaignViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campaign code is required")]
        public string CampaignCode { get; set; }

        [Required(ErrorMessage ="A description is required")]
        public string CampaignDescription { get; set; }

        [Required(ErrorMessage = "Starting campaign month is required")]
        public string CampaignMonth { get; set; }

        [Required(ErrorMessage = "Campaign year is required")]
        public string CampaignYear { get; set; }
    }
}
