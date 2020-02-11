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
        [Display(Name = "Campaign Code")]
        public string CampaignCode { get; set; }

        [Required(ErrorMessage ="A description is required")]
        [Display(Name = "Campaign Description")]
        public string CampaignDescription { get; set; }

        [Required(ErrorMessage = "Starting campaign month is required")]
        [Display(Name = "Campaign Month")]
        public string CampaignMonth { get; set; }

        [Required(ErrorMessage = "Campaign year is required")]
        [Display(Name = "Campaign Year")]
        public string CampaignYear { get; set; }
    }
}
